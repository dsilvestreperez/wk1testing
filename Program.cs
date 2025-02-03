using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Guess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //decaration

            int secret = 0; //hold the secret number
            int guess = 0;

            bool winning = false; // flag to reflect the winning condition

            bool playAgian = true;


            //computer will generate a random sercret number

            Random rid = new Random();
            secret = rid.Next(secret);
            //program will ask user to input a number to guess sercet number

            while(winning == false);

            {
                Console.WriteLine("Whatis your guess number?");
                guess = Convert.ToInt32(Console.ReadLine());

            }
            //if the guessing numbere is greater than, print the number is too large

            if (guess > secret)
            {
                Console.WriteLine("Number is to large");
            }
            //if the guessing number is less than, print the number is to small
            else if (guess < secret)
            {
                Console.WriteLine("Number is to small");
            }

            //if the guess number is secret, print, YOU WIN ann exit
            else

        }
    }
}
