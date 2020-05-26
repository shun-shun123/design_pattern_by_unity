using UnityEngine;

namespace Factory.Pizza
{

    public class ChicagoStyleCheesePizza : Pizza
    {
        public ChicagoStyleCheesePizza()
        {
            Toppings.Add("シカゴ");
            Toppings.Add("チーズ");
        }
    }
}