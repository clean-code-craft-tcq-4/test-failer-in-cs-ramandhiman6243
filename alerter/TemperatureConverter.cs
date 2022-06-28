namespace AlerterSpace
{
    public class TemperatureConverter
    {
        public static float convertToCelcius(float farenheit)
        {
            float celcius = (farenheit - 32) * 5 / 9;
            return celcius;
        }
    }
}
