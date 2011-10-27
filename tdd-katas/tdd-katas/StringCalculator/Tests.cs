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
    }
}