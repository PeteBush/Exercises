﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class FizzBuzzTests
    {
        [TestMethod]
        public void GoFizz()
        {
            //Arrange
            FizzBuzz fizzBuzz = new FizzBuzz();

            //Act

            //Assert
            Assert.AreEqual("1", fizzBuzz.GoFizz(1));
            Assert.AreEqual("Buzz", fizzBuzz.GoFizz(10));
            Assert.AreEqual("Fizz", fizzBuzz.GoFizz(3));
            Assert.AreEqual("Buzz", fizzBuzz.GoFizz(5));
            Assert.AreEqual("FizzBuzz", fizzBuzz.GoFizz(15));
            Assert.AreEqual("FizzBuzz", fizzBuzz.GoFizz(30));
        }

        [TestMethod]
        public void HighLow()
        {
            //Arrange
            HighAndLow highAndLow = new HighAndLow();

            //Assert
            Assert.AreEqual("2 1", highAndLow.HighLow("1 2"));
            Assert.AreEqual("9 1", highAndLow.HighLow("3 1 5 9 7"));
            Assert.AreEqual("9782 -5", highAndLow.HighLow("2343 4561 9782 12 3456 -5"));
        }
    }
}
