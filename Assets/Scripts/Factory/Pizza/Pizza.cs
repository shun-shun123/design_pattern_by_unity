using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Factory.Pizza
{

    public abstract class Pizza
    {
        public string Name { get; private set; }
        
        public string Dough { get; private set; }
        
        public string Sauce { get; private set; }
        
        public List<string> Toppings { get; private set; } = new List<string>();

        public void Prepare()
        {
            Debug.Log("Prepare");
            foreach (var topping in Toppings)
            {
                Debug.Log($"Topping: {topping}");
            }
        }

        public void Bake()
        {
            Debug.Log("Bake");
        }

        public void Cut()
        {
            Debug.Log("Cut");
        }

        public void Box()
        {
            Debug.Log("Box");
        }
    }
}