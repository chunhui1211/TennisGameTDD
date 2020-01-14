using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TennisGameTDD;

namespace TennisGameTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void FifteenLove()
        {
            var target = new TennisGame();
            target.HomePlayerScore();
            var actual = target.score();
            Assert.AreEqual("Fifteen Love", actual);
        }
        [TestMethod]
        public void LoveAll()
        {
            var target = new TennisGame();
            var actual = target.score();
            Assert.AreEqual("Love All", actual);
        }
    }
}
