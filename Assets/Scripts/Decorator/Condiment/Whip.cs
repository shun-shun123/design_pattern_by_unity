using System.Collections;
using System.Collections.Generic;
using Decorator.Interface;
using UnityEngine;

namespace Decorator.Condiment
{
    public class Whip : CondimentDecorator
    {
        public Whip(IBeverage beverage)
        {
            _beverage = beverage;
        }
        
        public override string Description { get; set; } = "Whip";

        public override string GetDescription()
        {
            return $"{_beverage.GetDescription()}, {Description}($0.1)";
        }

        public override double Cost()
        {
            return _beverage.Cost() + 0.1;
        }
    }
}