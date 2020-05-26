using System;
using Decorator.Interface;

namespace Decorator.Drink
{
    public class Espresso : IBeverage
    {
        public string Description { get; set; } = "Espresso";
        
        public string GetDescription()
        {
            return $"{Description}(${Cost()})";
        }

        public double Cost()
        {
            return 0.9;
        }
    }
}