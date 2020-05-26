using System.Collections.Generic;
using Observer.Interface;
using UnityEngine;

namespace Observer.Subject
{

    public class WeatherData : ISubject
    {
        private List<IObserver> _observers = new List<IObserver>();

        private float _temperature;
        
        private float _humidity;
        
        private float _pressure;
        
        public void RegisterObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            for (var i = 0; i < _observers.Count; i++)
            {
                if (observer == _observers[i])
                {
                    _observers.RemoveAt(i);
                    break;
                }
            }
        }

        public void NotifyObservers()
        {
            foreach (var observer in _observers)
            {
                observer.Update(new WeatherDto(_temperature, _humidity, _pressure));
            }
        }

        private float _GetTemperature() => Random.Range(0.0f, 40.0f);
        
        private float _GetHumidity() => Random.Range(20.0f, 80.0f);
        
        private float _GetPressure() => Random.Range(1000.0f, 1020.0f);

        public void MeasurementsChanged()
        {
            _temperature = _GetTemperature();
            _humidity = _GetHumidity();
            _pressure = _GetPressure();
            NotifyObservers();
        }
    }

    public class WeatherDto
    {
        public readonly float Temperature;

        public readonly float Humidity;

        public readonly float Pressure;

        public WeatherDto(float temperature, float humidity, float pressure)
        {
            this.Temperature = temperature;
            this.Humidity = humidity;
            this.Pressure = pressure;
        }
    }
}