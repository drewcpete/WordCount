using System.Collections.Generic;

namespace WordCounter
{
    public class RepeatCounter
    {
        public static string WordInput { get; set; }
        public static string SentenceInput { get; set; }
        public static char[] Punctuation { get; set; }
        public static string[] SentenceArray { get; set; }

        public static List<string> ListOfWords = new List<string>{};

        public RepeatCounter(string inputWord, string inputSentence)
        {
            WordInput = inputWord;
            SentenceInput = inputSentence;
            Punctuation = SentenceInput.Where(Char.IsPunctuation).Distinct().ToArray();
            SentenceArray = WordInput.Split().Select(x => x.Trim(Punctuation));
        }

        public static List<string> ValidateInput(string[] sentence)
        {
            int letterCount = RepeatCounter.WordInput.Length();
            
            foreach (string word in sentence)
            {
                if (word.Length == letterCount)
                {
                    ListOfWords.Add(word);
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