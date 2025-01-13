using BibliotecaActRepas;
using System;
using System.Data;

namespace ActRepas
{
    public static class Activitats
    {
        public static void Main()
        {
            const string MsgTotalWords = "Your string has {0} words";
            string msg = "Hola que tal como estas?";
            try
            { 
                Console.WriteLine(MsgTotalWords, Act18.CountWordsString(msg));
            }
            catch (FormatException)
            {
                Console.WriteLine("Error");
            }
        }
    }
}