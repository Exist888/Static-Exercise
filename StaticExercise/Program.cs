using System.Net;

namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Fahrenheit to Celsius - User Input, Method Call, and Output
            Console.WriteLine("Enter a temperature in Fahrenheit to convert to Celsius.");
            var parsedSuccess = double.TryParse(Console.ReadLine(), out var tempInput);

            while (!parsedSuccess)
            {
                Console.WriteLine("Please enter a valid number:");
                parsedSuccess = double.TryParse(Console.ReadLine(), out tempInput);
            }
            
            Console.WriteLine(TempConverter.FahrenheitToCelsius(tempInput)); 
            
            
            //Celsius to Fahrenheit - User Input, Method Call, and Output
            Console.WriteLine("Now enter a temperature in Celsius to convert to Fahrenheit.");
            var parsedSuccess2 = double.TryParse(Console.ReadLine(), out var tempInput2);

            while (!parsedSuccess2)
            {
                Console.WriteLine("Please enter a valid number:");
                parsedSuccess2 = double.TryParse(Console.ReadLine(), out tempInput2);
            }
            
            Console.WriteLine(TempConverter.CelsiusToFahrenheit(tempInput2));
        }
    }
}
