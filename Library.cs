using System;

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
    public static class Act7
    {
        public static string ChangeNumHexaToLetter(int num)
        {
            //Change the num to the defined char if needed to
            if (num == 10)
            {
                return "A";
            } else if (num == 11)
            {
                return "B";
            } else if (num == 12)
            {
                return "C";
            } else if (num == 13)
            {
                return "D";
            } else if (num == 14)
            {
                return "E";
            } else if (num == 15)
            {
                return "F";
            }
            else
            {
                return num.ToString();
            }
        }
        public static string[] ChangeDecimalToHexa(int decimalNum)
        {
            //Create a variable with the lenght of the number
            int lenghtNum = decimalNum.ToString().Length;
            //Create a list where the hexadecimal number will go
            string[] hexadecimalNum = new string[lenghtNum];
            //Create variable that we will use it for save the remainer of the division
            int remainer;
            for (int i = decimalNum; i > 0; i = i / 16)
            {
                lenghtNum = lenghtNum - 1;
                remainer = i % 16;
                hexadecimalNum[lenghtNum] = ChangeNumHexaToLetter(remainer);
            }
            return hexadecimalNum;
        }
    }
    public static class Act8
    {
        public static bool AnalizeLettersPostalCode(string postalCode)
        {
            char[] alpahabet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            for (int i = 0; i < alpahabet.Length; i++)
            {
                if (postalCode.ToLower().Contains(alpahabet[i]))
                {
                    return true;
                }
            }
            return false;
        }
        public static bool AnalizeGeneralPostalCode(string postalCode)
        {
            if(postalCode.Length == 5)
            {
                if (AnalizeLettersPostalCode(postalCode))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return false;
            }
        }
    }
    public static class Act9
    {
        public static double CalculateTip(double importNum)
        {
            return importNum * 0.20;
        }
    }
    public static class Act10
    {
        public static double CalculateTipPerPerson(double importNum, int peopleNum)
        {
            return (importNum * 0.20) / peopleNum;
        }
    }
}
