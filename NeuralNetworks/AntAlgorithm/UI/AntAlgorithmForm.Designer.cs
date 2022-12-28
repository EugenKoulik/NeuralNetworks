using System.Windows.Forms;

namespace NeuralNetworks.AntAlgorithm.UI
{
    partial class AntAlgorithmForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.countIterationsNumeric = new System.Windows.Forms.NumericUpDown();
            this.countAntsNumeric = new System.Windows.Forms.NumericUpDown();
            this.startButton = new System.Windows.Forms.Button();
            this.alphaNumeric = new System.Windows.Forms.NumericUpDown();
            this.betaNumeric = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.countVertex = new System.Windows.Forms.NumericUpDown();
            this.randomWeightsButton = new System.Windows.Forms.Button();
            this.matrixGridView = new System.Windows.Forms.DataGridView();
            this.isSimmetricCheckBox = new System.Windows.Forms.CheckBox();
            this.maxRandomNumeric = new System.Windows.Forms.NumericUpDown();
            this.evaporationRatioNumeric = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.qRatioNumeric = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.pheromonesGridView = new System.Windows.Forms.DataGridView();
            this.shortestPathLabel = new System.Windows.Forms.Label();
            this.sumWeightLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.countIterationsNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countAntsNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alphaNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.betaNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countVertex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrixGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxRandomNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.evaporationRatioNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qRatioNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pheromonesGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // countIterationsNumeric
            // 
            this.countIterationsNumeric.Location = new System.Drawing.Point(257, 506);
            this.countIterationsNumeric.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.countIterationsNumeric.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            this.countIterationsNumeric.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.countIterationsNumeric.Name = "countIterationsNumeric";
            this.countIterationsNumeric.Size = new System.Drawing.Size(68, 22);
            this.countIterationsNumeric.TabIndex = 0;
            this.countIterationsNumeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.countIterationsNumeric.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // countAntsNumeric
            // 
            this.countAntsNumeric.Location = new System.Drawing.Point(257, 474);
            this.countAntsNumeric.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.countAntsNumeric.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            this.countAntsNumeric.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.countAntsNumeric.Name = "countAntsNumeric";
            this.countAntsNumeric.Size = new System.Drawing.Size(68, 22);
            this.countAntsNumeric.TabIndex = 1;
            this.countAntsNumeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.countAntsNumeric.Value = new decimal(new int[] { 1, 0, 0, 0 });
            this.countAntsNumeric.ValueChanged += new System.EventHandler(this.countAntsNumeric_ValueChanged);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(383, 609);
            this.startButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(735, 34);
            this.startButton.TabIndex = 4;
            this.startButton.Text = "Вычислить";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // alphaNumeric
            // 
            this.alphaNumeric.DecimalPlaces = 1;
            this.alphaNumeric.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            this.alphaNumeric.Location = new System.Drawing.Point(257, 540);
            this.alphaNumeric.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.alphaNumeric.Minimum = new decimal(new int[] { 100, 0, 0, -2147483648 });
            this.alphaNumeric.Name = "alphaNumeric";
            this.alphaNumeric.Size = new System.Drawing.Size(68, 22);
            this.alphaNumeric.TabIndex = 5;
            this.alphaNumeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.alphaNumeric.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // betaNumeric
            // 
            this.betaNumeric.DecimalPlaces = 1;
            this.betaNumeric.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            this.betaNumeric.Location = new System.Drawing.Point(257, 569);
            this.betaNumeric.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.betaNumeric.Minimum = new decimal(new int[] { 100, 0, 0, -2147483648 });
            this.betaNumeric.Name = "betaNumeric";
            this.betaNumeric.Size = new System.Drawing.Size(68, 22);
            this.betaNumeric.TabIndex = 7;
            this.betaNumeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.betaNumeric.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 571);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Коеффициент бета";
            // 
            // countVertex
            // 
            this.countVertex.Location = new System.Drawing.Point(165, 382);
            this.countVertex.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.countVertex.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            this.countVertex.Name = "countVertex";
            this.countVertex.Size = new System.Drawing.Size(68, 22);
            this.countVertex.TabIndex = 10;
            this.countVertex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.countVertex.Value = new decimal(new int[] { 5, 0, 0, 0 });
            this.countVertex.ValueChanged += new System.EventHandler(this.countVertex_ValueChanged);
            // 
            // randomWeightsButton
            // 
            this.randomWeightsButton.Location = new System.Drawing.Point(15, 421);
            this.randomWeightsButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.randomWeightsButton.Name = "randomWeightsButton";
            this.randomWeightsButton.Size = new System.Drawing.Size(349, 29);
            this.randomWeightsButton.TabIndex = 14;
            this.randomWeightsButton.Text = "Сгенерировать матрицу";
            this.randomWeightsButton.UseVisualStyleBackColor = true;
            this.randomWeightsButton.Click += new System.EventHandler(this.randomWeightsButton_Click);
            // 
            // matrixGridView
            // 
            this.matrixGridView.AllowUserToAddRows = false;
            this.matrixGridView.AllowUserToDeleteRows = false;
            this.matrixGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.matrixGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.matrixGridView.Location = new System.Drawing.Point(15, 14);
            this.matrixGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.matrixGridView.MultiSelect = false;
            this.matrixGridView.Name = "matrixGridView";
            this.matrixGridView.RowHeadersWidth = 51;
            this.matrixGridView.RowTemplate.Height = 29;
            this.matrixGridView.Size = new System.Drawing.Size(349, 272);
            this.matrixGridView.TabIndex = 16;
            this.matrixGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.matrixGridView_CellValueChanged);
            // 
            // isSimmetricCheckBox
            // 
            this.isSimmetricCheckBox.AutoSize = true;
            this.isSimmetricCheckBox.Location = new System.Drawing.Point(165, 350);
            this.isSimmetricCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.isSimmetricCheckBox.Name = "isSimmetricCheckBox";
            this.isSimmetricCheckBox.Size = new System.Drawing.Size(18, 17);
            this.isSimmetricCheckBox.TabIndex = 17;
            this.isSimmetricCheckBox.UseVisualStyleBackColor = true;
            this.isSimmetricCheckBox.CheckedChanged += new System.EventHandler(this.isSimmetricCheckBox_CheckedChanged);
            // 
            // maxRandomNumeric
            // 
            this.maxRandomNumeric.Location = new System.Drawing.Point(165, 313);
            this.maxRandomNumeric.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maxRandomNumeric.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            this.maxRandomNumeric.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            this.maxRandomNumeric.Name = "maxRandomNumeric";
            this.maxRandomNumeric.Size = new System.Drawing.Size(51, 22);
            this.maxRandomNumeric.TabIndex = 18;
            this.maxRandomNumeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maxRandomNumeric.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // evaporationRatioNumeric
            // 
            this.evaporationRatioNumeric.DecimalPlaces = 1;
            this.evaporationRatioNumeric.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            this.evaporationRatioNumeric.Location = new System.Drawing.Point(257, 598);
            this.evaporationRatioNumeric.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.evaporationRatioNumeric.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            this.evaporationRatioNumeric.Name = "evaporationRatioNumeric";
            this.evaporationRatioNumeric.Size = new System.Drawing.Size(68, 22);
            this.evaporationRatioNumeric.TabIndex = 22;
            this.evaporationRatioNumeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.evaporationRatioNumeric.Value = new decimal(new int[] { 5, 0, 0, 65536 });
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 600);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(177, 17);
            this.label9.TabIndex = 23;
            this.label9.Text = "Коеффициент испарения";
            // 
            // qRatioNumeric
            // 
            this.qRatioNumeric.Location = new System.Drawing.Point(257, 626);
            this.qRatioNumeric.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.qRatioNumeric.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            this.qRatioNumeric.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.qRatioNumeric.Name = "qRatioNumeric";
            this.qRatioNumeric.Size = new System.Drawing.Size(68, 22);
            this.qRatioNumeric.TabIndex = 24;
            this.qRatioNumeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.qRatioNumeric.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 626);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(117, 17);
            this.label10.TabIndex = 25;
            this.label10.Text = "Коеффициент Q";
            // 
            // pheromonesGridView
            // 
            this.pheromonesGridView.AllowUserToAddRows = false;
            this.pheromonesGridView.AllowUserToDeleteRows = false;
            this.pheromonesGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.pheromonesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pheromonesGridView.Location = new System.Drawing.Point(383, 14);
            this.pheromonesGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pheromonesGridView.MultiSelect = false;
            this.pheromonesGridView.Name = "pheromonesGridView";
            this.pheromonesGridView.ReadOnly = true;
            this.pheromonesGridView.RowHeadersWidth = 51;
            this.pheromonesGridView.RowTemplate.Height = 29;
            this.pheromonesGridView.Size = new System.Drawing.Size(735, 408);
            this.pheromonesGridView.TabIndex = 26;
            // 
            // shortestPathLabel
            // 
            this.shortestPathLabel.AutoSize = true;
            this.shortestPathLabel.Location = new System.Drawing.Point(591, 474);
            this.shortestPathLabel.Name = "shortestPathLabel";
            this.shortestPathLabel.Size = new System.Drawing.Size(54, 17);
            this.shortestPathLabel.TabIndex = 28;
            this.shortestPathLabel.Text = "label12";
            // 
            // sumWeightLabel
            // 
            this.sumWeightLabel.AutoSize = true;
            this.sumWeightLabel.Location = new System.Drawing.Point(591, 540);
            this.sumWeightLabel.Name = "sumWeightLabel";
            this.sumWeightLabel.Size = new System.Drawing.Size(54, 17);
            this.sumWeightLabel.TabIndex = 31;
            this.sumWeightLabel.Text = "label13";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(15, 315);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 24);
            this.label5.TabIndex = 32;
            this.label5.Text = "Маскимальный вес         ";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(15, 349);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 24);
            this.label7.TabIndex = 33;
            this.label7.Text = "Симметричность";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(15, 382);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 19);
            this.label6.TabIndex = 34;
            this.label6.Text = "Количество вершин";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(12, 477);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(239, 19);
            this.label8.TabIndex = 35;
            this.label8.Text = "Количество итераций";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 509);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 19);
            this.label1.TabIndex = 36;
            this.label1.Text = "Количество муравьёв";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 540);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 19);
            this.label2.TabIndex = 37;
            this.label2.Text = "Коэффициент альфа";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(383, 474);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 19);
            this.label3.TabIndex = 38;
            this.label3.Text = "Shortest Hamiltonian cycle   - ";
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(383, 540);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(202, 19);
            this.label11.TabIndex = 39;
            this.label11.Text = "Total cycle weight                 -";
            // 
            // AntAlgorithmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 678);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.sumWeightLabel);
            this.Controls.Add(this.shortestPathLabel);
            this.Controls.Add(this.pheromonesGridView);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.qRatioNumeric);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.evaporationRatioNumeric);
            this.Controls.Add(this.maxRandomNumeric);
            this.Controls.Add(this.isSimmetricCheckBox);
            this.Controls.Add(this.matrixGridView);
            this.Controls.Add(this.randomWeightsButton);
            this.Controls.Add(this.countVertex);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.betaNumeric);
            this.Controls.Add(this.alphaNumeric);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.countAntsNumeric);
            this.Controls.Add(this.countIterationsNumeric);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AntAlgorithmForm";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AntAlgorithmForm_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.countIterationsNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countAntsNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alphaNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.betaNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countVertex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrixGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxRandomNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.evaporationRatioNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qRatioNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pheromonesGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label11;

        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Label label8;

        private System.Windows.Forms.Label label7;

        #endregion

        private System.Windows.Forms.NumericUpDown countIterationsNumeric;
        private System.Windows.Forms.NumericUpDown countAntsNumeric;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.NumericUpDown alphaNumeric;
        private System.Windows.Forms.NumericUpDown betaNumeric;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown countVertex;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button randomWeightsButton;
        private System.Windows.Forms.DataGridView matrixGridView;
        private System.Windows.Forms.CheckBox isSimmetricCheckBox;
        private System.Windows.Forms.NumericUpDown maxRandomNumeric;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown evaporationRatioNumeric;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown qRatioNumeric;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView pheromonesGridView;
        private System.Windows.Forms.Label shortestPathLabel;
        private System.Windows.Forms.Label sumWeightLabel;
    }
}