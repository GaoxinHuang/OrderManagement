using System;
using System.Collections.Generic;
using System.Text;

namespace Order.Management
{
    class InvoiceReport : Order
    {
        private readonly int _redShapeIndex = 1;
        protected override int TableWidth => 73;
        public InvoiceReport(string customerName, string customerAddress, string dueDate, List<Shape> shapes) : base(customerName, customerAddress, dueDate, shapes)
        {
        }

        public override void GenerateReport()
        {
            Console.WriteLine("\nYour invoice report has been generated: ");
            Console.WriteLine(base.ToString());
            GenerateTable();
            Console.WriteLine("\n");
            OrderShapesDetails();
            RedPaintSurcharge();
        }

        private void RedPaintSurcharge()
        {
            Console.WriteLine("Red Color Surcharge       " + TotalAmountOfRedShapes() + " @ $" + base.OrderedBlocks[_redShapeIndex].AdditionalCharge + " ppi = $" + TotalPriceRedPaintSurcharge());
        }

        private int TotalAmountOfRedShapes()
        {
            // should not hardcode
            int result = 0;
            for (int i = 0; i < OrderedBlocks.Count; i++)
            {
                result += OrderedBlocks[i].NumberOfRedShape;
            }
            return result;
        }

        private int TotalPriceRedPaintSurcharge()
        {
            return TotalAmountOfRedShapes() * base.OrderedBlocks[_redShapeIndex].AdditionalCharge;
        }

        private void OrderShapesDetails()
        {
            for (int i = 0; i < OrderedBlocks.Count; i++)
            {
                PrintFormattedOrderDtail(OrderedBlocks[i]);
            }
        }

        private void PrintFormattedOrderDtail(Shape shape)
        {
            // In order to format the invoice in same align like report, use string.format to format it
            // ref: https://stackoverflow.com/questions/4579506/how-to-do-alignment-within-string-format-in-c
            Console.WriteLine(string.Format("{0, -26}{1} @ ${2} ppi = ${3}", shape.Name, shape.TotalQuantityOfShape(), shape.Price, shape.Total()));
        }
    }
}
