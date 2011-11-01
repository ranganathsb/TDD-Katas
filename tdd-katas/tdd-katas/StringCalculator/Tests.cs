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

        [Test]
        public void Add_WhenGivenOneNumber_ShouldReturnThatNumber()
        {
            //Arrange
            var number = "1";

            //Act
            var result = Calculator.Add(number);

            //Assert
            Assert.That(result, Is.EqualTo(1));
        }
        
    }
}