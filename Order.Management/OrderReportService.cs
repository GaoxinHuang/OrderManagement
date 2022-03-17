using Order.Management.Interfaces;
using Order.Management.Models;
using System;
using System.Collections.Generic;

namespace Order.Management
{
    class OrderReportService
    {
        private readonly IUserInputService _userInputService;
        public OrderReportService(IUserInputService userInputService)
        {
            _userInputService = userInputService;
        }

        private void GenerateOrderReport<T>(string customerName, string address, string dueDate, IList<Shape> orderedShapes) where T : Order
        {
            Order order = (T)Activator.CreateInstance(typeof(T), customerName, address, dueDate, orderedShapes);
            order.GenerateReport();
        }

        public void PrintOrderReports()
        {
            UserOrderDetail userOrderDetail = _userInputService.CustomerInfoInput();

            var orderedShapes = _userInputService.CustomerOrderInput();

            // Generate Invoice Report 
            GenerateOrderReport<InvoiceReport>(userOrderDetail.CustomerName,  userOrderDetail.Address, userOrderDetail.DueDate, orderedShapes);

            // Generate Cutting List Report 
            GenerateOrderReport<CuttingListReport>(userOrderDetail.CustomerName, userOrderDetail.Address, userOrderDetail.DueDate, orderedShapes);

            // Generate Painting Report 
            GenerateOrderReport<PaintingReport>(userOrderDetail.CustomerName, userOrderDetail.Address, userOrderDetail.DueDate, orderedShapes);
        }
    }
}
