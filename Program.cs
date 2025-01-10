using BibliotecaActRepas;
using System; 

namespace ActRepas
{
    public static class Activitats
    {
        public static void Main()
        {
            const string Msg = "Enter an import";
            const string FinalMsg = "The tip is: {0}";
            double importNum;
            try
            {
                Console.WriteLine(Msg);
                importNum = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine(FinalMsg, Act9.CalculateTip(importNum));
            }
            catch (FormatException)
            {
                Console.WriteLine("Error");
            }
        }
    }
}