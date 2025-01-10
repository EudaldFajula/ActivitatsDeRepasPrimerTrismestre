namespace BibliotecaActRepas
{
    public static class Act1
    {
        public static int ChangeSecToHour(int sec)
        {
            return sec / 3600;
        }
        public static int ChangeHourToMin(int sec, int hour)
        {
            return (sec - hour * 3600) / 60;
        }
        public static int ChangeToSec(int sec, int hour, int min)
        {
            return sec - (hour * 3600 + min * 60);
        }
    }
    public static class Act2
    {
        public static int CalculateAreaTriangle(int baseNum, int heightNum)
        {
            return (baseNum * heightNum) / 2;
        }
    }
    public static class Act3
    {
        public static double CalculateDegreesCelsiusToFare(double celsius)
        {
            return (1.8 * celsius) + 32; 
        }
    }
    public static class Act4
    {
        public static double CalculateDegreesCelsiusToKelvin(double celsius)
        {
            return celsius + 273.15;
        }
    }
    public static class Act5
    {
        public static double CalculateDegreesKelvinToCelsius(double kelvin)
        {
            return ((kelvin - 273.15) * 1.8) + 32;
        }
    }
    public static class Act6
    {
        public static double Discount(double originalPrice, double discountPrice)
        {
            return ((originalPrice - discountPrice) / originalPrice) * 100;
        }
    }
}
