
using Sample.Observer.Console;

WeatherData weatherData = new WeatherData();
CurrentConditionsDisplay currentDisplay = new ();
StatisticsDisplay statisticsDisplay = new();

Console.WriteLine("2 observers:");
var currentDisplayRegistration = weatherData.RegisterObserver(currentDisplay);
weatherData.RegisterObserver(statisticsDisplay);

weatherData.SetMeasurements(80, 65, 30.4f);
weatherData.SetMeasurements(82, 70, 29.2f);
weatherData.SetMeasurements(78, 90, 29.2f);

weatherData.RemoveObserver(currentDisplayRegistration);
Console.WriteLine("1 observer:");
weatherData.SetMeasurements(95, 72, 31.1f);
weatherData.SetMeasurements(92, 62, 29.1f);