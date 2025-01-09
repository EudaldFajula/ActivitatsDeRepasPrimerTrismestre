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
        public static double CalculateDegreesFare(double celsius)
        {
            return (1.8 * celsius) + 32; 
        }
    }
    public static class Act4
    {
        public static double CalculateDegreesKevin(double celsius)
        {
            return celsius + 273.15;
        }
    }
}
