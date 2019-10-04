using System.Collections.Generic;
using System.Linq;
using System;

namespace WordCounter
{
    public class RepeatCounter
    {
        public static string WordInput { get; set; }
        public static string SentenceInput { get; set; }
        // public static var Punctuation  { get; set; }        
        public static string[] SentenceArray { get; set; }
        public static List<string> ListOfWordsToCompare = new List<string> {};
        public RepeatCounter(string inputWord, string inputSentence)
        {
            WordInput = inputWord;
            SentenceInput = inputSentence;
            
        }
        public static void StripPunctuation(string sentenceIn)
        {
            List<char> charList = new List<char>{};
            char[] charArray = sentenceIn.ToCharArray();
            foreach (char character in charArray)
            {
                
                bool result = Char.IsPunctuation(character);
                // if (character == )
                // {
                    
                // }
                if (result == false || character == ' ')
                {
                    charList.Add(character);
                }
            }
            char[] newArray = charList.ToArray();
            SentenceInput = new string(newArray);            
        }

        public static void SplitSentence(string sentenceIn)
        {
            SentenceArray = sentenceIn.Split(" ");
        }
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