namespace RomanNumbers
{
    public class Converter
    {
        public static string Convert(int input)
        {
            var result1000 = ToRoman(1000, 'M', input);
            var result900 = ToRoman(900, "CM", input);
            var result500 = ToRoman(500, 'D', input);
            var result400 = ToRoman(400, "CD", input);
            var result100 = ToRoman(100, 'C', input);
            var result90 = ToRoman(90, "XC", input);
            var result50 = ToRoman(50, 'L', input);
            var result40 = ToRoman(40, "XL", input);
            var result10 = ToRoman(10, 'X', input);
            var result9 = ToRoman(9, "IX", input);
            var result5 = ToRoman(5, 'V', input);
            var result4 = ToRoman(4, "IV", input);
            var result1 = ToRoman(1, 'I', input);

            return result1000 ?? result900 ?? result500 ?? result400 ?? result100 ?? result90 ?? result50 ?? result40 ?? result10 ?? result9 ?? result5 ?? result4 ?? result1 ?? "";
        }

        private static string? ToRoman(int baseNum, string romanLetter, int input)
        {
            if (input >= baseNum)
            {
                var remainder = input % baseNum;
                return romanLetter + Convert(remainder);
            }
            else
            {
                return null;
            }
        }
        private static string? ToRoman(int baseNum, char romanLetter, int input)
        {
            if (input < baseNum)
            {
                return null;
            }
            else
            {
                var quotient = input / baseNum;
                var remainder = input % baseNum;
                return Repetir(romanLetter, quotient) + Convert(remainder);
            }
        }

        private static string Repetir(char c, int quantity) => new string(c, quantity);
    }
}

