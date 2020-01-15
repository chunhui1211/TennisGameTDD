using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TennisGameTDD;

namespace TennisGameTest
{
    [TestClass]
    public class UnitTest1
    {
        private TennisGame _target;
        public UnitTest1()
        {
            _target = new TennisGame();
        }
        [TestMethod]
        public void LoveFifteen()
        {
            _target.AwayPlayerScore();
            var actual = _target.score();
            Assert.AreEqual("Love Fifteen", actual);
        }
        [TestMethod]
        public void FortyLove()
        {
            GivenHomePlayerScore(3);
            var actual = _target.score();
            Assert.AreEqual("Forty Love", actual);
        }
        [TestMethod]
        public void ThirtyLove()
        {
            GivenHomePlayerScore(2);
            var actual = _target.score();
            Assert.AreEqual("Thirty Love", actual);
        }
        [TestMethod]
        public void FifteenLove()
        {
            _target.HomePlayerScore();
            var actual = _target.score();
            Assert.AreEqual("Fifteen Love", actual);
        }
        [TestMethod]
        public void LoveAll()
        {
            var actual = _target.score();
            Assert.AreEqual("Love All", actual);
        }
        private void GivenHomePlayerScore(int times)
        {
            for (var i = 0; i < times; i++)
            {
                _target.HomePlayerScore();
            }
        }
        
    }
}
