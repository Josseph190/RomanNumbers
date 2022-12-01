namespace RomanNumbers
{
    public class Converter
    {
        private static (char romanLetter, int remainder)[] rCV = { ('M', 1000), ('D', 500), ('C', 100), ('L', 50), ('X', 10), ('V', 5), ('I', 1) };
        public static string Convert(int input, (char, int)[]? nextRCV = null)
        {
            return Iterate(nextRCV ?? rCV, input) ?? "";
        }

        private static string? Iterate(IEnumerable<(char, int)> nextRCV, int? input)
        {
            var first = nextRCV.FirstOrDefault();
            var next = nextRCV.Skip(1).FirstOrDefault();
            var (result, remainder) = ToRoman(first, next, input);
            return result + Iterate(nextRCV.Skip(1), remainder);
        }

        private static (string? result, int? remainder) ToRoman((char romanLetter, int baseNum) first, (char romanLetter, int baseNum) next, int? input)
        {
            (string? letter, int? remainder) result1 = (string.Empty, null);
            if (input >= first.baseNum - next.baseNum) {
                result1 = (LetterString(next.romanLetter, 1),0);
            }
           var  result2 = input.HasValue && input >= first.baseNum 
                ? (letters: LetterString(first.romanLetter, input.Value / first.baseNum), remainder: input.Value % first.baseNum)
                : ((string ? letters, int? remainder))(null, null);

            return (result1.letter + result2.letters, result2.remainder);
        }

        private static string LetterString(char c, int quantity) => new string(c, quantity);
    }
}

