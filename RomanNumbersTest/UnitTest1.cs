namespace RomanNumbersTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var input = 1;
            var expected = "I";
            var result = RomanNumbers.Converter.Convert(input);
            Assert.AreEqual(expected, result);  
        }

        [TestMethod]
        public void TestMethod2()
        {
            var input = 2;
            var expected = "II";
            var result = RomanNumbers.Converter.Convert(input);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestMethod3()
        {
            var input = 5;
            var expected = "V";
            var result = RomanNumbers.Converter.Convert(input);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestMethod4()
        {
            var input = 10;
            var expected = "X";
            var result = RomanNumbers.Converter.Convert(input);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestMethod5()
        {
            var input = 4;
            var expected = "IV";
            var result = RomanNumbers.Converter.Convert(input);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestMethod6()
        {
            var input = 6;
            var expected = "VI";
            var result = RomanNumbers.Converter.Convert(input);
            Assert.AreEqual(expected, result);
        }
    }
}