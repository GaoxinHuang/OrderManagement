using System;
using System.Collections.Generic;
using System.Text;

namespace Order.Management
{
    class Circle : Shape
    {
        private readonly int _circlePrice = 3;
        public Circle(int red, int blue, int yellow) : base(red, blue, yellow)
        {
            Name = "Circle";
            base.Price = _circlePrice;
        }
    }
}
