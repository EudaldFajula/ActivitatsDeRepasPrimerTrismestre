using BibliotecaActRepas;
using System;
using System.Data;

namespace ActRepas
{
    public static class Activitats
    {
        public static void Main()
        {
            const string normalString = "Hola que tal";
            try
            {
                char[] finalString = Act17.ReverseString(normalString);
                for(int i = 0; i < finalString.Length; i++)
                {
                    Console.Write(finalString[i]);
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Error");
            }
        }
    }
}