// See https://aka.ms/new-console-template for more information


//weatherData.SetMeasurements(62, 90, 28.1f);
public interface ISubject
{
    void RegisterObserver(IObserver observer);
    void RemoveObserver(IObserver observer);
    void NotifyObserver();
}


