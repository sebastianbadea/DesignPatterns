namespace Sample.Observer.Console
{
    public class StatisticsDisplay : IObserver, IDisplayElement
    {
        private float maxTemp = 0.0f;
        private float minTemp = 200;
        private float tempSum = 0.0f;
        private int numReadings;

        public void Update(float temperature, float humidity, float pressure)
        {
            tempSum += temperature;
            numReadings++;

            if (temperature > maxTemp)
            {
                maxTemp = temperature;
            }

            if (temperature < minTemp)
            {
                minTemp = temperature;
            }

            Display();
        }

        public void Display()
        {
            System.Console.WriteLine($"Avg/Max/Min temperature = {tempSum / numReadings}/{maxTemp}/{minTemp}");
        }
    }
}