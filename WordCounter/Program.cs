using System;
using System.Collections.Generic;
using WordCounter;

namespace WordCounter
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Please enter a sentence with no puncutation:");

            RepeatCounter.SentenceInput = Console.ReadLine();
            string sentenceIn = RepeatCounter.SentenceInput;
            
            RepeatCounter.SplitSentence(sentenceIn);
            string[] arrayIn = RepeatCounter.SentenceArray;

            Console.WriteLine(arrayIn[0] + " " + arrayIn[1]);
            
            Console.WriteLine("Please enter a word:");
            
            RepeatCounter.WordInput = Console.ReadLine();
            
            string wordIn = RepeatCounter.WordInput;
            
            RepeatCounter.ValidateInput(arrayIn, wordIn);
            
            List<string> newList = RepeatCounter.ListOfWordsToCompare;
            
            int result = RepeatCounter.CompareWords(wordIn, newList);
            
            Console.WriteLine("There are " + result + " instances of " + wordIn);

        }
    }
}