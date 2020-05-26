namespace Factory.Store
{
    public abstract class PizzaStore
    {
        public void OrderPizza(string type)
        {
            var pizza = CreatePizza(type);
            
            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
        }

        protected abstract Pizza.Pizza CreatePizza(string type);
    }
}