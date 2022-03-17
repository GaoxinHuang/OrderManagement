using Order.Management.Interfaces;
using Order.Management.Models;
using System;
using System.Collections.Generic;

namespace Order.Management
{
    class UserInputService : IUserInputService
    {
        public UserOrderDetail CustomerInfoInput()
        {
            Console.Write("Please input your Name: ");
            string customerName = UserInput();
            Console.Write("Please input your Address: ");
            string address = UserInput();
            Console.Write("Please input your Due Date: ");
            string dueDate = UserInputDate();
            return new UserOrderDetail(customerName, address, dueDate);
        }

        // Get order input
        public IList<Shape> CustomerOrderInput()
        {
            Shape square = OrderShapeInput<Square>();
            Shape triangle = OrderShapeInput<Triangle>();
            Shape circle = OrderShapeInput<Circle>();
            var orderedShapes = new List<Shape>();
            orderedShapes.Add(square);
            orderedShapes.Add(triangle);
            orderedShapes.Add(circle);
            return orderedShapes;
        }

        // User Console Input
        private string UserInput()
        {
            string input = Console.ReadLine();
            while (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("please enter valid details");
                input = Console.ReadLine();
            }
            return input;
        }

        private int UserInputNumber()
        {
            int? userInput = null;

            while (userInput == null)
            {
                try
                {
                    userInput = Convert.ToInt32(UserInput());
                }
                catch (Exception)
                {

                    Console.WriteLine("please enter a valid number");
                }
            }
            return (int)userInput;
        }

        private string UserInputDate()
        {
            string userInput = UserInput();

            while (!DateTime.TryParse(userInput, out DateTime x))
            {
                Console.WriteLine("please enter a valid date");
                userInput = UserInput();
            }
            return userInput;
        }

        // Order Shape Input
        private Shape OrderShapeInput<T>() where T : Shape
        {
            var typeName = typeof(T).Name;
            Console.Write($"\nPlease input the number of Red {typeName}: ");
            int redSquare = UserInputNumber();
            Console.Write($"Please input the number of Blue {typeName}: ");
            int blueSquare = UserInputNumber();
            Console.Write($"Please input the number of Yellow {typeName}: ");
            int yellowSquare = UserInputNumber();
            // Because Constructor have parameter, should we use Activator.CreateInstance
            Shape square = (T)Activator.CreateInstance(typeof(T), redSquare, blueSquare, yellowSquare);
            return square;
        }
    }
}
