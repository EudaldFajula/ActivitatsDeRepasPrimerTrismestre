using BibliotecaActRepas;
using System; 

namespace ActRepas
{
    public static class Activitats
    {
        public static void Main()
        {
            const string MsgCelsius = "Write the degrees in Celsius";
            const string FinalMsg = "The Celsius degrees in Fahrenheit are: {0}";
            double celsius;
            Console.WriteLine(MsgCelsius);
            celsius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(FinalMsg, Act3.CalculateDegrees(celsius));
        }
    }
}