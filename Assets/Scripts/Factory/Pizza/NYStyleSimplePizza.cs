using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Factory.Pizza
{

    public class NYStyleSimplePizza : Pizza
    {
        public NYStyleSimplePizza()
        {
            Toppings.Add("NYスペシャルトッピング");
        }
    }
}