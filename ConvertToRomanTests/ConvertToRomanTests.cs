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
    }
}