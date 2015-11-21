using NUnit.Framework;
using System;

namespace FizzBuzzTests
{
    [TestFixture ()]
    public class FizzBuzzTest
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
}