using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Question1
{
    internal class Circle : ICircle
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public double Area
        {
            get { return Math.PI * radius * radius; }
        }

        double IShape.Area { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void DisplayShapeInfe()
        {
            throw new NotImplementedException();
        }

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Shape: Circle, Area: {Area:F2}");
        }
    }
}
