using BibliotecaActRepas;
using System;
using System.Data;

namespace ActRepas
{
    public static class Activitats
    {
        public static void Main()
        {
            string Msg = "One Three, asnmfdaoaondao";
            try
            {
               Console.WriteLine(Act20.FindLargerWord(Msg));
            }
            catch (FormatException)
            {
                Console.WriteLine("Error");
            }
        }
    }
}