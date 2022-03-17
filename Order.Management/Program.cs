using Order.Management.Interfaces;
using System;
using System.Collections.Generic;

namespace Order.Management
{
    class Program
    {
        // Main entry
        static void Main(string[] args)
        {
            IUserInputService userInputService = new UserInputService();
            OrderReportService service = new OrderReportService(userInputService);
            service.PrintOrderReports();
        }
    }
}
