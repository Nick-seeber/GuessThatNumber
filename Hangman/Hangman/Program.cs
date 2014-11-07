using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    class Program
    {
         bool guessIsWrong = true;
        static void Main(string[] args)
        {
            HangMan();

            Console.ReadKey();
        }
         
        static void HangMan()
        {
            
            var userInput = "";
            var numberOfGuesss = 7;
            bool stillPlaying = true;
            var wordChoosen = wordSelector();
            bool wordnotguessed = false;
            var guessedstuff = "";
            string name = "";
            Console.Write("what is your name");
            name = Console.ReadLine();
            Console.WriteLine("Hello " + name + " you should know how to play.");
            while (stillPlaying)
            {
                if (!wordnotguessed && numberOfGuesss > 0) 
                {
                   MaskWord
                   Console.Write("What is your guess?");
                   userInput = Console.ReadLine();
                   if (userInput.Length > 1)
                   {
                       if (userInput == wordChoosen)
                       {
                           Console.WriteLine("You are a wennier");
                       }
                   }
                   else if (userInput.Length == 1)
                   {
                       guessedstuff = guessedstuff + userInput;
                       
                       if (MaskWordFlow(userInput))
                       {
                               numberOfGuesss--;
                       }
                        Console.WriteLine("You guessed a letter correctly.");
                       }
                       else
                       {
                           numberOfGuesss--;
                           
                       }
                   }
                    
                }
            }


        }

        static bool MaskWordFlow(string guessedwords)
        {
            string outPut = "";
            string guessword = wordSelector();
            bool theBool = true;
            
            for (int i = 0; i < guessword.Length; i++)
            {
                if (out)
                {
                    outPut = outPut + guessword[i];
                    theBool = false;
                }
                else
                {
                    outPut = outPut + "_";
                    theBool = true;
                }
            }
            Console.WriteLine(outPut);
            return theBool;
        }

        static string wordSelector()
        {
            string wordsToChooseFrom = "from google yahoo peanut butter super superman spiderman batman";
            Random rng = new Random();
            List<string> words = new List<string>(wordsToChooseFrom.Split(' '));
            var choosenWord = rng.Next(0, words.Count());
            return words[choosenWord];
        }
    }
}
