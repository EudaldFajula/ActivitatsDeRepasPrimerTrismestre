using BibliotecaActRepas;
using System; 

namespace ActRepas
{
    public static class Activitats
    {
        public static void Main()
        {
            const string MsgPostalCode = "Enter your postal code: ";
            const string MsgRight = "Your postal code is correct";
            const string MsgWrong = "Your postal code is incorrect";
            Console.WriteLine(MsgPostalCode);
            try
            {
                string postalCode = Console.ReadLine();
                if (Act8.AnalizeGeneralPostalCode(postalCode))
                {
                    Console.WriteLine(MsgRight);
                }
                else
                {
                    Console.WriteLine(MsgWrong);
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Error");
            }
        }
    }
}