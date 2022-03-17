using System;
using System.Collections.Generic;
using System.Text;

namespace Order.Management
{
    class PaintingReport : Order
    {
        protected override int TableWidth => 73;
        public PaintingReport(string customerName, string customerAddress, string dueDate, List<Shape> shapes) : base(customerName, customerAddress, dueDate, shapes)
        {
        }
        public override void GenerateReport()
        {
            Console.WriteLine("\nYour painting report has been generated: ");
            Console.WriteLine(base.ToString());
            GenerateTable();
        }
    }
}
