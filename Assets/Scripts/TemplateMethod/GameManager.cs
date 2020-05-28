using TemplateMethod.Abstract;
using UnityEngine;

namespace TemplateMethod
{

    public class GameManager : MonoBehaviour
    {
        void Start()
        {
            Tea tea = new Tea();
            tea.PrepareRecipe();
            Coffee coffee = new Coffee();
            coffee.PrepareRecipe();
            CoffeineBeverage teaBase = tea;
            CoffeineBeverage coffeeBase = coffee;
            teaBase.PrepareRecipe();
            coffeeBase.PrepareRecipe();
        }
    }
}