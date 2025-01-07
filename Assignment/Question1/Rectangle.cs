using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Question1
{
    internal class Rectangle : IRectangle
    {
        private double width;
        private double height;

        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public double Area
        {
            get { return width * height; }
        }

        double IShape.Area { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void DisplayShapeInfe()
        {
            throw new NotImplementedException();
        }

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Shape: Rectangle, Area: {Area:F2}");
        }
    }
}
