using System;
using System.Drawing;

namespace NeuralNetworks.Common.DrawStaff;

public static class Draw
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="graphics"></param>
    /// <param name="gridBitmap"></param>
    /// <param name="gridArr"></param>
    /// <param name="click"></param>
    /// <param name="cellColor"></param>
    /// <param name="backColor"></param>
    public static void DrawCell(Graphics graphics, Bitmap gridBitmap, bool[,] gridArr, Point click, Color cellColor, Color backColor)
    {
        var stepX = gridBitmap.Width / (float)gridArr.GetLength(1);
        var stepY = gridBitmap.Height / (float)gridArr.GetLength(0);

        var columnNumber = (int)Math.Floor(click.X / stepX);
        var rowNumber = (int)Math.Floor(click.Y / stepY);

        gridArr[rowNumber, columnNumber] = !gridArr[rowNumber, columnNumber];

        var p1 = new PointF(stepX * columnNumber, stepY * rowNumber);

        var colorFill = gridArr[rowNumber, columnNumber] ? cellColor : backColor;

        graphics.FillRectangle(new SolidBrush(colorFill)
            , new RectangleF(p1.X, p1.Y, stepX, stepY));
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="graphics"></param>
    /// <param name="gridBitmap"></param>
    /// <param name="row"></param>
    /// <param name="column"></param>
    public static void DrawGrid(Graphics graphics, Bitmap gridBitmap, int row, int column)
    {
        var stepX = (float)gridBitmap.Width / column;
        var stepY = (float)gridBitmap.Height / row;

        var p1 = new PointF(0, 0);
        var p2 = new PointF(0, gridBitmap.Height);

        for (var i = 0; i < column; i++)
        {
            p1.X += stepX;
            p2.X += stepX;

            graphics.DrawLine(new Pen(new SolidBrush(Color.Black)), p1, p2);
        }

        p1 = new PointF(0, 0);
        p2 = new PointF(gridBitmap.Width, 0);

        for (var i = 0; i < row; i++)
        {
            p1.Y += stepY;
            p2.Y += stepY;

            graphics.DrawLine(new Pen(new SolidBrush(Color.Black)), p1, p2);
        }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="graphics"></param>
    /// <param name="gridBitmap"></param>
    /// <param name="gridArr"></param>
    /// <param name="row"></param>
    /// <param name="column"></param>
    /// <param name="color"></param>
    /// <param name="backColor"></param>
    public static void PaintFigure(Graphics graphics, Bitmap gridBitmap, bool[,] gridArr, int row, int column, Color color, Color backColor)
    {
        var stepX = gridBitmap.Width / column;
        var stepY = gridBitmap.Height / row;

        for (var i = 0; i < row; i++)
        {
            for (var j = 0; j < column; j++)
            {
                var p1 = new PointF(stepX * j, stepY * i);

                var colorFill = gridArr[i, j] ? color : backColor;

                graphics.FillRectangle(new SolidBrush(colorFill)
                    , new RectangleF(p1.X, p1.Y, stepX, stepY));
            }
        }
    }
}