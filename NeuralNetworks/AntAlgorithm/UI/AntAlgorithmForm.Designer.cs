﻿using System.Windows.Forms;

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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.countIterationsNumeric = new System.Windows.Forms.NumericUpDown();
            this.countAntsNumeric = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.alphaNumeric = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.betaNumeric = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.countVertex = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.graphPictureBox = new System.Windows.Forms.PictureBox();
            this.randomWeightsButton = new System.Windows.Forms.Button();
            this.matrixGridView = new System.Windows.Forms.DataGridView();
            this.isSimmetricCheckBox = new System.Windows.Forms.CheckBox();
            this.maxRandomNumeric = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.animationGroupBox = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.speedAnimationNumeric = new System.Windows.Forms.NumericUpDown();
            this.iterationResultButton = new System.Windows.Forms.RadioButton();
            this.endedResultButton = new System.Windows.Forms.RadioButton();
            this.evaporationRatioNumeric = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.qRatioNumeric = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.pheromonesGridView = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.shortestPathLabel = new System.Windows.Forms.Label();
            this.showPathButton = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.sumWeightLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.countIterationsNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countAntsNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alphaNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.betaNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countVertex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graphPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrixGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxRandomNumeric)).BeginInit();
            this.animationGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.speedAnimationNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.evaporationRatioNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qRatioNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pheromonesGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // countIterationsNumeric
            // 
            this.countIterationsNumeric.Location = new System.Drawing.Point(761, 128);
            this.countIterationsNumeric.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.countIterationsNumeric.Maximum = new decimal(new int[] {
            10000,
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
            this.countIterationsNumeric.TabIndex = 0;
            this.countIterationsNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // countAntsNumeric
            // 
            this.countAntsNumeric.Location = new System.Drawing.Point(761, 167);
            this.countAntsNumeric.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.countAntsNumeric.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.countAntsNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.countAntsNumeric.Name = "countAntsNumeric";
            this.countAntsNumeric.Size = new System.Drawing.Size(64, 20);
            this.countAntsNumeric.TabIndex = 1;
            this.countAntsNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.countAntsNumeric.ValueChanged += new System.EventHandler(this.countAntsNumeric_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(758, 113);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Количество итераций";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(758, 152);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Количество муравьев";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(373, 345);
            this.startButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(70, 19);
            this.startButton.TabIndex = 4;
            this.startButton.Text = "Старт";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // alphaNumeric
            // 
            this.alphaNumeric.DecimalPlaces = 1;
            this.alphaNumeric.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.alphaNumeric.Location = new System.Drawing.Point(922, 128);
            this.alphaNumeric.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.alphaNumeric.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.alphaNumeric.Name = "alphaNumeric";
            this.alphaNumeric.Size = new System.Drawing.Size(64, 20);
            this.alphaNumeric.TabIndex = 5;
            this.alphaNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(907, 113);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Коеффициент альфа";
            // 
            // betaNumeric
            // 
            this.betaNumeric.DecimalPlaces = 1;
            this.betaNumeric.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.betaNumeric.Location = new System.Drawing.Point(1039, 167);
            this.betaNumeric.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.betaNumeric.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.betaNumeric.Name = "betaNumeric";
            this.betaNumeric.Size = new System.Drawing.Size(64, 20);
            this.betaNumeric.TabIndex = 7;
            this.betaNumeric.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1036, 150);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Коеффициент бета";
            // 
            // countVertex
            // 
            this.countVertex.Location = new System.Drawing.Point(179, 414);
            this.countVertex.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.countVertex.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.countVertex.Name = "countVertex";
            this.countVertex.Size = new System.Drawing.Size(64, 20);
            this.countVertex.TabIndex = 10;
            this.countVertex.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.countVertex.ValueChanged += new System.EventHandler(this.countVertex_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(176, 386);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Количество вершин";
            // 
            // graphPictureBox
            // 
            this.graphPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.graphPictureBox.Location = new System.Drawing.Point(353, 13);
            this.graphPictureBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.graphPictureBox.Name = "graphPictureBox";
            this.graphPictureBox.Size = new System.Drawing.Size(401, 315);
            this.graphPictureBox.TabIndex = 13;
            this.graphPictureBox.TabStop = false;
            // 
            // randomWeightsButton
            // 
            this.randomWeightsButton.Location = new System.Drawing.Point(-6, 351);
            this.randomWeightsButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.randomWeightsButton.Name = "randomWeightsButton";
            this.randomWeightsButton.Size = new System.Drawing.Size(178, 19);
            this.randomWeightsButton.TabIndex = 14;
            this.randomWeightsButton.Text = "Сгенерировать случайные веса";
            this.randomWeightsButton.UseVisualStyleBackColor = true;
            this.randomWeightsButton.Click += new System.EventHandler(this.randomWeightsButton_Click);
            // 
            // matrixGridView
            // 
            this.matrixGridView.AllowUserToAddRows = false;
            this.matrixGridView.AllowUserToDeleteRows = false;
            this.matrixGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.matrixGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.matrixGridView.Location = new System.Drawing.Point(11, 11);
            this.matrixGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.matrixGridView.MultiSelect = false;
            this.matrixGridView.Name = "matrixGridView";
            this.matrixGridView.RowHeadersWidth = 51;
            this.matrixGridView.RowTemplate.Height = 29;
            this.matrixGridView.Size = new System.Drawing.Size(222, 162);
            this.matrixGridView.TabIndex = 16;
            this.matrixGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.matrixGridView_CellValueChanged);
            // 
            // isSimmetricCheckBox
            // 
            this.isSimmetricCheckBox.AutoSize = true;
            this.isSimmetricCheckBox.Location = new System.Drawing.Point(176, 353);
            this.isSimmetricCheckBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.isSimmetricCheckBox.Name = "isSimmetricCheckBox";
            this.isSimmetricCheckBox.Size = new System.Drawing.Size(147, 17);
            this.isSimmetricCheckBox.TabIndex = 17;
            this.isSimmetricCheckBox.Text = "Симметричная матрица";
            this.isSimmetricCheckBox.UseVisualStyleBackColor = true;
            this.isSimmetricCheckBox.CheckedChanged += new System.EventHandler(this.isSimmetricCheckBox_CheckedChanged);
            // 
            // maxRandomNumeric
            // 
            this.maxRandomNumeric.Location = new System.Drawing.Point(11, 414);
            this.maxRandomNumeric.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.maxRandomNumeric.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.maxRandomNumeric.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.maxRandomNumeric.Name = "maxRandomNumeric";
            this.maxRandomNumeric.Size = new System.Drawing.Size(62, 20);
            this.maxRandomNumeric.TabIndex = 18;
            this.maxRandomNumeric.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 386);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Максимальное значение веса";
            // 
            // animationGroupBox
            // 
            this.animationGroupBox.Controls.Add(this.label8);
            this.animationGroupBox.Controls.Add(this.speedAnimationNumeric);
            this.animationGroupBox.Controls.Add(this.iterationResultButton);
            this.animationGroupBox.Controls.Add(this.endedResultButton);
            this.animationGroupBox.Location = new System.Drawing.Point(832, 13);
            this.animationGroupBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.animationGroupBox.Name = "animationGroupBox";
            this.animationGroupBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.animationGroupBox.Size = new System.Drawing.Size(260, 98);
            this.animationGroupBox.TabIndex = 21;
            this.animationGroupBox.TabStop = false;
            this.animationGroupBox.Text = "Отображение результата";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(144, 51);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Скорость анимации";
            // 
            // speedAnimationNumeric
            // 
            this.speedAnimationNumeric.Location = new System.Drawing.Point(169, 66);
            this.speedAnimationNumeric.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.speedAnimationNumeric.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.speedAnimationNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.speedAnimationNumeric.Name = "speedAnimationNumeric";
            this.speedAnimationNumeric.Size = new System.Drawing.Size(58, 20);
            this.speedAnimationNumeric.TabIndex = 2;
            this.speedAnimationNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // iterationResultButton
            // 
            this.iterationResultButton.AutoSize = true;
            this.iterationResultButton.Location = new System.Drawing.Point(4, 24);
            this.iterationResultButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.iterationResultButton.Name = "iterationResultButton";
            this.iterationResultButton.Size = new System.Drawing.Size(89, 17);
            this.iterationResultButton.TabIndex = 1;
            this.iterationResultButton.TabStop = true;
            this.iterationResultButton.Text = "По итерации";
            this.iterationResultButton.UseVisualStyleBackColor = true;
            // 
            // endedResultButton
            // 
            this.endedResultButton.AutoSize = true;
            this.endedResultButton.Location = new System.Drawing.Point(0, 69);
            this.endedResultButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.endedResultButton.Name = "endedResultButton";
            this.endedResultButton.Size = new System.Drawing.Size(168, 17);
            this.endedResultButton.TabIndex = 0;
            this.endedResultButton.TabStop = true;
            this.endedResultButton.Text = "Только конечный результат";
            this.endedResultButton.UseVisualStyleBackColor = true;
            // 
            // evaporationRatioNumeric
            // 
            this.evaporationRatioNumeric.DecimalPlaces = 1;
            this.evaporationRatioNumeric.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.evaporationRatioNumeric.Location = new System.Drawing.Point(1039, 128);
            this.evaporationRatioNumeric.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.evaporationRatioNumeric.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.evaporationRatioNumeric.Name = "evaporationRatioNumeric";
            this.evaporationRatioNumeric.Size = new System.Drawing.Size(64, 20);
            this.evaporationRatioNumeric.TabIndex = 22;
            this.evaporationRatioNumeric.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1036, 113);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Коеффициент испарения";
            // 
            // qRatioNumeric
            // 
            this.qRatioNumeric.Location = new System.Drawing.Point(901, 165);
            this.qRatioNumeric.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.qRatioNumeric.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.qRatioNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.qRatioNumeric.Name = "qRatioNumeric";
            this.qRatioNumeric.Size = new System.Drawing.Size(64, 20);
            this.qRatioNumeric.TabIndex = 24;
            this.qRatioNumeric.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(898, 150);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "Коеффициент Q";
            // 
            // pheromonesGridView
            // 
            this.pheromonesGridView.AllowUserToAddRows = false;
            this.pheromonesGridView.AllowUserToDeleteRows = false;
            this.pheromonesGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.pheromonesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pheromonesGridView.Location = new System.Drawing.Point(11, 177);
            this.pheromonesGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pheromonesGridView.MultiSelect = false;
            this.pheromonesGridView.Name = "pheromonesGridView";
            this.pheromonesGridView.ReadOnly = true;
            this.pheromonesGridView.RowHeadersWidth = 51;
            this.pheromonesGridView.RowTemplate.Height = 29;
            this.pheromonesGridView.Size = new System.Drawing.Size(222, 162);
            this.pheromonesGridView.TabIndex = 26;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(474, 348);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(171, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "Кратчайший Гамильтонов цикл: ";
            // 
            // shortestPathLabel
            // 
            this.shortestPathLabel.AutoSize = true;
            this.shortestPathLabel.Location = new System.Drawing.Point(685, 348);
            this.shortestPathLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.shortestPathLabel.Name = "shortestPathLabel";
            this.shortestPathLabel.Size = new System.Drawing.Size(41, 13);
            this.shortestPathLabel.TabIndex = 28;
            this.shortestPathLabel.Text = "label12";
            // 
            // showPathButton
            // 
            this.showPathButton.Location = new System.Drawing.Point(373, 380);
            this.showPathButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.showPathButton.Name = "showPathButton";
            this.showPathButton.Size = new System.Drawing.Size(98, 19);
            this.showPathButton.TabIndex = 29;
            this.showPathButton.Text = "Посмотреть цикл";
            this.showPathButton.UseVisualStyleBackColor = true;
            this.showPathButton.Click += new System.EventHandler(this.showPathButton_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(509, 372);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(127, 13);
            this.label12.TabIndex = 30;
            this.label12.Text = "Суммарный вес цикла: ";
            // 
            // sumWeightLabel
            // 
            this.sumWeightLabel.AutoSize = true;
            this.sumWeightLabel.Location = new System.Drawing.Point(685, 372);
            this.sumWeightLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.sumWeightLabel.Name = "sumWeightLabel";
            this.sumWeightLabel.Size = new System.Drawing.Size(41, 13);
            this.sumWeightLabel.TabIndex = 31;
            this.sumWeightLabel.Text = "label13";
            // 
            // AntAlgorithmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 513);
            this.Controls.Add(this.sumWeightLabel);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.showPathButton);
            this.Controls.Add(this.shortestPathLabel);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.pheromonesGridView);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.qRatioNumeric);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.evaporationRatioNumeric);
            this.Controls.Add(this.animationGroupBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.maxRandomNumeric);
            this.Controls.Add(this.isSimmetricCheckBox);
            this.Controls.Add(this.matrixGridView);
            this.Controls.Add(this.randomWeightsButton);
            this.Controls.Add(this.graphPictureBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.countVertex);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.betaNumeric);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.alphaNumeric);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.countAntsNumeric);
            this.Controls.Add(this.countIterationsNumeric);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AntAlgorithmForm";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AntAlgorithmForm_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.countIterationsNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countAntsNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alphaNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.betaNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countVertex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graphPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrixGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxRandomNumeric)).EndInit();
            this.animationGroupBox.ResumeLayout(false);
            this.animationGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.speedAnimationNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.evaporationRatioNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qRatioNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pheromonesGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NumericUpDown countIterationsNumeric;
        private NumericUpDown countAntsNumeric;
        private Label label1;
        private Label label2;
        private Button startButton;
        private NumericUpDown alphaNumeric;
        private Label label3;
        private NumericUpDown betaNumeric;
        private Label label4;
        private NumericUpDown countVertex;
        private Label label6;
        private PictureBox graphPictureBox;
        private Button randomWeightsButton;
        private DataGridView matrixGridView;
        private CheckBox isSimmetricCheckBox;
        private NumericUpDown maxRandomNumeric;
        private Label label5;
        private GroupBox animationGroupBox;
        private Label label8;
        private NumericUpDown speedAnimationNumeric;
        private RadioButton iterationResultButton;
        private RadioButton endedResultButton;
        private NumericUpDown evaporationRatioNumeric;
        private Label label9;
        private NumericUpDown qRatioNumeric;
        private Label label10;
        private DataGridView pheromonesGridView;
        private Label label11;
        private Label shortestPathLabel;
        private Button showPathButton;
        private Label label12;
        private Label sumWeightLabel;
    }
}