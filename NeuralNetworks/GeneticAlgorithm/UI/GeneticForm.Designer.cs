using System.Windows.Forms;

namespace NeuralNetworks.GeneticAlgorithm.UI
{
    partial class GeneticForm
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
            this.functionsListBox = new System.Windows.Forms.ListBox();
            this.functionsLabel = new System.Windows.Forms.Label();
            this.customFunctionTextBox = new System.Windows.Forms.TextBox();
            this.countStartedPopulationNumeric = new System.Windows.Forms.NumericUpDown();
            this.countGenerationNumeric = new System.Windows.Forms.NumericUpDown();
            this.calculateButton = new System.Windows.Forms.Button();
            this.crossingGroupBox = new System.Windows.Forms.GroupBox();
            this.linearCrossing = new System.Windows.Forms.RadioButton();
            this.geometryCrossing = new System.Windows.Forms.RadioButton();
            this.arithmeticCrossing = new System.Windows.Forms.RadioButton();
            this.simplestCrossing = new System.Windows.Forms.RadioButton();
            this.countPointsLabel = new System.Windows.Forms.Label();
            this.countPointsNumeric = new System.Windows.Forms.NumericUpDown();
            this.binaryPointCrossing = new System.Windows.Forms.RadioButton();
            this.flatCrossing = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mutationGroupBox = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.probabilityNumeric = new System.Windows.Forms.NumericUpDown();
            this.binaryRandomMutation = new System.Windows.Forms.RadioButton();
            this.realRandomMutation = new System.Windows.Forms.RadioButton();
            this.selectionGroupBox = new System.Windows.Forms.GroupBox();
            this.outbreedingSelection = new System.Windows.Forms.RadioButton();
            this.inbreedingSelection = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.numberSurvivedNumeric = new System.Windows.Forms.NumericUpDown();
            this.tournamentSelection = new System.Windows.Forms.RadioButton();
            this.panmixiaSelection = new System.Windows.Forms.RadioButton();
            this.rankSelection = new System.Windows.Forms.RadioButton();
            this.simpleSelection = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.countStartedPopulationNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countGenerationNumeric)).BeginInit();
            this.crossingGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.countPointsNumeric)).BeginInit();
            this.mutationGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.probabilityNumeric)).BeginInit();
            this.selectionGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberSurvivedNumeric)).BeginInit();
            this.SuspendLayout();
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
            this.functionsListBox.Location = new System.Drawing.Point(386, 57);
            this.functionsListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.functionsListBox.Name = "functionsListBox";
            this.functionsListBox.Size = new System.Drawing.Size(297, 173);
            this.functionsListBox.TabIndex = 0;
            this.functionsListBox.SelectedIndexChanged += new System.EventHandler(this.functionsListBox_SelectedIndexChanged);
            // 
            // functionsLabel
            // 
            this.functionsLabel.AutoSize = true;
            this.functionsLabel.Location = new System.Drawing.Point(495, 24);
            this.functionsLabel.Name = "functionsLabel";
            this.functionsLabel.Size = new System.Drawing.Size(139, 13);
            this.functionsLabel.TabIndex = 1;
            this.functionsLabel.Text = "Математические функции";
            // 
            // customFunctionTextBox
            // 
            this.customFunctionTextBox.Location = new System.Drawing.Point(386, 243);
            this.customFunctionTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.customFunctionTextBox.Name = "customFunctionTextBox";
            this.customFunctionTextBox.Size = new System.Drawing.Size(297, 20);
            this.customFunctionTextBox.TabIndex = 2;
            this.customFunctionTextBox.Text = "f(x1, x2) = ";
            // 
            // countStartedPopulationNumeric
            // 
            this.countStartedPopulationNumeric.Location = new System.Drawing.Point(483, 319);
            this.countStartedPopulationNumeric.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.countStartedPopulationNumeric.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.countStartedPopulationNumeric.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.countStartedPopulationNumeric.Name = "countStartedPopulationNumeric";
            this.countStartedPopulationNumeric.Size = new System.Drawing.Size(112, 20);
            this.countStartedPopulationNumeric.TabIndex = 3;
            this.countStartedPopulationNumeric.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // countGenerationNumeric
            // 
            this.countGenerationNumeric.Location = new System.Drawing.Point(483, 276);
            this.countGenerationNumeric.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.countGenerationNumeric.Maximum = new decimal(new int[] {
            200000,
            0,
            0,
            0});
            this.countGenerationNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.countGenerationNumeric.Name = "countGenerationNumeric";
            this.countGenerationNumeric.Size = new System.Drawing.Size(112, 20);
            this.countGenerationNumeric.TabIndex = 4;
            this.countGenerationNumeric.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(612, 296);
            this.calculateButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(70, 19);
            this.calculateButton.TabIndex = 5;
            this.calculateButton.Text = "Вычислить";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // crossingGroupBox
            // 
            this.crossingGroupBox.Controls.Add(this.linearCrossing);
            this.crossingGroupBox.Controls.Add(this.geometryCrossing);
            this.crossingGroupBox.Controls.Add(this.arithmeticCrossing);
            this.crossingGroupBox.Controls.Add(this.simplestCrossing);
            this.crossingGroupBox.Controls.Add(this.countPointsLabel);
            this.crossingGroupBox.Controls.Add(this.countPointsNumeric);
            this.crossingGroupBox.Controls.Add(this.binaryPointCrossing);
            this.crossingGroupBox.Controls.Add(this.flatCrossing);
            this.crossingGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.crossingGroupBox.Location = new System.Drawing.Point(10, 48);
            this.crossingGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.crossingGroupBox.Name = "crossingGroupBox";
            this.crossingGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.crossingGroupBox.Size = new System.Drawing.Size(321, 152);
            this.crossingGroupBox.TabIndex = 6;
            this.crossingGroupBox.TabStop = false;
            this.crossingGroupBox.Text = "Скрещивание";
            // 
            // linearCrossing
            // 
            this.linearCrossing.AutoSize = true;
            this.linearCrossing.Location = new System.Drawing.Point(15, 127);
            this.linearCrossing.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.linearCrossing.Name = "linearCrossing";
            this.linearCrossing.Size = new System.Drawing.Size(151, 17);
            this.linearCrossing.TabIndex = 7;
            this.linearCrossing.TabStop = true;
            this.linearCrossing.Text = "Вещественное линейное";
            this.linearCrossing.UseVisualStyleBackColor = true;
            this.linearCrossing.CheckedChanged += new System.EventHandler(this.linearCrossing_CheckedChanged);
            // 
            // geometryCrossing
            // 
            this.geometryCrossing.AutoSize = true;
            this.geometryCrossing.Location = new System.Drawing.Point(15, 107);
            this.geometryCrossing.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.geometryCrossing.Name = "geometryCrossing";
            this.geometryCrossing.Size = new System.Drawing.Size(186, 17);
            this.geometryCrossing.TabIndex = 6;
            this.geometryCrossing.TabStop = true;
            this.geometryCrossing.Text = "Вещественное геометрическое";
            this.geometryCrossing.UseVisualStyleBackColor = true;
            this.geometryCrossing.CheckedChanged += new System.EventHandler(this.geometryCrossing_CheckedChanged);
            // 
            // arithmeticCrossing
            // 
            this.arithmeticCrossing.AutoSize = true;
            this.arithmeticCrossing.Location = new System.Drawing.Point(15, 87);
            this.arithmeticCrossing.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.arithmeticCrossing.Name = "arithmeticCrossing";
            this.arithmeticCrossing.Size = new System.Drawing.Size(189, 17);
            this.arithmeticCrossing.TabIndex = 5;
            this.arithmeticCrossing.TabStop = true;
            this.arithmeticCrossing.Text = "Вещественное арифметическое";
            this.arithmeticCrossing.UseVisualStyleBackColor = true;
            this.arithmeticCrossing.CheckedChanged += new System.EventHandler(this.ArithmeticCrossing_CheckedChanged);
            // 
            // simplestCrossing
            // 
            this.simplestCrossing.AutoSize = true;
            this.simplestCrossing.Location = new System.Drawing.Point(15, 47);
            this.simplestCrossing.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.simplestCrossing.Name = "simplestCrossing";
            this.simplestCrossing.Size = new System.Drawing.Size(164, 17);
            this.simplestCrossing.TabIndex = 4;
            this.simplestCrossing.TabStop = true;
            this.simplestCrossing.Text = "Вещественное простейшее";
            this.simplestCrossing.UseVisualStyleBackColor = true;
            this.simplestCrossing.CheckedChanged += new System.EventHandler(this.simplestCrossing_CheckedChanged);
            // 
            // countPointsLabel
            // 
            this.countPointsLabel.AutoSize = true;
            this.countPointsLabel.Location = new System.Drawing.Point(191, 29);
            this.countPointsLabel.Name = "countPointsLabel";
            this.countPointsLabel.Size = new System.Drawing.Size(81, 13);
            this.countPointsLabel.TabIndex = 3;
            this.countPointsLabel.Text = "Сколько точек";
            // 
            // countPointsNumeric
            // 
            this.countPointsNumeric.Location = new System.Drawing.Point(191, 49);
            this.countPointsNumeric.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.countPointsNumeric.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.countPointsNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.countPointsNumeric.Name = "countPointsNumeric";
            this.countPointsNumeric.Size = new System.Drawing.Size(112, 20);
            this.countPointsNumeric.TabIndex = 2;
            this.countPointsNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // binaryPointCrossing
            // 
            this.binaryPointCrossing.AutoSize = true;
            this.binaryPointCrossing.Location = new System.Drawing.Point(15, 27);
            this.binaryPointCrossing.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.binaryPointCrossing.Name = "binaryPointCrossing";
            this.binaryPointCrossing.Size = new System.Drawing.Size(153, 17);
            this.binaryPointCrossing.TabIndex = 1;
            this.binaryPointCrossing.TabStop = true;
            this.binaryPointCrossing.Text = "Бинарное многоточечное";
            this.binaryPointCrossing.UseVisualStyleBackColor = true;
            this.binaryPointCrossing.CheckedChanged += new System.EventHandler(this.binaryPointCrossing_CheckedChanged);
            // 
            // flatCrossing
            // 
            this.flatCrossing.AutoSize = true;
            this.flatCrossing.Location = new System.Drawing.Point(15, 68);
            this.flatCrossing.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flatCrossing.Name = "flatCrossing";
            this.flatCrossing.Size = new System.Drawing.Size(145, 17);
            this.flatCrossing.TabIndex = 0;
            this.flatCrossing.TabStop = true;
            this.flatCrossing.Text = "Вещественное плоское";
            this.flatCrossing.UseVisualStyleBackColor = true;
            this.flatCrossing.CheckedChanged += new System.EventHandler(this.flatCrossing_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(355, 315);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Начальная популяция";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(362, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Сколько поколений";
            // 
            // mutationGroupBox
            // 
            this.mutationGroupBox.Controls.Add(this.label3);
            this.mutationGroupBox.Controls.Add(this.probabilityNumeric);
            this.mutationGroupBox.Controls.Add(this.binaryRandomMutation);
            this.mutationGroupBox.Controls.Add(this.realRandomMutation);
            this.mutationGroupBox.Location = new System.Drawing.Point(362, 348);
            this.mutationGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mutationGroupBox.Name = "mutationGroupBox";
            this.mutationGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mutationGroupBox.Size = new System.Drawing.Size(321, 81);
            this.mutationGroupBox.TabIndex = 9;
            this.mutationGroupBox.TabStop = false;
            this.mutationGroupBox.Text = "Мутация";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(191, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Вероятность мутации";
            // 
            // probabilityNumeric
            // 
            this.probabilityNumeric.Location = new System.Drawing.Point(191, 43);
            this.probabilityNumeric.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.probabilityNumeric.Name = "probabilityNumeric";
            this.probabilityNumeric.Size = new System.Drawing.Size(112, 20);
            this.probabilityNumeric.TabIndex = 2;
            this.probabilityNumeric.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // binaryRandomMutation
            // 
            this.binaryRandomMutation.AutoSize = true;
            this.binaryRandomMutation.Location = new System.Drawing.Point(5, 23);
            this.binaryRandomMutation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.binaryRandomMutation.Name = "binaryRandomMutation";
            this.binaryRandomMutation.Size = new System.Drawing.Size(129, 17);
            this.binaryRandomMutation.TabIndex = 1;
            this.binaryRandomMutation.TabStop = true;
            this.binaryRandomMutation.Text = "Бинарная случайная";
            this.binaryRandomMutation.UseVisualStyleBackColor = true;
            this.binaryRandomMutation.CheckedChanged += new System.EventHandler(this.binaryRandomMutation_CheckedChanged);
            // 
            // realRandomMutation
            // 
            this.realRandomMutation.AutoSize = true;
            this.realRandomMutation.Location = new System.Drawing.Point(5, 47);
            this.realRandomMutation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.realRandomMutation.Name = "realRandomMutation";
            this.realRandomMutation.Size = new System.Drawing.Size(155, 17);
            this.realRandomMutation.TabIndex = 0;
            this.realRandomMutation.TabStop = true;
            this.realRandomMutation.Text = "Вещественная случайная";
            this.realRandomMutation.UseVisualStyleBackColor = true;
            this.realRandomMutation.CheckedChanged += new System.EventHandler(this.realRandomMutation_CheckedChanged);
            // 
            // selectionGroupBox
            // 
            this.selectionGroupBox.Controls.Add(this.outbreedingSelection);
            this.selectionGroupBox.Controls.Add(this.inbreedingSelection);
            this.selectionGroupBox.Controls.Add(this.label4);
            this.selectionGroupBox.Controls.Add(this.numberSurvivedNumeric);
            this.selectionGroupBox.Controls.Add(this.tournamentSelection);
            this.selectionGroupBox.Controls.Add(this.panmixiaSelection);
            this.selectionGroupBox.Controls.Add(this.rankSelection);
            this.selectionGroupBox.Controls.Add(this.simpleSelection);
            this.selectionGroupBox.Location = new System.Drawing.Point(10, 239);
            this.selectionGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.selectionGroupBox.Name = "selectionGroupBox";
            this.selectionGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.selectionGroupBox.Size = new System.Drawing.Size(321, 147);
            this.selectionGroupBox.TabIndex = 10;
            this.selectionGroupBox.TabStop = false;
            this.selectionGroupBox.Text = "Отбор";
            // 
            // outbreedingSelection
            // 
            this.outbreedingSelection.AutoSize = true;
            this.outbreedingSelection.Location = new System.Drawing.Point(15, 122);
            this.outbreedingSelection.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.outbreedingSelection.Name = "outbreedingSelection";
            this.outbreedingSelection.Size = new System.Drawing.Size(83, 17);
            this.outbreedingSelection.TabIndex = 7;
            this.outbreedingSelection.TabStop = true;
            this.outbreedingSelection.Text = "Аутбридинг";
            this.outbreedingSelection.UseVisualStyleBackColor = true;
            this.outbreedingSelection.CheckedChanged += new System.EventHandler(this.outbreedingSelection_CheckedChanged);
            // 
            // inbreedingSelection
            // 
            this.inbreedingSelection.AutoSize = true;
            this.inbreedingSelection.Location = new System.Drawing.Point(15, 102);
            this.inbreedingSelection.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.inbreedingSelection.Name = "inbreedingSelection";
            this.inbreedingSelection.Size = new System.Drawing.Size(80, 17);
            this.inbreedingSelection.TabIndex = 6;
            this.inbreedingSelection.TabStop = true;
            this.inbreedingSelection.Text = "Инбридинг";
            this.inbreedingSelection.UseVisualStyleBackColor = true;
            this.inbreedingSelection.CheckedChanged += new System.EventHandler(this.inbreedingSelection_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(191, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Сколько выживших";
            // 
            // numberSurvivedNumeric
            // 
            this.numberSurvivedNumeric.Location = new System.Drawing.Point(191, 44);
            this.numberSurvivedNumeric.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numberSurvivedNumeric.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numberSurvivedNumeric.Name = "numberSurvivedNumeric";
            this.numberSurvivedNumeric.Size = new System.Drawing.Size(112, 20);
            this.numberSurvivedNumeric.TabIndex = 4;
            this.numberSurvivedNumeric.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // tournamentSelection
            // 
            this.tournamentSelection.AutoSize = true;
            this.tournamentSelection.Location = new System.Drawing.Point(15, 83);
            this.tournamentSelection.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tournamentSelection.Name = "tournamentSelection";
            this.tournamentSelection.Size = new System.Drawing.Size(113, 17);
            this.tournamentSelection.TabIndex = 3;
            this.tournamentSelection.TabStop = true;
            this.tournamentSelection.Text = "Турнирный отбор";
            this.tournamentSelection.UseVisualStyleBackColor = true;
            this.tournamentSelection.CheckedChanged += new System.EventHandler(this.tournamentSelection_CheckedChanged);
            // 
            // panmixiaSelection
            // 
            this.panmixiaSelection.AutoSize = true;
            this.panmixiaSelection.Location = new System.Drawing.Point(15, 64);
            this.panmixiaSelection.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panmixiaSelection.Name = "panmixiaSelection";
            this.panmixiaSelection.Size = new System.Drawing.Size(83, 17);
            this.panmixiaSelection.TabIndex = 2;
            this.panmixiaSelection.TabStop = true;
            this.panmixiaSelection.Text = "Панмиксия";
            this.panmixiaSelection.UseVisualStyleBackColor = true;
            this.panmixiaSelection.CheckedChanged += new System.EventHandler(this.panmixiaSelection_CheckedChanged);
            // 
            // rankSelection
            // 
            this.rankSelection.AutoSize = true;
            this.rankSelection.Location = new System.Drawing.Point(15, 24);
            this.rankSelection.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rankSelection.Name = "rankSelection";
            this.rankSelection.Size = new System.Drawing.Size(107, 17);
            this.rankSelection.TabIndex = 1;
            this.rankSelection.TabStop = true;
            this.rankSelection.Text = "Ранговый отбор";
            this.rankSelection.UseVisualStyleBackColor = true;
            this.rankSelection.CheckedChanged += new System.EventHandler(this.rankSelection_CheckedChanged);
            // 
            // simpleSelection
            // 
            this.simpleSelection.AutoSize = true;
            this.simpleSelection.Location = new System.Drawing.Point(15, 44);
            this.simpleSelection.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.simpleSelection.Name = "simpleSelection";
            this.simpleSelection.Size = new System.Drawing.Size(100, 17);
            this.simpleSelection.TabIndex = 0;
            this.simpleSelection.TabStop = true;
            this.simpleSelection.Text = "Простой отбор";
            this.simpleSelection.UseVisualStyleBackColor = true;
            this.simpleSelection.CheckedChanged += new System.EventHandler(this.simpleSelection_CheckedChanged);
            // 
            // GeneticForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 451);
            this.Controls.Add(this.selectionGroupBox);
            this.Controls.Add(this.mutationGroupBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.crossingGroupBox);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.countGenerationNumeric);
            this.Controls.Add(this.countStartedPopulationNumeric);
            this.Controls.Add(this.customFunctionTextBox);
            this.Controls.Add(this.functionsLabel);
            this.Controls.Add(this.functionsListBox);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "GeneticForm";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GeneticForm_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.countStartedPopulationNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countGenerationNumeric)).EndInit();
            this.crossingGroupBox.ResumeLayout(false);
            this.crossingGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.countPointsNumeric)).EndInit();
            this.mutationGroupBox.ResumeLayout(false);
            this.mutationGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.probabilityNumeric)).EndInit();
            this.selectionGroupBox.ResumeLayout(false);
            this.selectionGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberSurvivedNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox functionsListBox;
        private Label functionsLabel;
        private TextBox customFunctionTextBox;
        private NumericUpDown countStartedPopulationNumeric;
        private NumericUpDown countGenerationNumeric;
        private Button calculateButton;
        private GroupBox crossingGroupBox;
        private RadioButton binaryPointCrossing;
        private RadioButton flatCrossing;
        private Label countPointsLabel;
        private NumericUpDown countPointsNumeric;
        private Label label1;
        private Label label2;
        private GroupBox mutationGroupBox;
        private RadioButton binaryRandomMutation;
        private RadioButton realRandomMutation;
        private Label label3;
        private NumericUpDown probabilityNumeric;
        private GroupBox selectionGroupBox;
        private RadioButton tournamentSelection;
        private RadioButton panmixiaSelection;
        private RadioButton rankSelection;
        private RadioButton simpleSelection;
        private Label label4;
        private NumericUpDown numberSurvivedNumeric;
        private RadioButton outbreedingSelection;
        private RadioButton inbreedingSelection;
        private RadioButton linearCrossing;
        private RadioButton geometryCrossing;
        private RadioButton arithmeticCrossing;
        private RadioButton simplestCrossing;
    }
}