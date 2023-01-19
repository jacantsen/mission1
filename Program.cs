//Jacob Christiansen Sec 3 

using System;

namespace consoleapp

{
    class Program
    {
        static void Main(string[] args)
        {
            // Welcome user and prompt for the number of rolls
            Console.WriteLine("Welcome to the dice throwing simulator!");
            Console.WriteLine("How many dice rolls would you like to simulate?");

            // convert the number of rolls to an integer
            int numRolls = Convert.ToInt32(Console.ReadLine());

            // print the number of rolls that will occur
            Console.WriteLine("The number of rolls is: " + numRolls);
            //create the 2 dice
            int[] dice1 = new int[6];
            int[] dice2 = new int[6];
            //create random number
            Random r = new Random();
            //create variable to hold roll totals
            int[] roll_total = new int[13];
            //roll the dice the desired number of times
            for (int i = 0; i < numRolls; i++)
            {
                //roll the dice
                int roll1 = r.Next(1, 7);
                int roll2 = r.Next(1, 7);
                //increment index
                roll_total[roll1+roll2]++;

            }

            string asterisk = "";
            //for each number, print the number and its star count
            for (int i = 2; i < roll_total.Length; i++)
            {
                //calculate the number of stars for each number
                int numStars = roll_total[i] * 100;
                int numberStars = numStars/numRolls;
                //add asterisk to string for each percent
                for (int count = 0; count < numberStars; count++)
                {
                    asterisk += "*";
                }
            
                //print out the number and stars for each percent
                Console.WriteLine(i + ": " + asterisk);
                //reset to empty 
                asterisk = "";
            }
           
        }
    }
}
