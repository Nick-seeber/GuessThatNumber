using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace guessThatNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //ask to play the game
            instructions("Red Alert!! Ready to play? type y or n \n" + Console.ReadLine());
            //take in the string from user
            
            //if statement to see if they really want to play
            if (Console.ReadLine() == "y")
            {
                //a little back story
                instructions("You are captian of the star ship enterprise you are in battle with the borg \n you need to find their sheild frequency and you have narrowed it down to \n frequencys 1 to 100 guess the correct shield frequency \n AND DESTROY THE BORG!!!! \n GO! ");
               // calling the Guess that number function
                GuessThatNumber();
            }

            else
            {
                //If they don't want to play
                instructions("You are not worthy to wear a Starfleet uniform");
            }
           
            
        }

        static void GuessThatNumber()
        {
            //declaring variables including random num gen
            int numtries = 0;
            Random rng = new Random();
            int compnumber = 0;                   
            int userGuess = Convert.ToInt32(Console.ReadLine());
            Console.ReadLine();
            compnumber = rng.Next(1, 100);
           
            //using a while loop to compair if the user guess is equal to or greater than or less than the random computer number
            while (userGuess != compnumber || userGuess > compnumber || userGuess < compnumber)
            {
               

                if (userGuess == compnumber)
                {
                    //got it right
                    instructions("FINALLY " + compnumber + "is correct");
                                    
                }
                else if (userGuess > compnumber)
                {
                    //got it wrong and it was lower
                    instructions("NOPE " + userGuess + " IS WRONG. It's lower.");
                    //reseting the user guess to the input from console
                    userGuess = Convert.ToInt32(Console.ReadLine());
                    numtries++;
                }
                else if (userGuess < compnumber)
                {
                    //got it wrong and it was higher
                    instructions("NOPE " + userGuess + " IS WRONG. Try Higher.");
                    //resetting it back to the input from console
                    userGuess = Convert.ToInt32(Console.ReadLine());
                    numtries++;
                    
                }
               

            }
            //if you guess the number right within 5 tries
            if (numtries == 1 || numtries == 2 || numtries == 3 || numtries == 4 || numtries == 5)
            {
                instructions("YOU HAVE DESTROYED THE BORG AND IT ONLY TOOK YOU " + numtries + " TRIES");
            }
            else
            {
                //if not
                instructions("YOU HAVE BEEN DESTROYED BY THE BORG!!! \n Total Times Failed: " + numtries + " the number was " + compnumber + "  '\n' Want to play again? type y or n");
            }
           //reading the console to see if you want to play again
            Console.ReadLine();
            //if statement to determin what to do if you do or do not want to play again
            if (Console.ReadLine() == "y")
            {
                //yes you do want to play again print this out
                instructions("TIME TO DEFEAT MORE BORG!!");
                //call function for game
                GuessThatNumber();

            }
            else
            {
                //if you don't want to play print this, but that will never happen my game is awesome.
                Console.WriteLine("Fine you suck then");
            }
           
            
            

        }
        static void instructions(string input)
        {
            //creating a loop to go over each index of input
            for (int i = 0; i < input.Length; i++)
            {
                //writing out the index of input
                Console.Write(input[i]);
                //writing it out slowly
                Thread.Sleep(100);            
                               
            }

        }

        
        
    }   
 }
    
  

