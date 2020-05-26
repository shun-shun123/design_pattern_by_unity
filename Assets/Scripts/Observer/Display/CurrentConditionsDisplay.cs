using System.Collections;
using System.Collections.Generic;
using System.Text;
using Observer.Interface;
using Observer.Subject;
using UnityEngine;

namespace Observer.Display
{

    public class CurrentConditionsDisplay : IObserver
    {
        private ISubject _subject;

        public CurrentConditionsDisplay()
        {
            _subject = new WeatherData();
        }

        public void Update(object obj)
        {
            if (obj is WeatherDto dto)
            {
                var info = new StringBuilder();
                info.Append("=====CurrentConditionsDisplay=====\n");
                info.Append($"Temperature: {dto.Temperature}\n");
                info.Append($"Humidity: {dto.Humidity}\n");
                info.Append($"Pressure: {dto.Pressure}\n");
                Debug.Log(info.ToString());
            }
        }
    }
}