﻿using System.Windows.Forms;

namespace NeuralNetworks.BeeAlgorithm.UI
{
    partial class BeeForm
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.customFunctionTextBox = new System.Windows.Forms.TextBox();
            this.functionsLabel = new System.Windows.Forms.Label();
            this.functionsListBox = new System.Windows.Forms.ListBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.countScoutBeesNumeric = new System.Windows.Forms.NumericUpDown();
            this.countEliteBeesNumeric = new System.Windows.Forms.NumericUpDown();
            this.countDefaultBeesNumeric = new System.Windows.Forms.NumericUpDown();
            this.deltaNumeric = new System.Windows.Forms.NumericUpDown();
            this.countIterationsNumeric = new System.Windows.Forms.NumericUpDown();
            this.countLocalSearchNumeric = new System.Windows.Forms.NumericUpDown();
            this.countElitePointsNumeric = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.upperBoundNumeric = new System.Windows.Forms.NumericUpDown();
            this.lowerBoundNumeric = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.countScoutBeesNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countEliteBeesNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countDefaultBeesNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deltaNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countIterationsNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countLocalSearchNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countElitePointsNumeric)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upperBoundNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lowerBoundNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // customFunctionTextBox
            // 
            this.customFunctionTextBox.Location = new System.Drawing.Point(350, 217);
            this.customFunctionTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.customFunctionTextBox.Name = "customFunctionTextBox";
            this.customFunctionTextBox.Size = new System.Drawing.Size(297, 20);
            this.customFunctionTextBox.TabIndex = 5;
            this.customFunctionTextBox.Text = "f(x1, x2) = ";
            // 
            // functionsLabel
            // 
            this.functionsLabel.AutoSize = true;
            this.functionsLabel.Location = new System.Drawing.Point(419, 9);
            this.functionsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.functionsLabel.Name = "functionsLabel";
            this.functionsLabel.Size = new System.Drawing.Size(139, 13);
            this.functionsLabel.TabIndex = 4;
            this.functionsLabel.Text = "Математические функции";
            // 
            // functionsListBox
            // 
            this.functionsListBox.FormattingEnabled = true;
            this.functionsListBox.Items.AddRange(new object[] {
            "f(x1,x2) = x1^2 +3*x2^2 + 2*x1*x2",
            "f(x1,x2) = 100*(x2-x1^2)^2 + (1-x1)^2",
            "f(x1,x2) = -12*x2 + 4*x1^2 + 4*x2^2 - 4*x1*x2",
            "f(x1,x2) = (x1-2)^4 + (x1-2*x2)^2",
            "f(x1,x2) = 4*(x1-5)^2 + (x2-6)^2",
            "f(x1,x2) = 2* x1^3 + 4*x1*x2^3 - 10* x1*x2 + x2^2",
            "f(x1,x2) = 8*x1^2 + 4*x1*x2 + 5 * x2^2",
            "f(x1,x2,x3) = (x1-1)^2 + (x2-3)^2 + 4*(x3+5)^2",
            "f(x1,x2) = (x2-x1^2)^2 + (1-x1)^2",
            "f(x1,x2) = (x2-x1^2)^2 + 100*(1-x1)^2",
            "f(x1,x2,x3) = 3*(x1-4)^2 + 5*(x2+3)^2 + 7*(2*x3+1)^2",
            "f(x1,x2) = x1^3 + x2^2 - 3*x2 -2*x2 + 2"});
            this.functionsListBox.Location = new System.Drawing.Point(350, 24);
            this.functionsListBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.functionsListBox.Name = "functionsListBox";
            this.functionsListBox.Size = new System.Drawing.Size(297, 173);
            this.functionsListBox.TabIndex = 3;
            this.functionsListBox.SelectedIndexChanged += new System.EventHandler(this.functionsListBox_SelectedIndexChanged);
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(379, 285);
            this.calculateButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(70, 19);
            this.calculateButton.TabIndex = 6;
            this.calculateButton.Text = "Посчитать";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // countScoutBeesNumeric
            // 
            this.countScoutBeesNumeric.Location = new System.Drawing.Point(230, 50);
            this.countScoutBeesNumeric.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.countScoutBeesNumeric.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.countScoutBeesNumeric.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.countScoutBeesNumeric.Name = "countScoutBeesNumeric";
            this.countScoutBeesNumeric.Size = new System.Drawing.Size(64, 20);
            this.countScoutBeesNumeric.TabIndex = 7;
            this.countScoutBeesNumeric.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.countScoutBeesNumeric.ValueChanged += new System.EventHandler(this.countScoutBeesNumeric_ValueChanged);
            // 
            // countEliteBeesNumeric
            // 
            this.countEliteBeesNumeric.Location = new System.Drawing.Point(230, 26);
            this.countEliteBeesNumeric.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.countEliteBeesNumeric.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.countEliteBeesNumeric.Name = "countEliteBeesNumeric";
            this.countEliteBeesNumeric.Size = new System.Drawing.Size(64, 20);
            this.countEliteBeesNumeric.TabIndex = 8;
            this.countEliteBeesNumeric.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // countDefaultBeesNumeric
            // 
            this.countDefaultBeesNumeric.Location = new System.Drawing.Point(230, 78);
            this.countDefaultBeesNumeric.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.countDefaultBeesNumeric.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.countDefaultBeesNumeric.Name = "countDefaultBeesNumeric";
            this.countDefaultBeesNumeric.Size = new System.Drawing.Size(64, 20);
            this.countDefaultBeesNumeric.TabIndex = 9;
            this.countDefaultBeesNumeric.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // deltaNumeric
            // 
            this.deltaNumeric.DecimalPlaces = 1;
            this.deltaNumeric.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.deltaNumeric.Location = new System.Drawing.Point(230, 52);
            this.deltaNumeric.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.deltaNumeric.Name = "deltaNumeric";
            this.deltaNumeric.Size = new System.Drawing.Size(64, 20);
            this.deltaNumeric.TabIndex = 10;
            this.deltaNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // countIterationsNumeric
            // 
            this.countIterationsNumeric.Location = new System.Drawing.Point(484, 251);
            this.countIterationsNumeric.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.countIterationsNumeric.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.countIterationsNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.countIterationsNumeric.Name = "countIterationsNumeric";
            this.countIterationsNumeric.Size = new System.Drawing.Size(64, 20);
            this.countIterationsNumeric.TabIndex = 11;
            this.countIterationsNumeric.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // countLocalSearchNumeric
            // 
            this.countLocalSearchNumeric.Location = new System.Drawing.Point(230, 24);
            this.countLocalSearchNumeric.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.countLocalSearchNumeric.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.countLocalSearchNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.countLocalSearchNumeric.Name = "countLocalSearchNumeric";
            this.countLocalSearchNumeric.Size = new System.Drawing.Size(64, 20);
            this.countLocalSearchNumeric.TabIndex = 12;
            this.countLocalSearchNumeric.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            this.countLocalSearchNumeric.ValueChanged += new System.EventHandler(this.countLocalSearchNumeric_ValueChanged);
            // 
            // countElitePointsNumeric
            // 
            this.countElitePointsNumeric.Location = new System.Drawing.Point(230, 84);
            this.countElitePointsNumeric.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.countElitePointsNumeric.Name = "countElitePointsNumeric";
            this.countElitePointsNumeric.Size = new System.Drawing.Size(64, 20);
            this.countElitePointsNumeric.TabIndex = 13;
            this.countElitePointsNumeric.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 56);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Количество пчёл-разведчиков";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 29);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Количество точек локального поиска";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 84);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Количество точек для элитных пчёл";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 26);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Количество элитных пчёл";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 83);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Количество рабочих пчёл";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 52);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Окрестность точки";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(347, 250);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Сколько итераций";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.countScoutBeesNumeric);
            this.groupBox1.Controls.Add(this.countEliteBeesNumeric);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.countDefaultBeesNumeric);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(16, 217);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(308, 112);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Пчёлы";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.countLocalSearchNumeric);
            this.groupBox2.Controls.Add(this.countElitePointsNumeric);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.deltaNumeric);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(12, 24);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(308, 108);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Точки";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.upperBoundNumeric);
            this.groupBox3.Controls.Add(this.lowerBoundNumeric);
            this.groupBox3.Location = new System.Drawing.Point(16, 137);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(308, 76);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Границы поиска";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 24);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Верхняя граница";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 48);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Нижняя граница";
            // 
            // upperBoundNumeric
            // 
            this.upperBoundNumeric.Location = new System.Drawing.Point(230, 24);
            this.upperBoundNumeric.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.upperBoundNumeric.Name = "upperBoundNumeric";
            this.upperBoundNumeric.Size = new System.Drawing.Size(64, 20);
            this.upperBoundNumeric.TabIndex = 1;
            this.upperBoundNumeric.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.upperBoundNumeric.ValueChanged += new System.EventHandler(this.upperBoundNumeric_ValueChanged);
            // 
            // lowerBoundNumeric
            // 
            this.lowerBoundNumeric.Location = new System.Drawing.Point(230, 52);
            this.lowerBoundNumeric.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lowerBoundNumeric.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.lowerBoundNumeric.Name = "lowerBoundNumeric";
            this.lowerBoundNumeric.Size = new System.Drawing.Size(64, 20);
            this.lowerBoundNumeric.TabIndex = 0;
            this.lowerBoundNumeric.Value = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.lowerBoundNumeric.ValueChanged += new System.EventHandler(this.lowerBoundNumeric_ValueChanged);
            // 
            // BeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 331);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.countIterationsNumeric);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.customFunctionTextBox);
            this.Controls.Add(this.functionsLabel);
            this.Controls.Add(this.functionsListBox);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "BeeForm";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BeeForm_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.countScoutBeesNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countEliteBeesNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countDefaultBeesNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deltaNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countIterationsNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countLocalSearchNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countElitePointsNumeric)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upperBoundNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lowerBoundNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox customFunctionTextBox;
        private Label functionsLabel;
        private ListBox functionsListBox;
        private Button calculateButton;
        private NumericUpDown countScoutBeesNumeric;
        private NumericUpDown countEliteBeesNumeric;
        private NumericUpDown countDefaultBeesNumeric;
        private NumericUpDown deltaNumeric;
        private NumericUpDown countIterationsNumeric;
        private NumericUpDown countLocalSearchNumeric;
        private NumericUpDown countElitePointsNumeric;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label label9;
        private Label label8;
        private NumericUpDown upperBoundNumeric;
        private NumericUpDown lowerBoundNumeric;
    }
}