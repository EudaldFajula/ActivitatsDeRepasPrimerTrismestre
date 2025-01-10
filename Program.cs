using BibliotecaActRepas;
using System; 

namespace ActRepas
{
    public static class Activitats
    {
        public static void Main()
        {
            const string MsgKelvin = "Write the degrees in Kelvin";
            const string FinalMsg = "The Kelvin degrees in Fahrenheit are: {0}";
            double kelvin;
            Console.WriteLine(MsgKelvin);
            kelvin = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(FinalMsg, Act5.CalculateDegreesKelvinToCelsius(kelvin));
        }
    }
}