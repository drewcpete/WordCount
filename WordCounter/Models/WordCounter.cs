using System.Collections.Generic;
using System.Linq;

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
            SentenceArray = SentenceInput.Split(' ');
        }

        public static List<string> ValidateInput(string[] sentence, string input)
        {
            int letterCount = input.Length;
            
            foreach (string word in sentence)
            {
                if (word.Length == letterCount)
                {
                    ListOfWordsToCompare.Add(word);
                }
            }
            return ListOfWordsToCompare;
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