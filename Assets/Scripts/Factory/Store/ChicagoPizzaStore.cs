using System;
using Factory.Pizza;

namespace Factory.Store
{

    public class ChicagoPizzaStore : PizzaStore
    {
        protected override Pizza.Pizza CreatePizza(string type)
        {
            Pizza.Pizza pizza = null;
            if (type.Equals("シンプル"))
            {
                pizza = new ChicagoStyleSimplePizza();
            }
            else if (type.Equals("チーズ"))
            {
                pizza = new ChicagoStyleCheesePizza();
            }

            return pizza;
        }
    }
}