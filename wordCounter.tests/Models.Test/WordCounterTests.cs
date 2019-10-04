using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using WordCounter;
using System;

namespace WordCounter.TestTools
{
    [TestClass]
    public class WordCounterTests
    {
        [TestMethod]
        public void StripPunctuation_StripsPunctuationFromInputSentence_SentenceInput()
        {
            string inputSentence = "hi, how are you?!";
            string correctString = "hi how are you";
            RepeatCounter.StripPunctuation(inputSentence);
            Assert.AreEqual(correctString, RepeatCounter.SentenceInput);
        }

        [TestMethod]
        public void SplitSentence_SplitSentenceIntoAnArray_SentenceArray()
        {
            string inputSentence = "the cat has a hat";
            string[] correctArray = {"the", "cat", "has", "a", "hat"};
            RepeatCounter.SplitSentence(inputSentence);
            string[] result = RepeatCounter.SentenceArray;
            CollectionAssert.AreEqual(correctArray, result);
        }

        [TestMethod]        
        public void ValidateInput_ValidateCatInputLength_List()
        {
            string inputString = "cat";
            List<string> correctList = new List<string> {"cat"};
            List<string> inputList = new List<string> {};
            string[] inputArray = { "cat", "kitty"};    
            RepeatCounter.ValidateInput(inputArray, inputString);
            inputList = RepeatCounter.ListOfWordsToCompare;
            CollectionAssert.AreEqual(correctList, inputList);
        }
    
        [TestMethod]        
        public void CompareWords_CompareCatandCat_2()
        {
            List<string> inputList = new List<string> {"the", "cat", "has", "cat", "hat"};
            string inputString = "cat";
            int result = RepeatCounter.CompareWords(inputString, inputList);
            Assert.AreEqual(2, result);
        }
    }
}