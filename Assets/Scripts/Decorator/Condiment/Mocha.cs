using System.Collections;
using System.Collections.Generic;
using Decorator.Interface;
using UnityEngine;

namespace Decorator.Condiment
{

    public class Mocha : CondimentDecorator
    {
        public Mocha(IBeverage beverage)
        {
            _beverage = beverage;
        }
        
        public override string Description { get; set; } = "Mocha";

        public override string GetDescription()
        {
            return $"{_beverage.GetDescription()}, {Description}($0.2)";
        }

        public override double Cost()
        {
            return _beverage.Cost() + 0.2;
        }
    }
}