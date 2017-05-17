using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Collections;

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
        [TestMethod]
        public void RemoveNoise()
        {

            //Arrange
            RemoveNoise removeNoise = new RemoveNoise();

            //Assert
            Assert.AreEqual("hello world", removeNoise.RemovNoise("h%e&·%$·llo w&%or&$l·$%d"));
        }
        [TestMethod]
        public void MostFrequentDigitSum()
        {

            //Arrange
            MostFrequentDigit mostFrequentDigit = new MostFrequentDigit();

            Assert.AreEqual(9, mostFrequentDigit.MostFrequentDigitSum(88));
            Assert.AreEqual(8, mostFrequentDigit.MostFrequentDigitSum(8));
            Assert.AreEqual(1, mostFrequentDigit.MostFrequentDigitSum(1));
        }
        [TestMethod]
        public void GetDriverLicense()
        {
            //Arrange
            DriversLicense driverLicense = new DriversLicense();

            //Assert
            Assert.AreEqual(false, driverLicense.GetDriversLicense(16, 20, false, true));
            Assert.AreEqual(false, driverLicense.GetDriversLicense(16, 50, false, false));
            Assert.AreEqual(true, driverLicense.GetDriversLicense(16, 50, true, true));
            Assert.AreEqual(true, driverLicense.GetDriversLicense(18, 0, true, true));
        }
        [TestMethod]
        public void LateArrival()
        {
            //Arrange
            Arrival arrival = new Arrival();

            //Asswert
            Assert.AreEqual(true, arrival.LateArrival(20, 10, 60));
            Assert.AreEqual(true, arrival.LateArrival(20, 20, 60));
            Assert.AreEqual(false, arrival.LateArrival(40, 60, 50));
            Assert.AreEqual(true, arrival.LateArrival(30, 5, 10));
        }
        [TestMethod]
        public void NeedsECheck()
        {
            //Arrange
            ECheck eCheck = new ECheck();

            //Assert
            Assert.AreEqual(true, eCheck.NeedsECheck(2017, 2011));
            Assert.AreEqual(true, eCheck.NeedsECheck(2016, 2004));
            Assert.AreEqual(false, eCheck.NeedsECheck(2011, 2012));
            Assert.AreEqual(false, eCheck.NeedsECheck(2011, 1992));
        }

        [TestMethod]
        public void HighestOdd()
        {
            //Arrange
            HighOdd highOdd = new HighOdd();

            //Assert
            Assert.AreEqual(0, highOdd.HighestOdd(new int[] { }));
            Assert.AreEqual(0, highOdd.HighestOdd(new int[] { 2, 10 }));
            Assert.AreEqual(7, highOdd.HighestOdd(new int[] { 3, 7, 8 }));
        }
        [TestMethod]
        public void SecondHighest()
        {
            //Arrange
            SecHighest secHighest = new SecHighest();

            //Assert
            Assert.AreEqual(0, secHighest.SecondHighest(new int[] { }));
            Assert.AreEqual(1, secHighest.SecondHighest(new int[] { 1 }));
            Assert.AreEqual(3, secHighest.SecondHighest(new int[] { 1, 3, 5 }));
            Assert.AreEqual(3, secHighest.SecondHighest(new int[] { 1, 3, 3, 3 }));
            Assert.AreEqual(13, secHighest.SecondHighest(new int[] { 1, 4, 6, 8, 23, 13 }));
            Assert.AreEqual(99, secHighest.SecondHighest(new int[] { 99, 43, 72, 109, 54, 21, -74 }));
            Assert.AreEqual(99, secHighest.SecondHighest(new int[] { 99, 43, 72, 109, 99, 21, 99 }));
            Assert.AreEqual(109, secHighest.SecondHighest(new int[] { 109, 43, 72, 109, 54, 109, 99 - 74 }));
        }
        [TestMethod]
        public void FindSmallestInt()
        {
            //Arrange
            Lowest lowest = new Lowest();

            //Assert
            Assert.AreEqual(11, lowest.FindLowestInt(new int[] { 34, 190, 3890, 11, 23, 76 }));
        }
        [TestMethod]
        public void AlternatingCase()
        {
            //Arrange
            AltCase altCase = new AltCase();

            //Assert
            Assert.AreEqual("hello world", altCase.ToAlternatingCase("HELLO WORLD"));
            Assert.AreEqual("HELLO WORLD", altCase.ToAlternatingCase("hello world"));
            Assert.AreEqual("hElLo WoRlD", altCase.ToAlternatingCase("HeLlO wOrLd"));
        }
        [TestMethod]
        public void Palindrome()
        {
            // Arrange
            Palindrome palindrome = new Palindrome();

            //Assert
            Assert.AreEqual(4, palindrome.palindromeChainLength(87));

        }
        [TestMethod]
        public void Survivor()
        {
            //Arrange
            Survivor survivor = new Survivor();

            //Assert
            Assert.AreEqual(4, survivor.JosSurvivor(7, 3));
            Assert.AreEqual(28, survivor.JosSurvivor(40, 3));
            Assert.AreEqual(265, survivor.JosSurvivor(300, 300));
            Assert.AreEqual(10, survivor.JosSurvivor(11, 19));

        }
        [TestMethod]
        public void EqualSides()
        {
            //Arrange
            EqualSides equalSides = new EqualSides();

            //Assert
            Assert.AreEqual(2, equalSides.EqualSidesOfAnArray(new int[] { 1, 2, 1, 2, 1 }));
            Assert.AreEqual(1, equalSides.EqualSidesOfAnArray(new int[] { 21, 1, 12, 8, 1 }));
            Assert.AreEqual(3, equalSides.EqualSidesOfAnArray(new int[] { 99, -9, 10, 2, 100 }));
        }


        [TestMethod]
        public void RemoveRepeats()
        {
            //Arrange
            RemoveRepeating removeRepeating = new RemoveRepeating();

            //Assert
            Assert.AreEqual("ABCDAB", removeRepeating.Remove("AAAABBBCCDAABBB"));
            Assert.AreEqual("ABCDAB", removeRepeating.Remove("AAAABBBCCDAAB"));
            Assert.AreEqual("ABCDA", removeRepeating.Remove("AAAABBBCCDAA"));
            Assert.AreEqual("ABCDAz", removeRepeating.Remove("AAAABBBCCDAAz"));
            Assert.AreEqual("Helo", removeRepeating.Remove("Hello"));
        }

        [TestMethod]
        public void UniqueOnly()
        {
            //Arrange
            UniqueOnly uniqueOnly = new UniqueOnly();



            //Assert
            CollectionAssert.AreEqual(new int[] { 1, 2, 3, 4, 5, 6 }, uniqueOnly.RemoveDuplicates(new int[] { 1, 2, 1, 4, 4, 1, 2, 5, 6, 3 }));
        }
        [TestMethod]
        public void CountDuplicates()
        {
            //Arrange
            CountDuplicates countDuplicates = new CountDuplicates();

            //Assert
            Assert.AreEqual(2, countDuplicates.Count("aabbcde"));
            Assert.AreEqual(2, countDuplicates.Count("aabbcdeB"));
            Assert.AreEqual(0, countDuplicates.Count("abcde"));
            Assert.AreEqual(1, countDuplicates.Count("indivisibility"));
        }
        [TestMethod]
        public void IntCount()
        {

            CountInt intCount = new CountInt();
            Dictionary<int, int> expected = new Dictionary<int, int>()
            {
                {1, 2 },
                {44, 1 },
                {55, 1 },
                {63, 3 },
                {77, 1 },
                {99, 2 }
            };

            CollectionAssert.AreEqual(expected, intCount.IntCount(new int[] { 1, 99, 63, 1, 55, 77, 63, 99, 63, 44 }));
        }
        [TestMethod]
        public void ConsolidateInventory()
        {
            Dictionary<string, int> expected = new Dictionary<string, int>()
            {
                {"SKU1", 100 },
                {"SKU2", 64 },
                {"SKU3", 44 },
                {"SKU4", 5 }
            };

            Exercises exercises = new Exercises();
            Dictionary<string, int> actual = exercises.ConsolidateInventory(

                new Dictionary<string, int>()
                {
                    {"SKU1", 100 },
                    {"SKU2", 53 },
                    {"SKU3", 44 }
                },

                new Dictionary<string, int>()
                {
                    {"SKU2", 11 },
                    {"SKU4", 5 },
                });

            CollectionAssert.AreEquivalent(expected, actual);

        }
    }
}
