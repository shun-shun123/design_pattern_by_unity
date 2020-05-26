using System;
using System.Collections;
using System.Collections.Generic;
using Decorator.Condiment;
using Decorator.Drink;
using Decorator.Interface;
using UnityEngine;

namespace Decorator
{
    public class GameManager : MonoBehaviour
    {
        private IBeverage _beverage;

        private void Start()
        {
            _beverage = new Espresso();
        }

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Return))
            {
                Debug.Log($"Description: {_beverage.GetDescription()}");
                Debug.Log($"Cost: {_beverage.Cost()}");
            }

            if (Input.GetKeyDown(KeyCode.D))
            {
                _beverage = new DarkRoast();
                _beverage = new Whip(_beverage);
                _beverage = new Milk(_beverage);
            }
            else if (Input.GetKeyDown(KeyCode.H))
            {
                _beverage = new HouseBlend();
                _beverage = new Whip(_beverage);
            } 
            else if (Input.GetKeyDown(KeyCode.E))
            {
                _beverage = new Espresso();
                _beverage = new Whip(_beverage);
            }
        }
    }
}