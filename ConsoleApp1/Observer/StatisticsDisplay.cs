﻿public class StatisticsDisplay : IObserver, IDisplay
{
    private float _maxTemp = 0.0f;
    private float _minTemp = 200;
    private float _tempSum = 0.0f;
    private int _numReadings;
    private readonly WeatherData _weatherData;

    public StatisticsDisplay(WeatherData weatherData)
    {
        _weatherData = weatherData;
        _weatherData.RegisterObserver(this);
    }

    public void Display()
    {
        Console.WriteLine("Avg/Max/Min temperature = " + (_tempSum / _numReadings)
            + "/" + _maxTemp + "/" + _minTemp);
    }

    public void Update()
    {
        // _weatherData.GetPresure();
        var temp = _weatherData.Temperature;
        _tempSum += temp;
        _numReadings++;

        if (temp > _maxTemp)
        {
            _maxTemp = temp;
        }

        if (temp < _minTemp)
        {
            _minTemp = temp;
        }

        Display();
    }
}


