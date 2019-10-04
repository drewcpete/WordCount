using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter;

namespace WordCounter.TestTools
{
    [TestClass]
    public class WordCounterTests
    {
        [TestMethod]        
            public void ValidateInput_ValidateCatInputLength_True()
            {
                string correctString = "cat";
                bool result = false;
                result = ValidateInput(correctString, "hat");
                Assert.IsTrue(result);
            }
        
        [TestMethod]        
            public void CompareWords_CompareCatandCat_2()
            {
                string correctString = "the cat has a pet cat";
                result = CompareWords(correctString, "cat")
                Assert.AreEqual(2, result);
            }
        
    }
}