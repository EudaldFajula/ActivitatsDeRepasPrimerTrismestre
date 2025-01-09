using BibliotecaActRepas;
using System; 

namespace ActRepas
{
    public static class Activitats
    {
        public static void Main()
        {
            const string BaseMsg = "Introduce the base of the triangle";
            const string HeightMsg = "Introcude the height of the triangle";
            const string ResultMsg = "This is the area of the triangle: {0}";
            int baseNum, heightNum;
            Console.WriteLine(BaseMsg);
            baseNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(HeightMsg);
            heightNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(ResultMsg, Act2.CalculateAreaTriangle(baseNum, heightNum));
        }
    }
}