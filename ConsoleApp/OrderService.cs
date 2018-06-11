using System;

namespace ConsoleApp
{
    public class OrderService
    {
        public double CalculatePrice()
        {
            var price = 2000.0;
            var discountPrice = price - 100.0;
            
            Console.WriteLine("Happy New Year!!");

            return discountPrice;
        }
    }
}