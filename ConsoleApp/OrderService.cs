using System;

namespace ConsoleApp
{
    public class OrderService
    {
        public double CalculatePrice(Action action)
        {
            var price = 2000.0;
            var discountPrice = price - 100.0;

            action.Invoke();

            return discountPrice;
        }
    }
}