using NUnit.Framework;
using System;

namespace FizzBuzzTests
{
    [TestFixture ()]
    public class FizzBuzzTest
    {
        [Test ()]
        public void ShouldKnowThatThreeIsDivisibleByThree ()
        {
            FizzBuzz fizzbuzz = new FizzBuzz ();
            Assert.IsTrue (fizzbuzz.IsDivisibleByThree (3));
        }

        [Test ()]
        public void ShouldKnowThatOneIsNotDivisibleByThree ()
        {
            FizzBuzz fizzbuzz = new FizzBuzz ();
            Assert.IsFalse (fizzbuzz.IsDivisibleByThree (1));
        }
    }
}