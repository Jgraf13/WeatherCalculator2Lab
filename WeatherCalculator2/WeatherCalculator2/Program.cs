using System;

namespace WeatherCalculator2
{
    class Program
    {
        static double Main(string[] args)
        {
            Console.WriteLine("### Weather Calculator 2");

            int temperature;
            int windSpeed;
            double windChill;
            string input = "";

            // Get the temperature from the user
            Console.WriteLine("Enter the temperature");

            input = Console.ReadLine();

            temperature = int.Parse(input);



            if (temperature > 50)
            {
                Console.WriteLine("Enter the Relative Humidity");
                input = Console.ReadLine();
                int RelativeHumidity;
                RelativeHumidity = int.Parse(input);
                double Heat;
                Heat = 0.5 * (temperature + 61.0 + ((temperature - 68.0) * 1.2) + (RelativeHumidity * 0.094));
           


            }
            else
            {
                Console.WriteLine("Enter the Wind Speed");

                input = Console.ReadLine();

                windSpeed = int.Parse(input);
            }

            // Get the windspeed from the user
            Console.WriteLine("Enter the wind speed");

            input = Console.ReadLine();

            windSpeed = int.Parse(input);

            // Calculate the wind chill

            windChill = 35.74 + (0.6125 * temperature) - 35.75 * Math.Pow(windSpeed, 0.16) + 0.4275 * temperature * Math.Pow(windSpeed, 0.16);

            Console.WriteLine("The wind chill is " + windChill);
        }

        private static double GetRelativeHumidity(double RelativeHumidity)
        {
            return RelativeHumidity;
        }
    }
}
