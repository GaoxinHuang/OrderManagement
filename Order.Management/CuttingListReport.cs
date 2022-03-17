using System;
using System.Collections.Generic;
using System.Text;

namespace Order.Management
{
    class CuttingListReport : Order
    {
        protected override int TableWidth => 20;
        public CuttingListReport(string customerName, string customerAddress, string dueDate, List<Shape> shapes) : base(customerName, customerAddress, dueDate, shapes)
        {
        }

        public override void GenerateReport()
        {
            Console.WriteLine("\nYour cutting list has been generated: ");
            Console.WriteLine(base.ToString());
            GenerateTable();
        }
        public override void GenerateTable()
        {
            PrintLine();
            PrintRow("        ", "   Qty   ");
            PrintLine();
            PrintTotalQuantityRows();
            PrintLine();
        }

        // Not hardcode 
        private void PrintTotalQuantityRows()
        {
            for (int i = 0; i < OrderedBlocks.Count; i++)
            {
                PrintRow(OrderedBlocks[i].Name,
                    OrderedBlocks[i].TotalQuantityOfShape().ToString());
            }
        }
    }
}
