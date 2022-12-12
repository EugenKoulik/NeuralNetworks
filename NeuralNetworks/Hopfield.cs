using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using NeuralNetworks.Common.DrawStaff;
using NeuralNetworks.Controllers;

namespace NeuralNetworks;

public partial class Hopfield : Form
{
    private readonly Form _parentForm;
    private HopfieldNnController _controller;
    private Graphics _gridGraphics;
    private Bitmap _gridBitmap;
    private bool[,] _gridArray;

    private List<bool[,]> _patterns;
    private ImageList _images;
    private int AcceptableSamples => (int)Math.Floor(columnScroll.Value * rowScroll.Value * 0.14m);
    private readonly Color _cellColor = Color.DarkRed;

    public Hopfield(Form parentForm)
    {
        InitializeComponent();
        _parentForm = parentForm;
    }
    
    private void Hopfield_Load(object sender, EventArgs e)
        {
            _gridBitmap = new Bitmap(gridPictureBox.Width, gridPictureBox.Height);

            _gridGraphics = Graphics.FromImage(_gridBitmap);

            _patterns = new List<bool[,]>();
            
            CreateGrid(rowScroll.Value, columnScroll.Value);
            
            gridPictureBox.Image = _gridBitmap;

            acceptableSamplesLabel.Text = AcceptableSamples.ToString();
            
            _images = new ImageList();
            _images.ImageSize = new Size(100, 100);
            _images.Images.Add(Image.FromHbitmap(_gridBitmap.GetHbitmap()));
        }
        
        // Change number of columns
        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            _patterns.Clear();
            _images.Images.Clear();
            acceptableSamplesLabel.Text = AcceptableSamples.ToString();
            
            CreateGrid(rowScroll.Value, columnScroll.Value);
            
            gridPictureBox.Image = _gridBitmap;

            _images.Images.Clear();
            imageList.Clear();
            _images.Images.Add(Image.FromHbitmap(_gridBitmap.GetHbitmap()));
        }

        // Change number of rows
        private void rowScroll_Scroll(object sender, ScrollEventArgs e)
        {
            _patterns.Clear();
            _images.Images.Clear();
            acceptableSamplesLabel.Text = AcceptableSamples.ToString();
            
            CreateGrid(rowScroll.Value, columnScroll.Value);

            gridPictureBox.Image = _gridBitmap;

            _images.Images.Clear();
            imageList.Clear();
            _images.Images.Add(Image.FromHbitmap(_gridBitmap.GetHbitmap()));
        }
        
        // Draw pattern
        private void gridPictureBox_Click(object sender, EventArgs e)
        {
            var click = (MouseEventArgs)e;
            
            Draw.DrawCell(_gridGraphics, _gridBitmap, _gridArray, click.Location, _cellColor, BackColor);
            Draw.DrawGrid(_gridGraphics, _gridBitmap, rowScroll.Value, columnScroll.Value);

            gridPictureBox.Image = _gridBitmap;
        }

        // Add pattern
        private void button1_Click(object sender, EventArgs e)
        {
            if (_patterns.Count == AcceptableSamples)
            {
                MessageBox.Show("");
                return;
            } 
            var pattern = new bool[rowScroll.Value, columnScroll.Value];
            
            Array.Copy(_gridArray, pattern, pattern.Length);
            
            _patterns.Add(pattern);
            
            _images.Images.Add(gridPictureBox.Image);
            imageList.Items.Add(new ListViewItem("Pattern", _patterns.Count));
            imageList.LargeImageList = _images;
        }

        // Search pattern
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                _gridArray = _controller.Find(_gridArray, _patterns);
                PaintFigure();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CreateGrid(int row, int column)
        {
            _controller = new HopfieldNnController(row * column);
            _gridArray = new bool[row, column];
            _gridGraphics.Clear(BackColor);
            Draw.DrawGrid(_gridGraphics, _gridBitmap, row, column);
        }

        private void PaintFigure()
        {
            Draw.PaintFigure(_gridGraphics, _gridBitmap, _gridArray, rowScroll.Value, columnScroll.Value, _cellColor, BackColor);
            Draw.DrawGrid(_gridGraphics, _gridBitmap, rowScroll.Value, columnScroll.Value);
            
            gridPictureBox.Image = _gridBitmap;
        }
        
        // Clear patterns
        private void button4_Click(object sender, EventArgs e)
        {
            _patterns.Clear();
            _images.Images.Clear();
            imageList.Clear();
            
            CreateGrid(rowScroll.Value, columnScroll.Value);
            
            gridPictureBox.Image = _gridBitmap;

            _images.Images.Add(Image.FromHbitmap(_gridBitmap.GetHbitmap()));
        }

        private void Hopfield_FormClosed(object sender, FormClosedEventArgs e)
        {
            _parentForm.Show();
        }
}