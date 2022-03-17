using System;
using System.Collections.Generic;
using System.Text;

namespace Order.Management
{
    class Square : Shape
    {
        private readonly int _squarePrice = 1;
        public Square(int numberOfRedSquares, int numberOfBlueSquares, int numberOfYellowSquares):base(numberOfRedSquares, numberOfBlueSquares, numberOfYellowSquares)
        {
            Name = "Square";
            base.Price = _squarePrice;
        }
    }
}
