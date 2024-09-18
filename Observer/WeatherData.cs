namespace Sample.Observer.Console
{
    public class WeatherData : ISubject
    {
        private Dictionary<Guid, IObserver> observers;
        private float temperature;
        private float humidity;
        private float pressure;

        public WeatherData()
        {
            observers = [];
        }

        public Guid RegisterObserver(IObserver o)
        {
            var id = Guid.NewGuid();
            observers.Add(id, o);
            return id;
        }

        public void RemoveObserver(Guid id)
        {
            observers.Remove(id);
        }

        public void NotifyObservers()
        {
            foreach (IObserver observer in observers.Values)
            {
                observer.Update(temperature, humidity, pressure);
            }
        }

        public void MeasurementsChanged()
        {
            NotifyObservers();
        }

        public void SetMeasurements(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
            MeasurementsChanged();
        }
    }
}