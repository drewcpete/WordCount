using System.Collections.Generic;
using System.Linq;
using System;

namespace WordCounter
{
    public class RepeatCounter
    {
        public static string WordInput { get; set; }
        public static string SentenceInput { get; set; }
        public static string[] SentenceArray { get; set; }
        public static List<string> ListOfWordsToCompare = new List<string> {};

        public RepeatCounter(string inputWord, string inputSentence)
        {
            WordInput = inputWord;
            SentenceInput = inputSentence;
        }

        // method for splitting sentence into a char array and removing all punctuation char's except " ".   
        public static void StripPunctuation(string sentenceIn)
        {
            List<char> charList = new List<char>{};
            char[] charArray = sentenceIn.ToCharArray();
            foreach (char character in charArray)
            {    
                bool result = Char.IsPunctuation(character);       
                if (result == false || character == ' ')
                {
                    charList.Add(character);
                }
            }
            char[] newArray = charList.ToArray();
            SentenceInput = new string(newArray);            
        }

        // method for splitting the sentence string[] into a string of words.
        public static void SplitSentence(string sentenceIn)
        {
            SentenceArray = sentenceIn.Split(" ");
        }

        // method for adding all words of the same length as the inputted word to a list. 
        public static void ValidateInput(string[] sentence, string input)
        {
            int letterCount = input.Length;            
            foreach (string word in sentence)
            {
                if (word.Length == letterCount)
                {
                    RepeatCounter.ListOfWordsToCompare.Add(word);
                }
            }
        }

        // method for comparing list of words of the same length as the inputed word to the inputed word.
        public static int CompareWords(string inputWord, List<string> wordList)
        {
            int count = 0;
            foreach (string word in wordList)
            {
                if (word == inputWord)
                {
                    count++;
                }
            }
            return count;
        }
    }
}