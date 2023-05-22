// See https://aka.ms/new-console-template for more information


public class ForecastDisplay : IObserver, IDisplay
{
    private float _currentPressure = 29.92f;
    private float _lastPressure;
    private readonly WeatherData _weatherData;

    public ForecastDisplay(WeatherData weatherData)
    {
        _weatherData = weatherData;
        _weatherData.RegisterObserver(this);
    }

    public void Display()
    {
        Console.Write("Forecast :");
        if (_currentPressure > _lastPressure)
        {
            Console.WriteLine("Improving weather on the way!");
        }
        else if (_currentPressure == _lastPressure)
        {
            Console.WriteLine("More of the same");
        }
        else if (_currentPressure < _lastPressure)
        {
            Console.WriteLine("Watch out for cooler, rainy weather");
        }
    }

    public void Update()
    {
        _lastPressure = _currentPressure;
        _currentPressure = _weatherData.GetPresure();
        Display();
    }
}


