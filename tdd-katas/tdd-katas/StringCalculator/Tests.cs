using System;
using NUnit.Framework;

namespace tdd_katas.StringCalculator
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Add_WhenGivenEmptyString_ShouldReturnZero()
        {
            //Arrange
            
            //Act
            var result = Calculator.Add(string.Empty);

            //Assert
            Assert.That(result, Is.EqualTo(0));
        }

        [TestCase("100", 100)]
        [TestCase("10", 10)]
        [TestCase("1", 1)]
        [Test]
        public void Add_WhenGivenOneNumber_ShouldReturnThatNumber(string input, int expected)
        {
            //Arrange
            
            //Act
            var result = Calculator.Add(input);

            //Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase("100,101", 201)]
        [TestCase("10,11", 21)]
        [TestCase("1,2", 3)]
        [Test]
        public void Add_WhenGivenTwoNumbers_ShouldReturnSumOfTwoNumbers(string input, int expected)
        {
            //Arrange

            //Act
            var result = Calculator.Add(input);

            //Assert
            Assert.That(result, Is.EqualTo(expected));
        }
        
    }
}