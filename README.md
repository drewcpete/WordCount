# Word Count

By &rew Peterson

## Description
This is an application that will allow an user to input a word and a sentence.  The app will check to see how many times the word word appears in the sentence and return that number.

## Setup
Clone the repository from https://github.com/drewcpete/WordCount.git.  Use terminal command _dotnet restore_ in following directories: 
* _WordCounter.Solutions/WordCounter.Tests_
* _WordCounter.Solutions/WordCounter_ 
While in the _WordCounter.Solutions/WordCounter_ directory, use _dotnet run_

## Specs
| Behavior | Input | Output |
|--|==|==|
| Remove punctuation from inputed sentence | "hello, how are you" | "hello how are you" |
| break sentence into string array | the cat has a hat | ["the", "cat", "has", "a", "hat"] |
| create list of all words in sentence with same length as inputed word | "cat", "the cat in a hat dies" | {"the", "cat", "hat"} |
| compare inputed word against all words in list and return number of instances in sentence | "cat", ["the", "cat", "has", "cat", "hat"] | 2 |

## Technologies
* C#
* MSTest
* .NET

## License
MIT Open Source 2019