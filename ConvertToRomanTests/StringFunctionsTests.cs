using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConvertToRoman.Tests
{
    [TestClass()]
    public class StringFunctionsTests
    {
        StringFunctions strFunc = new StringFunctions();

        [TestMethod()]
        public void ReplaceStringsTest_1()
        {
            var test = strFunc.ReplaceStrings("Lorem ipsum 2 dolor sit amet.");
            Assert.AreEqual("Lorem ipsum II dolor sit amet.", test.Item1);
            Assert.AreEqual(1, test.Item2);
        }

        [TestMethod()]
        public void ReplaceStringsTest_2()
        {
            var test = strFunc.ReplaceStrings("Consectetur 5 adipiscing elit 9.");
            Assert.AreEqual("Consectetur V adipiscing elit IX.", test.Item1);
            Assert.AreEqual(2, test.Item2);
        }

        [TestMethod()]
        public void ReplaceStringsTest_3()
        {
            var test = strFunc.ReplaceStrings("Ut enim quis nostrum 1904 qui.");
            Assert.AreEqual("Ut enim quis nostrum M CM IV qui.", test.Item1);
            Assert.AreEqual(1, test.Item2);
        }
    }
}