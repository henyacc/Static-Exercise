namespace StaticExercise
{
    public static class TempConverter
    {
        public static double FahrenheitToCelsius(double fahrenheit)
        {
            var result = (fahrenheit - 32) /1.8;
            return result;
        }

        public static double CelciusTofahrenheit(double celcius)
        {
            var result = (celcius * 1.8) + 32;
            return result;
        }
    }

}