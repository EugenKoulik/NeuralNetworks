using NeuralNetworks.AntAlgorithm.Algorithm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NeuralNetworks.AntAlgorithm.UI
{
    public partial class AntAlgorithmForm : Form
    {
        private (double Weight, double Pheromone)[,] _matrix;
        private List<int> _shortestPath;

        private readonly Form _parentForm;
        public AntAlgorithmForm(Form parentForm)
        {
            _parentForm = parentForm;
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            _matrix = new (double Weight, double Pheromone)[(int)countVertex.Value, (int)countVertex.Value];

            ResetPheromones();
            InitializeMatrix();

            shortestPathLabel.Text = "";
            sumWeightLabel.Text = "";
            _shortestPath = new List<int>();
        }
        private void countAntsNumeric_ValueChanged(object sender, EventArgs e)
        {

        }
        private void countVertex_ValueChanged(object sender, EventArgs e)
        {
            _matrix = new (double Weight, double Pheromone)[(int)countVertex.Value, (int)countVertex.Value];

            InitializeMatrix();
        }
        private void randomWeightsButton_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            double startedPheromone = 1;

            int maxRandom = (int)maxRandomNumeric.Value;

            for (int i = 0; i < countVertex.Value; i++)
            {
                for (int j = 0; j < countVertex.Value; j++)
                {
                    if (i != j)
                    {
                        _matrix[i, j] = (random.Next(maxRandom) + 1, startedPheromone);
                    }

                    if (isSimmetricCheckBox.Checked && j <= i)
                    {
                        _matrix[j, i] = _matrix[i, j];
                    }
                }
            }

            InitializeMatrix();
        }
        private void InitializeMatrix()
        {
            matrixGridView.RowCount = (int)countVertex.Value;
            matrixGridView.ColumnCount = (int)countVertex.Value;
            pheromonesGridView.RowCount = (int)countVertex.Value;
            pheromonesGridView.ColumnCount = (int)countVertex.Value;

            for (var i = 0; i < (int)countVertex.Value; i++)
            {
                matrixGridView.Rows[i].HeaderCell.Value = (i + 1).ToString();
                matrixGridView.Columns[i].HeaderCell.Value = (i + 1).ToString();
                pheromonesGridView.Rows[i].HeaderCell.Value = (i + 1).ToString();
                pheromonesGridView.Columns[i].HeaderCell.Value = (i + 1).ToString();
            }

            for (var i = 0; i < _matrix.GetLength(0); i++)
            {
                for (var j = 0; j < _matrix.GetLength(0); j++)
                {
                    matrixGridView.Rows[i].Cells[j].Value = _matrix[i, j].Weight;
                    matrixGridView.Columns[j].Width = 40;
                    matrixGridView.Rows[i].Cells[j].ReadOnly = isSimmetricCheckBox.Checked && j <= i;
                    pheromonesGridView.Rows[i].Cells[j].Value = _matrix[i, j].Pheromone;
                    pheromonesGridView.Columns[j].Width = 80;
                }
            }
        }
        private void matrixGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            var row = e.RowIndex;
            var column = e.ColumnIndex;

            if (row < 0 || column < 0)
            {
                return;
            }

            var oldValue = _matrix[row, column];

            if (int.TryParse(matrixGridView.Rows[row].Cells[column].Value.ToString(), out var newValue)
                && newValue > 0)
            {
                _matrix[row, column] = (newValue, _matrix[row, column].Pheromone);
            }
            else
            {
                matrixGridView.Rows[row].Cells[column].Value = oldValue.Weight;
            }

            if (isSimmetricCheckBox.Checked)
            {
                matrixGridView.Rows[column].Cells[row].Value = matrixGridView.Rows[row].Cells[column].Value;
            }
        }
        private void isSimmetricCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            for (var i = 0; i < _matrix.GetLength(0); i++)
            {
                for (var j = i + 1; j < _matrix.GetLength(0); j++)
                {
                    _matrix[j, i] = _matrix[i, j];
                }
            }

            InitializeMatrix();
        }
        private async void startButton_Click(object sender, EventArgs e)
        {
            var algorithm = new AntAlgorithmLogic(
                (int)alphaNumeric.Value,
                (int)betaNumeric.Value);

            ResetPheromones();

            startButton.Enabled = false;

            await Task.Run(() => algorithm.Run((int)countIterationsNumeric.Value, (int)countAntsNumeric.Value, _matrix, (double)evaporationRatioNumeric.Value, (double)qRatioNumeric.Value));

            startButton.Enabled = true;


            for (var i = 0; i < _matrix.GetLength(0); i++)
            {
                for (var j = 0; j < _matrix.GetLength(0); j++)
                {
                    pheromonesGridView.Rows[i].Cells[j].Value = _matrix[i, j].Pheromone;
                }
            }

            _shortestPath = algorithm.GetShortestHamiltonCycle(_matrix);
            shortestPathLabel.Text = string.Join("->", _shortestPath.Select(v => v + 1).ToList());
            sumWeightLabel.Text = ((int)algorithm.SumWeight(_matrix)).ToString();
        }

        private void ResetPheromones()
        {
            for (int i = 0; i < _matrix.GetLength(0); i++)
            {
                for (int j = 0; j < _matrix.GetLength(0); j++)
                {
                    _matrix[i, j].Pheromone = i == j ? 0 : 1;
                }
            }
        }

        private void AntAlgorithmForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _parentForm.Show();
        }
    }
}
