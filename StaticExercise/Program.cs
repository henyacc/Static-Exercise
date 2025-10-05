namespace StaticExercise
{
    public static class Program
    {
        static void Main(string[] args)
        {
            var celcius = TempConverter.FahrenheitToCelsius(68);
            var farenheit = TempConverter.CelciusTofahrenheit(20);

            Console.WriteLine($"celcius {celcius}");
            Console.WriteLine($"farenheit {farenheit}");
            
            
        }
        
    }
}
