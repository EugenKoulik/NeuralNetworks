using System.Drawing;

namespace NeuralNetworks.Common.Utils;

public static class Converter
{
   /// <summary>
   /// Convert matrix to vector (-1 if white color, 1 if another)
   /// </summary>
   /// <param name="image">Input image</param>
   /// <returns>Matrix of pixels</returns>
   public static Matrix ImageToVector(Image image)
   {
      var bitmap = new Bitmap(image);
      var imageMatrix = new Matrix(1, bitmap.Width * bitmap.Height);
      var current = 0;
      
      for (var i = 0; i < bitmap.Height; i++)
      {
         for (var j = 0; j < bitmap.Width; j++)
         {
            var color = bitmap.GetPixel(j, i);
            
            imageMatrix[0, current++] = color is { R: 255, G: 255, B: 255 } ? 1 : -1;
         }
      }

      return imageMatrix;
   }
}