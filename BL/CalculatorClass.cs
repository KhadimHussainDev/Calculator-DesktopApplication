using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.BL
{
    internal class CalculatorClass
    {
        private static string oprand1="";
        private static string oprand2="";
        private static char op=' ';

        public static char Op { get => op; set => op = value; }
        public static string Oprand1 { get => oprand1; set => oprand1 = value; }
        public static string Oprand2 { get => oprand2; set => oprand2 = value; }

        public static float CalculateAnswer()
        {
            float value1 = float.Parse(Oprand1);
            float value2 = float.Parse(Oprand2);
            if (op == '*')
            {
                return value1 * value2;
            }
            else if (op == '/')
            {
                return value1 / value2;
            }
            else if (op == '+')
            {
                return value1 + value2;
            }
            else if (op == '-')
            {
                return value1 - value2;
            }
            return 0;
        }
    }
}
