using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingGameKata
{
    [TestFixture]
    public class TestBowling
    {
        [Test]
        public void AllZero()
        {
            List<int> pins = new List<int>
            {
                0,0,  0,0,  0,0,  0,0,  0,0,
                0,0,  0,0,  0,0,  0,0,  0,0
            };

            Assert.That(Game.GetScore(pins), Is.EqualTo(0));
        }

        [Test]
        public void AllOnes()
        {
            List<int> pins = new List<int>
            {
                1,1,  1,1,  1,1,  1,1,  1,1,
                1,1,  1,1,  1,1,  1,1,  1,1
            };

            Assert.That(Game.GetScore(pins), Is.EqualTo((1 + 1) * 10));
        }

        [Test]
        public void OneStrike()
        {
            List<int> pins = new List<int>
            {
                10,0,  1,1,  1,1,  1,1,  1,1,
                1,1,   1,1,  1,1,  1,1,  1,1
            };

            Assert.That(Game.GetScore(pins), Is.EqualTo(
                (10 + 1 + 1) + (1 + 1) * 9));
        }
        [Test]
        public void HalfStrike()
        {
            List<int> pins = new List<int>
            {
                5,5,  1,1,  1,1,  1,1,  1,1,
                1,1,   1,1,  1,1,  1,1,  1,1
            };

            Assert.That(Game.GetScore(pins), Is.EqualTo(
                (10 + 1) + (1 + 1) * 9));
        }
        [Test]
        public void HalfOneStrike()
        {
            List<int> pins = new List<int>
            {
                0,5,  5,1,  1,1,  1,1,  1,1,
                1,1,   10,0,  1,1,  1,1,  1,1
            };

            Assert.That(Game.GetScore(pins), Is.EqualTo(
                (5 + 1 + 5) + (1 + 1) * 7 + 10 + 1 + 1));
        }
        [Test]
        public void TwoStrike()
        {
            List<int> pins = new List<int>
            {
                10,0,  10,0,  1,1,  1,1,  1,1,
                1,1,   1,1,  1,1,  1,1,  1,1
            };

            Assert.That(Game.GetScore(pins), Is.EqualTo(
                (10 + 10 + 1 + 10 + 1 + 1) + (1 + 1) * 8));
        }
        [Test]
        public void Strikeandhalf()
        {
            List<int> pins = new List<int>
            {
                10,0,  0,10,  1,1,  1,1,  1,1,
                1,1,   1,1,  1,1,  1,1,  1,1
            };

            Assert.That(Game.GetScore(pins), Is.EqualTo(
                (10 + 10 + 10 + 1) + (1 + 1) * 8));
        }
        [Test]
        public void TenStrike()
        {
            List<int> pins = new List<int>
            {
                10,0,  0,10,  1,1,  1,1,  1,1,
                1,1,   1,1,  1,1,  1,1,  10,10,10
            };

            Assert.That(Game.GetScore(pins), Is.EqualTo(
                (10 + 10 + 10 + 1) + (1 + 1) * 7 + 30));
        }



    }
}
