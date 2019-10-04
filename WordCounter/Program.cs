using System;
using System.Collections.Generic;
using WordCounter;

namespace WordCounter
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Please enter a sentence:");

            RepeatCounter.SentenceInput = Console.ReadLine();
            string sentenceIn = RepeatCounter.SentenceInput;
            RepeatCounter.StripPunctuation(sentenceIn);
            sentenceIn = RepeatCounter.SentenceInput;

            Console.WriteLine(sentenceIn);
                
            

            RepeatCounter.SplitSentence(sentenceIn);
            string[] arrayIn = RepeatCounter.SentenceArray;

            
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