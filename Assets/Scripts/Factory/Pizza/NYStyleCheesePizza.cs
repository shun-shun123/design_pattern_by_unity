using UnityEngine;

namespace Factory.Pizza
{

    public class NYStyleCheesePizza : Pizza
    {
        public NYStyleCheesePizza()
        {
            Toppings.Add("NYスペシャルトッピング");
            Toppings.Add("チーズ");
            Toppings.Add("辛いソース");
        }
    }
}