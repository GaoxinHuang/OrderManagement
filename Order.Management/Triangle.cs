using System;
using System.Collections.Generic;
using System.Text;

namespace Order.Management
{
    class Triangle : Shape
    {
        private readonly int _trianglePrice = 2;
        public Triangle(int numberOfRedTriangles, int numberOfBlueTriangles, int numberOfYellowTriangles):base(numberOfRedTriangles, numberOfBlueTriangles, numberOfYellowTriangles)
        {
            Name = "Triangle";
            base.Price = _trianglePrice;
        }
    }
}
