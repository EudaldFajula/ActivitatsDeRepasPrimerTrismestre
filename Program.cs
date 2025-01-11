using BibliotecaActRepas;
using System;
using System.Data;

namespace ActRepas
{
    public static class Activitats
    {
        public static void Main()
        {
            const string MsgAscendentment = "The array is ordered ascendentment";
            const string MsgDescentment = "The array is ordered descentment";
            const string MsgIncorrect = "The array is not ordered";
            //Create array
            int[] array = {4,6,2,1};
            try
            {
                if (Act13.AnalyzeArrayIfGood(array) == 1)
                {
                    Console.WriteLine(MsgAscendentment);
                }else if (Act13.AnalyzeArrayIfGood(array) == -1)
                {
                    Console.WriteLine(MsgDescentment);
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