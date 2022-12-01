using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumbers
{
    public class Converter
    {
        public static string Convert(int input)
        {
            var div10 = input / 10;
            var div5 = input / 5;
            string? result;
            if (div10 == 1)
            {
                result = X(div10);
            }
            else if (div5 == 1)
            {
                var remainder = input % 5;
                result = V(div5) + I(remainder);
            }
            else if (input > 3)
            {
                result = "IV";
            }
            else
            {
                result = I(input);
            }
            return result;
        }

        private static string X(int quantity)
        {
            return Repetir('X', quantity);
        }

        private static string V(int quantity)
        {
            return Repetir('V', quantity);
        }

        private static string I(int quantity)
        {
            return Repetir('I', quantity);
        }

        private static string Repetir(char c, int quantity)
        {
            return new string(c, quantity);
        }
    }
}
