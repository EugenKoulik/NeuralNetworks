using System.ComponentModel;

namespace NeuralNetworks;

partial class Hopfield
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
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
        this.button1 = new System.Windows.Forms.Button();
        this.button2 = new System.Windows.Forms.Button();
        this.dataGridBoolColumn1 = new System.Windows.Forms.DataGridBoolColumn();
        this.columnScroll = new System.Windows.Forms.VScrollBar();
        this.rowScroll = new System.Windows.Forms.HScrollBar();
        this.gridPictureBox = new System.Windows.Forms.PictureBox();
        this.imageList = new System.Windows.Forms.ListView();
        this.button4 = new System.Windows.Forms.Button();
        this.acceptableSamplesLabel = new System.Windows.Forms.Label();
        this.label1 = new System.Windows.Forms.Label();
        ((System.ComponentModel.ISupportInitialize)(this.gridPictureBox)).BeginInit();
        this.SuspendLayout();
        // 
        // button1
        // 
        this.button1.Location = new System.Drawing.Point(56, 405);
        this.button1.Margin = new System.Windows.Forms.Padding(2);
        this.button1.Name = "button1";
        this.button1.Size = new System.Drawing.Size(190, 30);
        this.button1.TabIndex = 0;
        this.button1.Text = "Add pattern";
        this.button1.UseVisualStyleBackColor = true;
        this.button1.Click += new System.EventHandler(this.button1_Click);
        // 
        // button2
        // 
        this.button2.Location = new System.Drawing.Point(250, 405);
        this.button2.Margin = new System.Windows.Forms.Padding(2);
        this.button2.Name = "button2";
        this.button2.Size = new System.Drawing.Size(190, 30);
        this.button2.TabIndex = 5;
        this.button2.Text = "Search";
        this.button2.UseVisualStyleBackColor = true;
        this.button2.Click += new System.EventHandler(this.button2_Click);
        // 
        // dataGridBoolColumn1
        // 
        this.dataGridBoolColumn1.Width = -1;
        // 
        // columnScroll
        // 
        this.columnScroll.LargeChange = 1;
        this.columnScroll.Location = new System.Drawing.Point(20, 47);
        this.columnScroll.Maximum = 20;
        this.columnScroll.Minimum = 2;
        this.columnScroll.Name = "columnScroll";
        this.columnScroll.Size = new System.Drawing.Size(21, 351);
        this.columnScroll.TabIndex = 20;
        this.columnScroll.Value = 2;
        this.columnScroll.Scroll += new System.Windows.Forms.ScrollEventHandler(this.rowScroll_Scroll);
        // 
        // rowScroll
        // 
        this.rowScroll.LargeChange = 1;
        this.rowScroll.Location = new System.Drawing.Point(39, 23);
        this.rowScroll.Maximum = 20;
        this.rowScroll.Minimum = 2;
        this.rowScroll.Name = "rowScroll";
        this.rowScroll.Size = new System.Drawing.Size(402, 21);
        this.rowScroll.TabIndex = 21;
        this.rowScroll.Value = 2;
        this.rowScroll.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
        // 
        // gridPictureBox
        // 
        this.gridPictureBox.Location = new System.Drawing.Point(56, 62);
        this.gridPictureBox.Margin = new System.Windows.Forms.Padding(2);
        this.gridPictureBox.Name = "gridPictureBox";
        this.gridPictureBox.Size = new System.Drawing.Size(385, 336);
        this.gridPictureBox.TabIndex = 23;
        this.gridPictureBox.TabStop = false;
        this.gridPictureBox.Click += new System.EventHandler(this.gridPictureBox_Click);
        // 
        // imageList
        // 
        this.imageList.Location = new System.Drawing.Point(455, 62);
        this.imageList.Name = "imageList";
        this.imageList.Size = new System.Drawing.Size(232, 337);
        this.imageList.TabIndex = 25;
        this.imageList.UseCompatibleStateImageBehavior = false;
        // 
        // button4
        // 
        this.button4.Location = new System.Drawing.Point(454, 405);
        this.button4.Name = "button4";
        this.button4.Size = new System.Drawing.Size(232, 30);
        this.button4.TabIndex = 26;
        this.button4.Text = "Clear patterns";
        this.button4.UseVisualStyleBackColor = true;
        this.button4.Click += new System.EventHandler(this.button4_Click);
        // 
        // acceptableSamplesLabel
        // 
        this.acceptableSamplesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        this.acceptableSamplesLabel.Location = new System.Drawing.Point(583, 27);
        this.acceptableSamplesLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
        this.acceptableSamplesLabel.Name = "acceptableSamplesLabel";
        this.acceptableSamplesLabel.Size = new System.Drawing.Size(104, 32);
        this.acceptableSamplesLabel.TabIndex = 27;
        this.acceptableSamplesLabel.Text = "label1";
        this.acceptableSamplesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // label1
        // 
        this.label1.Location = new System.Drawing.Point(482, 23);
        this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(123, 36);
        this.label1.TabIndex = 28;
        this.label1.Text = "Количество допустимых образцов";
        this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // Hopfield
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(704, 444);
        this.Controls.Add(this.label1);
        this.Controls.Add(this.acceptableSamplesLabel);
        this.Controls.Add(this.button4);
        this.Controls.Add(this.imageList);
        this.Controls.Add(this.gridPictureBox);
        this.Controls.Add(this.rowScroll);
        this.Controls.Add(this.columnScroll);
        this.Controls.Add(this.button2);
        this.Controls.Add(this.button1);
        this.Margin = new System.Windows.Forms.Padding(2);
        this.Name = "Hopfield";
        this.Text = "Hopfield";
        this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Hopfield_FormClosed);
        this.Load += new System.EventHandler(this.Hopfield_Load);
        ((System.ComponentModel.ISupportInitialize)(this.gridPictureBox)).EndInit();
        this.ResumeLayout(false);
    }

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Label acceptableSamplesLabel;

        private System.Windows.Forms.Button button4;

        private System.Windows.Forms.ListView imageList;

        private System.Windows.Forms.PictureBox gridPictureBox;

        private System.Windows.Forms.HScrollBar rowScroll;
        private System.Windows.Forms.VScrollBar columnScroll;

        private System.Windows.Forms.DataGridBoolColumn dataGridBoolColumn1;

        private System.Windows.Forms.Button button2;

        private System.Windows.Forms.Button button1;

        #endregion
}