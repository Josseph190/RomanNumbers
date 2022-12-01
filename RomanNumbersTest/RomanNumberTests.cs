namespace RomanNumbersTest
{
    //https://kata-log.rocks/roman-numerals-kata
    [TestClass]
    public class RomanNumberTests
    {
        [TestMethod]
        public void Roman1()
        {
            var input = 1;
            var expected = "I";
            var result = RomanNumbers.Converter.Convert(input);
            Assert.AreEqual(expected, result);  
        }

        [TestMethod]
        public void Roman2()
        {
            var input = 2;
            var expected = "II";
            var result = RomanNumbers.Converter.Convert(input);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Roman5()
        {
            var input = 5;
            var expected = "V";
            var result = RomanNumbers.Converter.Convert(input);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Roman10()
        {
            var input = 10;
            var expected = "X";
            var result = RomanNumbers.Converter.Convert(input);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Roman4()
        {
            var input = 4;
            var expected = "IV";
            var result = RomanNumbers.Converter.Convert(input);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Roman6()
        {
            var input = 6;
            var expected = "VI";
            var result = RomanNumbers.Converter.Convert(input);
            Assert.AreEqual(expected, result);
        }


		[TestMethod]
		public void Roman50()
		{
			var input = 50;
			var expected = "L";
			var result = RomanNumbers.Converter.Convert(input);
			Assert.AreEqual(expected, result);
		}

		[TestMethod]
		public void Roman100()
		{
			var input = 100;
			var expected = "C";
			var result = RomanNumbers.Converter.Convert(input);
			Assert.AreEqual(expected, result);
		}
	}
}