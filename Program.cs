using BibliotecaActRepas;
using System;
using System.Data;

namespace ActRepas
{
    public static class Activitats
    {
        public static void Main()
        {
            const string Msg = "Enter a number: ";
            const string FinalMsg = "Your number is {0} long";
            int number;
            int counter = 0;
            Console.WriteLine(Msg);
            try
            {
                number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(FinalMsg, Act11.CountLengthNum(number, counter));
            }
            catch (FormatException)
            {
                Console.WriteLine("Error");
            }
        }
    }
}