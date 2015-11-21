using NUnit.Framework;
using System;

namespace FizzBuzzTests
{
    [TestFixture ()]
    public class DivisibleByThree
    {
        private FizzBuzz fizzbuzz = new FizzBuzz ();

        [Test ()]
        public void ShouldKnowThatThreeIsDivisibleByThree ()
        {
            Assert.IsTrue (fizzbuzz.IsDivisibleByThree (3));
        }

        [Test ()]
        public void ShouldKnowThatOneIsNotDivisibleByThree ()
        {
            Assert.IsFalse (fizzbuzz.IsDivisibleByThree (1));
        }
    }

    [TestFixture ()]
    public class DivisibleByFive
    {
        private FizzBuzz fizzbuzz = new FizzBuzz ();

        [Test ()]
        public void ShouldKnowThatFiveIsDivisibleByFive ()
        {
            Assert.IsTrue (fizzbuzz.IsDivisibleByFive (5));
        }

        [Test ()]
        public void ShouldKnowThatOneIsNotDivisibleByFive ()
        {
            Assert.IsFalse (fizzbuzz.IsDivisibleByFive (1));
        }
    }
}