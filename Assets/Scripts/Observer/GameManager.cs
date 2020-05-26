using System;
using System.Collections;
using System.Collections.Generic;
using Observer.Display;
using Observer.Interface;
using Observer.Subject;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Observer
{
    public class GameManager : MonoBehaviour
    {
        private WeatherData _weatherData = new WeatherData();
        
        private CurrentConditionsDisplay _currentConditionsDisplay = new CurrentConditionsDisplay();
        
        private StatisticsDisplay _statisticsDisplay = new StatisticsDisplay();

        private void Start()
        {
            _weatherData.RegisterObserver(_currentConditionsDisplay);
            _weatherData.RegisterObserver(_statisticsDisplay);
            StartCoroutine(_MeasurementsChangeCoroutine());
        }

        private IEnumerator _MeasurementsChangeCoroutine()
        {
            while (true)
            {
                _weatherData.MeasurementsChanged();
                yield return new WaitForSeconds(Random.Range(1.0f, 3.0f));
            }
        }
    }
}