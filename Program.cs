using BibliotecaActRepas;
using System;
using System.Data;

namespace ActRepas
{
    public static class Activitats
    {
        public static void Main()
        {
            int[] arrayNumbers = { 1, 2, 3, 4, 5, 6 };
            bool variableForArray = false;
            try
            {
                Console.WriteLine(Act15.ArrayMaxOrMin(arrayNumbers, variableForArray));
            }
            catch (FormatException)
            {
                Console.WriteLine("Error");
            }
        }
    }
}