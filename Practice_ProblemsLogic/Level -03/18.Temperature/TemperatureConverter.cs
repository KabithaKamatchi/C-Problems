

namespace Practice_Problems.Logic;

    public static class TemperatureConverter
    {
        public static string CalculateTemperature(int nTemperature, string strChoice)
        {
            switch(strChoice)
            {
                case "C":
                {
                    double dCelsius = (nTemperature - 32) * 5.0 / 9.0;
                    return $"The temperature in Celsius is {dCelsius:F2}";
                }
                case "F":
                {
                    double dFahrenheit = (nTemperature * 9.0 / 5.0) + 32;
                    return $"The temperature in Fahrenheit is {dFahrenheit:F1}";
                }
                default:
                    return $"Invalid Choice";
            }
        }
    }
