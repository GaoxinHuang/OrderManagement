using System;
using System.Collections.Generic;
using System.Text;

namespace Order.Management
{
    abstract class Order
    {
        protected abstract int TableWidth { get; }
        private readonly string _customerName;
        private readonly string _address;
        private readonly string _dueDate;
        private readonly int _orderNumber;
        protected IList<Shape> OrderedBlocks { get; set; }

        public Order(string customerName, string customerAddress, string dueDate, IList<Shape> shapes)
        {
            _customerName = customerName;
            _address = customerAddress;
            _dueDate = dueDate;
            OrderedBlocks = shapes;
        }

        public abstract void GenerateReport();


        public virtual void GenerateTable()
        {
            PrintLine();
            PrintRow("        ", "   Red   ", "  Blue  ", " Yellow ");
            PrintLine();
            PrintShapeRows();
            PrintLine();
        }

        /// <summary>
        /// Not hard code
        /// </summary>
        private void PrintShapeRows()
        {
            for (int i = 0; i < OrderedBlocks.Count; i++)
            {
                PrintRow(OrderedBlocks[i].Name,
                    OrderedBlocks[i].NumberOfRedShape.ToString(),
                    OrderedBlocks[i].NumberOfBlueShape.ToString(),
                    OrderedBlocks[i].NumberOfYellowShape.ToString());
            }
        }

        public void PrintLine()
        {
            Console.WriteLine(new string('-', TableWidth));
        }

        public void PrintRow(params string[] columns)
        {
            int width = (TableWidth - columns.Length) / columns.Length;
            string row = "|";

            foreach (string column in columns)
            {
                row += AlignCentre(column, width) + "|";
            }

            Console.WriteLine(row);
        }

        public string AlignCentre(string text, int width)
        {
            text = text.Length > width ? text.Substring(0, width - 3) + "..." : text;

            if (string.IsNullOrEmpty(text))
            {
                return new string(' ', width);
            }
            else
            {
                return text.PadRight(width - (width - text.Length) / 2).PadLeft(width);
            }
        }

        public override string ToString()
        {
            return "\nName: " + _customerName + " Address: " + _address + " Due Date: " + _dueDate + " Order #: " + _orderNumber;
        }
    }
}
