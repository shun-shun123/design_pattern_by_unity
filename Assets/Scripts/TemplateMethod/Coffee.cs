using TemplateMethod.Abstract;
using UnityEngine;

namespace TemplateMethod
{

    public class Coffee : CoffeineBeverage
    {
        protected override void Brew()
        {
            Debug.Log("フィルタでコーヒーをドリップします");
        }

        protected override void AddCondiments()
        {
            Debug.Log("砂糖とミルクを追加します");
        }
    }
}