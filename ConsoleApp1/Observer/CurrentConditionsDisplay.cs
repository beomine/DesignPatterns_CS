﻿public class CurrentConditionsDisplay : IObserver,IDisplay
{
    private float _temperature;
    private float _humidity;
    private readonly WeatherData _weatherData;

    public CurrentConditionsDisplay(WeatherData weatherData)
    {
        _weatherData = weatherData;
        _weatherData.RegisterObserver(this);
    }

    public void Display()
    {
        Console.WriteLine($"Current conditions : temperature : {_temperature}, humidity : {_humidity}%");
    }

    public void Update()
    {
        _temperature = _weatherData.Temperature;
        _humidity = _weatherData.Humidity;
        Display();
    }
}


