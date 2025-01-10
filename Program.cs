using BibliotecaActRepas;
using System; 

namespace ActRepas
{
    public static class Activitats
    {
        public static void Main()
        {
            const string Msg = "Enter an import";
            const string MsgPersons = "How many people?";
            const string FinalMsg = "Each person tip is: {0}";
            double importNum;
            int peopleNum;
            try
            {
                Console.WriteLine(Msg);
                importNum = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine(MsgPersons);
                peopleNum = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(FinalMsg, Act10.CalculateTipPerPerson(importNum, peopleNum));
            }
            catch (FormatException)
            {
                Console.WriteLine("Error");
            }
        }
    }
}