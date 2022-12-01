namespace RomanNumbers
{
    public class Converter
    {
        private static (char, int)[] rCV = { ('M', 1000), ('D', 500), ('C', 100), ('L', 50), ('X', 10), ('V', 5), ('I', 1) };
        public static string Convert(int input, (char, int)[]? rcV1 = null)
        {
            rcV1 = rcV1 ?? rCV;

            var result1000 = ToRoman('M', 1000, input);
            var result500 = ToRoman('D', 500, input);
            var result100 = ToRoman('C', 100, input);
            var result50 = ToRoman('L', 50, input);
            var result10 = ToRoman('X', 10, input);
            var result5 = ToRoman('V', 5, input);
            var result4 = (input > 3) ? "IV" : null;
            var result1 = ToRoman('I', 1, input);

            return result1000 ?? result500 ?? result100 ?? result50 ?? result10 ?? result5 ?? result4 ?? result1 ?? "";
        }

        private static string? ToRoman(char romanLetter, int baseNum, int input)
        {
            if (input < baseNum)
            {
                return null;
            }
            else
            {
                return Repetir(romanLetter, input / baseNum) + Convert(input % baseNum);
            }
        }

        private static string Repetir(char c, int quantity) => new string(c, quantity);
    }
}

