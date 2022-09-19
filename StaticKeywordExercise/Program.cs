using System;

namespace StaticKeywordExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is a Static Keyword Exercise.");
            Console.WriteLine();
            Console.WriteLine("Utilizing static methods created within specific classes, we will call for those methods to be used here in the main script.");
            Console.WriteLine();
            var celsius = TempConverter.FahrenheitToCelsius(68.00);
            var fahrenheit = TempConverter.CelsiusToFahrenheit(20.00);
            Console.WriteLine($"The Celsius based temperature is currently standing at {celsius} degrees centigrade.");
            Console.WriteLine();
            Console.WriteLine($"The Fahrenheit based temperature, with the same input, yields {fahrenheit} degrees fahrenheit.");
        }
    }
}
