using Decorator.Interface;
using UnityEngine;

namespace Decorator.Drink
{
    public class HouseBlend : IBeverage
    {
        public string Description { get; set; } = "HouseBlend";

        public string GetDescription()
        {
            return $"{Description}(${Cost()})";
        }

        public double Cost()
        {
            return 1.0;
        }
    }
}