using System.Collections;
using System.Collections.Generic;
using System.Text;
using Observer.Interface;
using Observer.Subject;
using UnityEngine;

namespace Observer.Display
{
    public class StatisticsDisplay : IObserver
    {
        private ISubject _subject;

        public StatisticsDisplay()
        {
            _subject = new WeatherData();
        }
        
        public void Update(object obj)
        {
            if (obj is WeatherDto dto)
            {
                var info = new StringBuilder();
                info.Append("-----StatisticsDisplay-----\n");
                for (var i = 0; i < dto.Temperature; i++)
                {
                    info.Append("=");
                }
                info.Append($" {dto.Temperature}℃\n");

                for (var i = 0; i < dto.Humidity; i++)
                {
                    info.Append("*");
                }
                info.Append($" {dto.Humidity}%\n");

                for (var i = 0; i < dto.Pressure / 100; i++)
                {
                    info.Append("#");
                }
                info.Append($" {dto.Pressure}hPa\n");
                Debug.Log(info.ToString());
            }
        }
    }
}