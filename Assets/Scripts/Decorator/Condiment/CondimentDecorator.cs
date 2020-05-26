using System.Collections;
using System.Collections.Generic;
using Decorator.Interface;
using UnityEngine;

namespace Decorator.Condiment
{
    public abstract class CondimentDecorator : IBeverage
    {
        protected IBeverage _beverage;
        
        public abstract string Description { get; set; }

        public abstract string GetDescription();

        public abstract double Cost();
    }
}