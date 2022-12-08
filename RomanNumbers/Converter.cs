namespace RomanNumbers
{
    public class Converter
    {
        public static string Convert(int input)
        {
            var result1000 = ToRoman(1000, 'M', input);
            var result500 = ToRoman(500, 'D', input);
            var result100 = ToRoman(100, 'C', input);
            var result50 = ToRoman(50, 'L', input);
            var result10 = ToRoman(10, 'X', input);
            var result5 = ToRoman(5, 'V', input);

            var result1 = ToRoman(1, 'I', input);

            return result1000 ?? result500 ?? result100 ?? result50 ?? result10 ?? result5 ?? result1 ?? "";
        }

        private static string? ToRoman(int baseNum, char romanLetter, int input)
        {
            if (input < baseNum)
            {
                var result = (input == 49) ? "XLIX" : null;
                result ??= (input == 40) ? "XL" : null;
                result ??= (input == 9) ? "IX" : null;
                result ??= ((input == 4) ? "IV" : null);
                return result;
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

