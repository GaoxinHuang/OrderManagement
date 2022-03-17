using System;
using System.Collections.Generic;
using System.Text;

namespace Order.Management.Models
{
    public class UserOrderDetail
    {
        public string CustomerName { get; set; }
        public string Address { get; set; }
        public string DueDate { get; set; }

        public UserOrderDetail(string cusomterName, string address, string dueDate)
        {
            CustomerName = cusomterName;
            Address = address;
            DueDate = dueDate;

        }
    }
}
