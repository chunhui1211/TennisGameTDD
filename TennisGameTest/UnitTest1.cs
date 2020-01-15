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
        public void AwayAdv()
        {
            GivenHomePlayerScore(3);
            GivenAwayPlayerScore(4);
            var actual = _target.score();
            Assert.AreEqual("Tom Adv", actual);
        }
        [TestMethod]
        public void HomeAdv()
        {
            GivenHomePlayerScore(4);
            GivenAwayPlayerScore(3);
            var actual = _target.score();
            Assert.AreEqual("John Adv", actual);
        }
        [TestMethod]
        public void Deuce_4_4()
        {
            GivenHomePlayerScore(4);
            GivenAwayPlayerScore(4);
            var actual = _target.score();
            Assert.AreEqual("Deuce", actual);
        }
        [TestMethod]
        public void Deuce()
        {
            GivenHomePlayerScore(3);
            GivenAwayPlayerScore(3);
            var actual = _target.score();
            Assert.AreEqual("Deuce", actual);
        }
        [TestMethod]
        public void ThirtyAll()
        {
            GivenHomePlayerScore(2);
            GivenAwayPlayerScore(2);
            var actual = _target.score();
            Assert.AreEqual("Thirty All", actual);
        }
        [TestMethod]
        public void FifteenAll()
        {
            _target.HomePlayerScore();
            _target.AwayPlayerScore();
            var actual = _target.score();
            Assert.AreEqual("Fifteen All", actual);
        }
        [TestMethod]
        public void LoveThirty()
        {
            GivenAwayPlayerScore(2);
            var actual = _target.score();
            Assert.AreEqual("Love Thirty", actual);
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
        private void GivenAwayPlayerScore(int times)
        {
            for (var i = 0; i < times; i++)
            {
                _target.AwayPlayerScore();
            }
        }

    }
}
