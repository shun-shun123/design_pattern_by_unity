using System.Collections;
using System.Collections.Generic;
using Factory.Store;
using UnityEngine;

namespace Factory
{

    public class GameManager : MonoBehaviour
    {
        private PizzaStore _NYStore = new NYPizzaStore();

        private PizzaStore _ChicagoStore = new ChicagoPizzaStore();
        
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Return))
            {
                _NYStore.OrderPizza("シンプル");
                _ChicagoStore.OrderPizza("チーズ");
            }
        }
    }
}