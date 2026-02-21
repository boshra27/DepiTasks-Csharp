using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp07
{
    internal class Rectangle: Shape, IShape
    {
        #region Problem: Rectangle implements IShape
        //public int Width { get; set; }
        //public int Height { get; set; }

        //public Rectangle(int width, int height)
        //{
        //    Width = width;
        //    Height = height;
        //}

        //public double Area => Width * Height;


        //public string Draw()
        //{
        //    return $"Drawing a rectangle with Area {Area}";
        //}
        #endregion



        #region Problem: Shape base class
        //public int Width { get; set; }
        //public int Height { get; set; }

        //public Rectangle(int width, int height)
        //{
        //    Width = width;
        //    Height = height;
        //}

        //public override void Draw()
        //{
        //    Console.WriteLine("Drawing a rectangle");
        //}

        //public override double CalculateArea()
        //{
        //    return Width * Height;
        //}
        #endregion
    }
}
