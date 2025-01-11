using BibliotecaActRepas;
using System;
using System.Data;

namespace ActRepas
{
    public static class Activitats
    {
        public static void Main()
        {
            const string MsgCorrect = "The array is ordered";
            const string MsgIncorrect = "The array is not ordered";
            //Create array
            int[] array = {1,2,3,1,5,6};
            try
            {
                if (Act12.AvaluateArray(array))
                {
                    Console.WriteLine(MsgCorrect);
                }
                else
                {
                    Console.WriteLine(MsgIncorrect);
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Error");
            }
        }
    }
}