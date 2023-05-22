public class WeatherData : ISubject
{
    private readonly List<IObserver> _observers = new List<IObserver>();

    public float Temperature { get; set; }
    public float Humidity { get; set; }
    public float Pressure { get; set; }

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
        _observers.ForEach(item => item.Update());
    }

    public void SetMeasurements(float temp, float humidity, float pressure)
    {
        Temperature = temp;
        Humidity = humidity;
        Pressure = pressure;
        MeasurementsChanged();
    }
}
