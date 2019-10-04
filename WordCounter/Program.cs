using System;
using System.Collections.Generic;
using WordCounter;

namespace WordCounter
{
    public class Program
    {
        public static void Main()
        {
            // Take input sentence:
            Console.WriteLine("Please enter a sentence:");
            RepeatCounter.SentenceInput = Console.ReadLine();
            string sentenceIn = RepeatCounter.SentenceInput;

            // Take inputed word to check the sentence for:
            Console.WriteLine("Please enter a word:");            
            RepeatCounter.WordInput = Console.ReadLine();            
            string wordIn = RepeatCounter.WordInput;     
            
            // Remove punctuation from sentence:
            RepeatCounter.StripPunctuation(sentenceIn);
            sentenceIn = RepeatCounter.SentenceInput;
            
            // Split punctuation left sentence into an array:
            RepeatCounter.SplitSentence(sentenceIn);
            string[] arrayIn = RepeatCounter.SentenceArray;

            // Create list of words from sentence to compare to the inputed word:          
            RepeatCounter.ValidateInput(arrayIn, wordIn); 
            List<string> newList = RepeatCounter.ListOfWordsToCompare;

            // Count how many listed words are the inputted word:            
            int result = RepeatCounter.CompareWords(wordIn, newList);

            // Display results  
            Console.WriteLine("There are " + result + " instances of " + wordIn);
        }
    }
}