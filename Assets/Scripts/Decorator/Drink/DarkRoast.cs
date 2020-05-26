using System.Collections;
using System.Collections.Generic;
using Decorator.Interface;
using UnityEngine;

namespace Decorator.Drink
{
    public class DarkRoast : IBeverage
    {
        public string Description { get; set; } = "DarkRoast";
        
        public string GetDescription()
        {
            return $"{Description}(${Cost()})";
        }

        public double Cost()
        {
            return 1.2;
        }
    }
}