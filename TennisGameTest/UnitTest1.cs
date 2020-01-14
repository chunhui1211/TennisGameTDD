using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TennisGameTDD;

namespace TennisGameTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void FortyLove()
        {
            var target = new TennisGame();
            target.HomePlayerScore();
            target.HomePlayerScore();
            target.HomePlayerScore();
            var actual = target.score();
            Assert.AreEqual("Forty Love", actual);
        }
        [TestMethod]
        public void ThirtyLove()
        {
            var target = new TennisGame();
            target.HomePlayerScore();
            target.HomePlayerScore();
            var actual = target.score();
            Assert.AreEqual("Thirty Love", actual);
        }
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
