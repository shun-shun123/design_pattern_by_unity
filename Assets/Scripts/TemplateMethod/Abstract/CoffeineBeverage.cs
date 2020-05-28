using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TemplateMethod.Abstract
{

    public abstract class CoffeineBeverage
    {
        public void PrepareRecipe()
        {
            _BoilWater();
            Brew();
            _PourInCup();
            if (CustomerWantsCondiments())
            {
                AddCondiments();
            }
        }

        protected abstract void Brew();

        protected abstract void AddCondiments();

        protected virtual bool CustomerWantsCondiments() => true;

        private void _BoilWater()
        {
            Debug.Log("お湯を沸かします");
        }

        private void _PourInCup()
        {
            Debug.Log("カップに注ぎます");
        }
    }
}