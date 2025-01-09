using BibliotecaActRepas;
using System; 

namespace ActRepas
{
    public class Activitats
    {
        public static void Main()
        {
            const string Msg = "Enter how many seconds";
            int sec;
            Console.WriteLine(Msg);
            sec = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{Act1.ChangeSecToHour(sec)} hour {Act1.ChangeHourToMin(sec, Act1.ChangeSecToHour(sec))} minute {Act1.ChangeToSec(sec, Act1.ChangeSecToHour(sec), Act1.ChangeHourToMin(sec, Act1.ChangeSecToHour(sec)))} seconds");
        }
    }
}