using System;
using NUnit.Framework;

namespace tdd_katas.StringCalculator
{
    [TestFixture]
    public class Tests
    {
        [TestCase("")]
        [TestCase(null)]
        [Test]
        public void Add_WhenGivenEmptyStringOrNull_ReturnsZero(string input)
        {
            var result = Calculator.Add(input);

            Assert.That(result, Is.EqualTo(0));
        }

        [TestCase("1", 1)]
        [TestCase("5", 5)]
        [TestCase("12", 12)]
        [TestCase("296", 296)]
        [Test]
        public void Add_WhenGivenOneNumber_ReturnsThatNumber(string input, int expectation)
        {
            var result = Calculator.Add(input);

            Assert.That(result, Is.EqualTo(expectation));
        }
    }
}