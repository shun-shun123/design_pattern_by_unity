using Factory.Pizza;

namespace Factory.Store
{

    public class NYPizzaStore : PizzaStore
    {
        protected override Pizza.Pizza CreatePizza(string type)
        {
            Pizza.Pizza pizza = null;
            if (type.Equals("シンプル"))
            {
                pizza = new NYStyleSimplePizza();
            }
            else if (type.Equals("チーズ"))
            {
                pizza = new NYStyleCheesePizza();
            }

            return pizza;
        }
    }
}