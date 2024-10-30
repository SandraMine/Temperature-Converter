namespace Temperature_Converter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                while (true)
                {
                    Console.WriteLine("Temperature Converter");
                    Console.WriteLine("Choose a conversion type:");
                    Console.WriteLine("a. Celsius to Fahrenheit");
                    Console.WriteLine("b. Fahrenheit to Celsius");
                    Console.WriteLine("c. Celsius to Kelvin");
                    Console.WriteLine("d. Kelvin to Celsius");
                    Console.WriteLine("e. Fahrenheit to Kelvin");
                    Console.WriteLine("f. Kelvin to Fahrenheit");
                    Console.WriteLine("g. Exit");

                    string choice = Console.ReadLine();

                    if (choice == "g")
                    {
                        Console.WriteLine("Exiting the program.");
                        break;
                    }

                    Console.Write("Enter the temperature: ");
                    string input = Console.ReadLine();
                    double temperature;

                    // Validate input
                    if (!double.TryParse(input, out temperature))
                    {
                        Console.WriteLine("Invalid input. Please enter a numeric value.");
                        continue;
                    }

                    switch (choice)
                    {
                        case "a":
                            // Celsius to Fahrenheit
                            double cToF = (temperature * 9 / 5) + 32;
                            Console.WriteLine($"{temperature} °C = {cToF} °F");
                            break;

                        case "b":
                            // Fahrenheit to Celsius
                            double fToC = (temperature - 32) * 5 / 9;
                            Console.WriteLine($"{temperature} °F = {fToC} °C");
                            break;

                        case "c":
                            // Celsius to Kelvin
                            double cToK = temperature + 273.15;
                            Console.WriteLine($"{temperature} °C = {cToK} K");
                            break;

                        case "d":
                            // Kelvin to Celsius
                            double kToC = temperature - 273.15;
                            Console.WriteLine($"{temperature} K = {kToC} °C");
                            break;

                        case "e":
                            // Fahrenheit to Kelvin
                            double fToK = (temperature - 32) * 5 / 9 + 273.15;
                            Console.WriteLine($"{temperature} °F = {fToK} K");
                            break;

                        case "f":
                            // Kelvin to Fahrenheit
                            double kToF = (temperature - 273.15) * 9 / 5 + 32;
                            Console.WriteLine($"{temperature} K = {kToF} °F");
                            break;

                        default:
                            Console.WriteLine("Invalid choice. Please select a valid option.");
                            break;
                    }

                    Console.WriteLine(); // New line for better readability
                    
                }
            }
        }

    }
}

