using BibliotecaActRepas;
using System;
using System.Data;
using System.Runtime.InteropServices;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ActRepas
{
    //Codi 1
    public class FirstCode
    {
        public static int GetNumber()
        {
            const string Msg = "Introdueix un número:";
            Console.WriteLine(Msg);
            int num = Convert.ToInt32(Console.ReadLine());
            return num;
        }
        public static int GetSquare(int num)
        {
            return num * num;
        }
        public static void PrintResult(int num)
        {
            const string MsgSquare = "El quadrat de {0} és {1}.";
            Console.WriteLine(MsgSquare, num, GetSquare(num));
            Console.WriteLine(MsgSquare, num, GetSquare(num));
            Console.WriteLine(MsgSquare, num, GetSquare(num));
        }
        public static void Main()
        {
            int num1 = GetNumber();
            int num2 = GetNumber();
            int num3 = GetNumber();
            PrintResult(num1);
            PrintResult(num2);
            PrintResult(num3);
        }
    }
    //Codi 2
    public class SecondCode
    {
        public static int[] TransformArrayToInt(string[] arrayInput)
        {
            int[] arrayNumber = new int[arrayInput.Length];
            for (int i = 0; i < arrayInput.Length; i++)
            {
                arrayNumber[i] = Convert.ToInt32(arrayInput[i].Trim());
            }
            return arrayNumber;
        }
        public static double CalculateAverage(int[] arrayNumber)
        {
            int sum = 0;
            for (int i = 0; i < arrayNumber.Length; i++)
            {
                sum += arrayNumber[i];
            }
            return (double)sum / arrayNumber.Length;
        }
        public static int CalculateMaxNumber(int[] arrayNumber)
        {
            int max = arrayNumber[0];
            for (int i = 1; i < arrayNumber.Length; i++)
            {
                if (arrayNumber[i] > max)
                {
                    max = arrayNumber[i];
                }
            }
            return max;
        }
        public static void Main()
        {
            const string Msg = "Introdueix una llista de números separats per comes:";
            const string MsgAverage = "Mitjana: {0}";
            const string MsgMaxNum = "Número més alt: {0}";

            string input;

            Console.WriteLine(Msg);
            input = Console.ReadLine();

            string[] arrayInput = input.Split(',');
            int[] arrayNumber = TransformArrayToInt(arrayInput);

            Console.WriteLine(MsgAverage, CalculateAverage(arrayNumber));
            Console.WriteLine(MsgMaxNum, CalculateMaxNumber(arrayNumber));
        }
    }
    //Codi 3
    public class ThirdCode
    {
        public static int GetNumber()
        {
            const string Msg = "Introdueix un número positiu:";
            const string IncorrectNumMsg = "El número ha de ser positiu.";
            bool correctNum = true;
            int number = 0;
            while (correctNum)
            {
                // Demanar un número per calcular la suma dels imparells
                Console.WriteLine(Msg);
                number = Convert.ToInt32(Console.ReadLine());

                if (number <= 0)
                {
                    Console.WriteLine(IncorrectNumMsg);
                }
                else
                {
                    correctNum = false;
                }
            }
            return number;
        }
        public static int SumOddNumbers(int number)
        {
            // Calcular la suma dels nombres imparells fins a number
            int sumOdd = 0;
            for (int i = 1; i <= number; i++)
            {
                if (i % 2 != 0)
                {
                    sumOdd += i;
                }
            }
            return sumOdd;
        }
        public static int CalculateMCD(int numOne,  int numTwo)
        {
            // Calcular el MCD
            int mcd = 1;
            for (int i = 1; i <= Math.Min(numOne, numTwo); i++)
            {
                if (numOne % i == 0 && numTwo % i == 0)
                {
                    mcd = i;
                }
            }
            return mcd;
        }
        public static void Main()
        {
            const string MsgOddNumbers = "La suma dels nombres imparells fins a {0} és: {1}";
            const string MsgMCD = "El màxim divisor comú de {0} i {1} és: {2}";

            int number = GetNumber();
            Console.WriteLine(MsgOddNumbers, number, SumOddNumbers(number));

            int numOne = GetNumber();
            int numTwo = GetNumber();
            Console.WriteLine(MsgMCD, numOne, numTwo, CalculateMCD(numOne, numTwo));
        }
    }
}