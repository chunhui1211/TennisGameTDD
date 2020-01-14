using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TennisGameTDD;

namespace TennisGameTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void LoveAll()
        {
            var target = new TennisGame();
            var actual = target.score();
            Assert.AreEqual("Love All", actual);
        }
    }
}
