using BibliotecaActRepas;
using System;
using System.Data;

namespace ActRepas
{
    public static class Activitats
    {
        public static void Main()
        {
            string Msg = "hola que tal";
            try
            {
                Console.WriteLine(Act19.ChangeMayusString(Msg));
            }
            catch (FormatException)
            {
                Console.WriteLine("Error");
            }
        }
    }
}