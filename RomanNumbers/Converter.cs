namespace RomanNumbers
{
    public class Converter
    {
        public static string? Convert(int input)
        {
            if (input <= 0)
            {
                return null;
            }

            var result1000 = ToRoman(1000, 'M', 100000, 'J', 100000, 'K', input);
            string? result900 = ToRoman(900, "CM", input);
            var result500 = ToRoman(500, 'D', 1000, 'M', 100000, 'N', input);
            
            var result100 = ToRoman(100, 'C', 500, 'D', 1000, 'M', input);
            string? result90 = ToRoman(90, "XC", input);
            var result50 = ToRoman(50, 'L', 100, 'C', 100, 'C', input);
            
            var result10 = ToRoman(10, 'X', 50, 'L', 100, 'C', input);
            string? result9 = ToRoman(9, "IX", input);
            var result5 = ToRoman(5, 'V', 10, 'X', 10, 'X', input);
            
            var result1 = ToRoman(1, 'I', 5, 'V', 10, 'X', input);

            return result1000 ?? result900 ?? result500  ?? result100 ?? result90 ?? result50 ?? result10 ?? result9 ?? result5 ??  result1 ?? "";

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
        private static string? ToRoman(int baseNum, char romanLetter, int prevBaseNum, char prevRomanLetter, int prev2BaseNum, char prev2RomanLetter,  int input)
        {
            if (input < baseNum)
            {
                return null;
            }
            else
            {
                var quotient = input / baseNum;
                if (quotient <= 3)
                {
                    var remainder = input % baseNum;
                    return Repetir(romanLetter, quotient) + Convert(remainder);
                }
                else if (quotient == 4)
                {
                    var input1 = input - (prevBaseNum - baseNum);
                    var remainder = input1 % baseNum;
                    return romanLetter.ToString() + prevRomanLetter.ToString() + Convert(remainder);
                }
                else if (quotient == 9)
                {
                    var input1 = input - (prev2BaseNum - baseNum);
                    var remainder = input1 % baseNum;
                    return romanLetter.ToString() + prev2RomanLetter.ToString() + Convert(remainder);
                }
            }
            return null;
        }

        private static string Repetir(char c, int quantity) => new string(c, quantity);
    }
}

