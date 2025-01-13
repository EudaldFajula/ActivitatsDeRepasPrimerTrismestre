using BibliotecaActRepas;
using System;
using System.Data;

namespace ActRepas
{
    public static class Activitats
    {
        public static void Main()
        {
            const string MsgCorrect = "The array is palindromic";
            const string MsgIncorrect = "The array is not palindromic";
            int[] arrayPalindromic = { 9,0,0,9};
            try
            {
                Console.WriteLine(Act16.ValidatePalindromic(arrayPalindromic) ? MsgCorrect : MsgIncorrect);
            }
            catch (FormatException)
            {
                Console.WriteLine("Error");
            }
        }
    }
}