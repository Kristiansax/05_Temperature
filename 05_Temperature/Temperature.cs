using System;
namespace _05_Temperature
{
    public enum Unit
    {
        Celcius,
        Fahrenheit
    }
    public class Temperature
    {
        public Temperature()
        {

        }
        public int Fahrenheit;
        public int Celcius;
        public Temperature(Unit Type, int Input)
        {
            switch(Type)
            {
                case Unit.Fahrenheit:
                    Fahrenheit = Input;
                    break;

                case Unit.Celcius:
                    Celcius = Input;
                    break;
            }
        }

        public static double FahrenheitToCelcius(double x)
        {
            return (x - 32) * 5 / 9;
        }
        public static double CelciusToFahrenheit(double x)
        {
            return x * 9 / 5 + 32;
        }
    }
}