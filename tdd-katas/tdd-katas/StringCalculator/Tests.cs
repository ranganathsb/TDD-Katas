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

        [TestCase("1,2", 3)]
        [TestCase("5,9", 14)]
        [TestCase("12,12", 24)]
        [TestCase("296,3", 299)]
        [TestCase("1,2,3,4,5,6,7,8,9,10", 55)]
        [Test]
        public void Add_WhenGivenMultipleNumbers_ReturnsSumOfNumbers(string input, int expectation)
        {
            var result = Calculator.Add(input);

            Assert.That(result, Is.EqualTo(expectation));
        }

        [TestCase("1\n2", 3)]
        [TestCase("5\n9", 14)]
        [TestCase("12\n12", 24)]
        [TestCase("296\n3", 299)]
        [TestCase("1\n2\n3\n4\n5\n6\n7\n8\n9\n10", 55)]
        [Test]
        public void Add_WhenGivenNewLine_UsesThatAsDelimiterInsteadOfComma(string input, int expectation)
        {
            var result = Calculator.Add(input);

            Assert.That(result, Is.EqualTo(expectation));
        }
    }
}