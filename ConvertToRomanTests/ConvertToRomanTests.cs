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

        [TestMethod()]
        public void ToRoman_5()
        {
            Assert.AreEqual("V", test.ToRomanNumber(5));
        }

        [TestMethod()]
        public void ToRoman_6()
        {
            Assert.AreEqual("VI", test.ToRomanNumber(6));
        }

        [TestMethod()]
        public void ToRoman_7()
        {
            Assert.AreEqual("VII", test.ToRomanNumber(7));
        }

        [TestMethod()]
        public void ToRoman_8()
        {
            Assert.AreEqual("VIII", test.ToRomanNumber(8));
        }

        [TestMethod()]
        public void ToRoman_9()
        {
            Assert.AreEqual("IX", test.ToRomanNumber(9));
        }

        [TestMethod()]
        public void ToRoman_10()
        {
            Assert.AreEqual("X", test.ToRomanNumber(10));
        }

        [TestMethod()]
        public void ToRoman_11()
        {
            Assert.AreEqual("XI", test.ToRomanNumber(11));
        }

        [TestMethod()]
        public void ToRoman_14()
        {
            Assert.AreEqual("XIV", test.ToRomanNumber(14));
        }

        [TestMethod()]
        public void ToRoman_15()
        {
            Assert.AreEqual("XV", test.ToRomanNumber(15));
        }

        [TestMethod()]
        public void ToRoman_39()
        {
            Assert.AreEqual("XXXIX", test.ToRomanNumber(39));
        }

        [TestMethod()]
        public void ToRoman_40()
        {
            Assert.AreEqual("XL", test.ToRomanNumber(40));
        }

        [TestMethod()]
        public void ToRoman_49()
        {
            Assert.AreEqual("XLIX", test.ToRomanNumber(49));
        }

        [TestMethod()]
        public void ToRoman_50()
        {
            Assert.AreEqual("L", test.ToRomanNumber(50));
        }

        [TestMethod()]
        public void ToRoman_88()
        {
            Assert.AreEqual("LXXXVIII", test.ToRomanNumber(88));
        }

        [TestMethod()]
        public void ToRoman_125()
        {
            Assert.AreEqual("CXXV", test.ToRomanNumber(125));
        }

        [TestMethod()]
        public void ToRoman_255()
        {
            Assert.AreEqual("CCLV", test.ToRomanNumber(255));
        }

        [TestMethod()]
        public void ToRoman_301()
        {
            Assert.AreEqual("CCCI", test.ToRomanNumber(301));
        }
    }
}