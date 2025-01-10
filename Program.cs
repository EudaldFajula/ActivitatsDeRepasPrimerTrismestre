using BibliotecaActRepas;
using System; 

namespace ActRepas
{
    public static class Activitats
    {
        public static void Main()
        {
            const string MsgDecimal = "Enter a decimal number: ";
            const string MsgHexadecimal = "This is the number in hexadecimal:";
            int decimalNum;
            Console.WriteLine(MsgDecimal);
            try
            {
                decimalNum = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(MsgHexadecimal);
                //Create list with the hexadecimal characters
                string[] hexadecimalNum = Act7.ChangeDecimalToHexa(decimalNum);
                //Print the list 
                for (int i = 0; i < decimalNum.ToString().Length; i++)
                {
                    Console.Write(hexadecimalNum[i]);
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Error");
            }
        }
    }
}