namespace StaticExercise;

public static class TempConverter
{
    public static double FahrenheitToCelsius(double inputTempF)
    {
        //double outputTempC1 = (inputTempF1 - 32) * 5 / 9;
        //return outputTempC1;
        return (inputTempF - 32) * 5 / 9;
    }

    public static double CelsiusToFahrenheit(double inputTempC)
    {
        //double outputTempF2 = (inputTempC2 * 9 / 5) + 32;
        //return outputTempF2;
        return (inputTempC * 9 / 5) + 32;
    }
}