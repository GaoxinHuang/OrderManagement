using System;
using System.Collections.Generic;
using System.Text;

namespace Order.Management
{
    abstract class Shape
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public int AdditionalCharge { get; set; }

        public readonly int NumberOfRedShape;
        public readonly int NumberOfBlueShape;
        public readonly int NumberOfYellowShape;

        public Shape(int numberOfRedShape, int numberOfBlueShape, int numberOfYellowShape)
        {
            NumberOfRedShape = numberOfRedShape;
            NumberOfBlueShape = numberOfBlueShape;
            NumberOfYellowShape = numberOfYellowShape;
            AdditionalCharge = 1;
        }

        public int TotalQuantityOfShape()
        {
            return NumberOfRedShape + NumberOfBlueShape + NumberOfYellowShape;
        }

        private int RedTotal()
        {
            return (NumberOfRedShape * Price);
        }
        private int BlueTotal()
        {
            return (NumberOfBlueShape * Price);
        }
        private int YellowTotal()
        {
            return (NumberOfYellowShape * Price);
        }

        //public abstract int Total(); // If need, we could say public virtual int Total() to allow override in child class
        public int Total()
        {
            return RedTotal() + BlueTotal() + YellowTotal();
        }

    }
}
