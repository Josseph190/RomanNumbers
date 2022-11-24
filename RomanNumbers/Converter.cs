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
                result = new string('X', div10);
            }
            else if (div5 == 1)
            {
                var remainder = input % 5;
                result = new string('V', div5) + new string('I', remainder);
            }
            else if (input > 3)
            {
                result = "IV";
            }
            else
            {
                result = new string('I', input);
            }
            return result;
        }
    }
}
