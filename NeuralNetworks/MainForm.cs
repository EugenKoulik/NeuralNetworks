using NeuralNetworks.GeneticAlgorithm.UI;
using System;
using System.Windows.Forms;

namespace NeuralNetworks
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            var hopfieldForm = new Hopfield(this);
            hopfieldForm.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var hammingForm = new Hamming(this);
            hammingForm.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var geneticForm = new GeneticForm(this);
            geneticForm.Show();
            Hide();
        }
    }
}