using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProj
{
    //Экземпляр этого класса создавать не можем, static
    public static class MathFunction
    {
        public static double Summa(double firstValue, double secondValue)
        {
            return firstValue + secondValue;
        }
        public static double Substract(double firstValue, double secondValue)
        {
            return firstValue - secondValue;
        }
        public static double Divide(double firstValue, double secondValue)
        {
            if (secondValue == 0)
                return 0;
            return firstValue / secondValue;
        }
        public static double Multiply(double firstValue, double secondValue)
        {
            return firstValue * secondValue;
        }
        public static double Percent(double firstValue, double secondValue, string str)
        {
            switch(str)
            {
                case "+":
                    return (firstValue * (firstValue + secondValue)) / 100;
                case "-":
                    return (firstValue * (firstValue + secondValue)) / 100;
                case "ˣ":
                    return (firstValue *  secondValue) / 100;
                case "/":
                    return (firstValue * secondValue) / 100;
            }
            return 0;
        }
        public static double Fruction(double firstValue)
        {
            return 1 / firstValue;
        }
    }
}
