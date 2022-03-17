using Order.Management.Models;
using System.Collections.Generic;

namespace Order.Management.Interfaces
{
    interface IUserInputService
    {
        UserOrderDetail CustomerInfoInput();
        IList<Shape> CustomerOrderInput();
    }
}