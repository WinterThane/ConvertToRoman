using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConvertToRoman.Tests
{
    [TestClass()]
    public class ConvertToRomanTests
    {
        ConvertToRoman test = new ConvertToRoman();

        [TestMethod()]
        public void ToRoman_1()
        {
            Assert.AreEqual("I", test.ToRomanNumber(1));
        }

        [TestMethod()]
        public void ToRoman_2()
        {
            Assert.AreEqual("II", test.ToRomanNumber(2));
        }

        [TestMethod()]
        public void ToRoman_3()
        {
            Assert.AreEqual("III", test.ToRomanNumber(3));
        }

        [TestMethod()]
        public void ToRoman_4()
        {
            Assert.AreEqual("IV", test.ToRomanNumber(4));
        }
    }
}