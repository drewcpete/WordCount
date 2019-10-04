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
            Console.WriteLine("Please enter a word:");
            RepeatCounter.WordInput = Console.ReadLine();
            string wordIn = RepeatCounter.WordInput;
            string[] arrayIn = RepeatCounter.SentenceArray;
            List<string> newList = RepeatCounter.ValidateInput(arrayIn, wordIn);
            int result = RepeatCounter.CompareWords(wordIn, RepeatCounter.ListOfWordsToCompare);
            Console.WriteLine("There are " + result + "instances of " + wordIn);

        }
    }
}