using BibliotecaActRepas;
using System; 

namespace ActRepas
{
    public static class Activitats
    {
        public static void Main()
        {
            const string MsgOriginalPrice = "The original price is: ";
            const string MsgDiscountPrice = "The discount price is: ";
            const string FinalMsg = "The discount is: {0}%";
            double originalPrice, discountPrice;
            Console.WriteLine(MsgOriginalPrice);
            originalPrice = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(MsgDiscountPrice);
            discountPrice = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(FinalMsg, Act6.Discount(originalPrice, discountPrice));
        }
    }
}