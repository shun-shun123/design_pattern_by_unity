using TemplateMethod.Abstract;
using UnityEngine;

namespace TemplateMethod
{

    public class Tea : CoffeineBeverage
    {
        protected override void Brew()
        {
            Debug.Log("紅茶を浸します");
        }

        protected override void AddCondiments()
        {
            Debug.Log("レモンを追加します");
        }

        protected override bool CustomerWantsCondiments() => false;
    }
}