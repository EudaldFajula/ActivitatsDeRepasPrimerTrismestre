using BibliotecaActRepas;
using System;
using System.Data;

namespace ActRepas
{
    public static class Activitats
    {
        public static void Main()
        {
            const string MsgMaxNum = "Enter the maximum";
            const string MsgMinNum = "Enter the minimum";
            const string MsgNumDiv = "Enter the divisible number";
            int numMax, numMin, numDiv;
            Console.WriteLine(MsgMaxNum);
            try
            {
                numMax = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(MsgMinNum);
                numMin = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(MsgNumDiv);
                numDiv = Convert.ToInt32(Console.ReadLine());
                int[] arrayNum = Act14.CalcuateDivisibleNumber(numDiv, numMax, numMin);
                for(int i = 0; i < arrayNum.Length; i++)
                {
                    if (arrayNum[i] != 0)
                    {
                        Console.WriteLine($"{arrayNum[i]} ");
                    }
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Error");
            }
        }
    }
}