// See https://aka.ms/new-console-template for more information


public class WeatherData : ISubject
{
    private List<IObserver> _observers;
    private float _temperature;
    private float _humidity;
    private float _pressure;

    public float GetTemperature()
    {
        return _temperature;
    }

    public float GetHumidity()
    {
        return _humidity;
    }

    public float GetPresure()
    {
        return _pressure;
    }

    public void MeasurementsChanged()
    {
        NotifyObserver();
    }

    public void RegisterObserver(IObserver observer)
    {
        _observers.Add(observer);
    }

    public void RemoveObserver(IObserver observer)
    {
        _observers.Remove(observer);
    }

    public void NotifyObserver()
    {
        foreach (var item in _observers)
        {
            item.Update();
        }
    }

    public void SetMeasurements(float temp, float humidity, float pressure)
    {
        _temperature = temp;
        _humidity = humidity;
        _pressure = pressure;
        MeasurementsChanged();
    }

    public WeatherData()
    {
        _observers = new List<IObserver>();
    }
}


