namespace ConsoleApp1.Observer;

internal class Observer
{
    private static readonly Lazy<Observer> lazy = new(() => new Observer());
    public static Observer Instance
    {
        get
        {
            return lazy.Value;
        }
    }

    private Observer()
    {

    }

    public void Perform()
    {
        WeatherData weatherData = new();
        CurrentConditionsDisplay current = new(weatherData);
        ForecastDisplay forecast = new(weatherData);
        StatisticsDisplay statistics = new(weatherData);
        HeatIndexDisplay heatIndex = new(weatherData);

        weatherData.SetMeasurements(80, 65, 30.4f);
        Thread.Sleep(1000);

        weatherData.SetMeasurements(82, 70, 29.2f);
        Thread.Sleep(1000);
        weatherData.SetMeasurements(78, 90, 29.2f);
        Thread.Sleep(1000);
        weatherData.RemoveObserver(forecast);
        Thread.Sleep(1000);
    }
}
