using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;
using DiceGame; //file name

namespace DiceGame // Note: actual namespace depends on the project name.
{
    internal class Program // class name?
    {
        static void Main(string[] args)
        {
            // Dice dice = new Dice();
            // dice.Roll();
            // Console.WriteLine("After Roll a dice, I got: " + dice.Top);

            ////////////// Test the Dice Class /////////////
            // 1. Create 2 dice objects, roll the both dices 
            Dice dice1 = new Dice();
            Dice dice2 = new Dice();
            dice1.Roll();
            dice2.Roll();
            // compare which one is bigger
            if (dice1.Top > dice2.Top)
                Console.WriteLine("Dice 1 is bigger than Dice 2.");
            else if (dice1.Top == dice2.Top)
                Console.WriteLine("Dice 1 and Dice 2 are equal.");
            else
                Console.WriteLine("Dice 2 is bigger than Dice 1.");

            // 2. Implement a method to check if an array 
            // to keep track the topside 
            // after rolling N=5 times contains a given number
            // given an interger then check if the array contains in the integer
            int[] topTrack = new int[5];
            for (int i = 0; i < topTrack.Length; i++)
            {
                dice1.Roll();
                topTrack[i] = dice1.Top;
            }
            foreach (int num in topTrack)
                Console.WriteLine("The numbers in array are: " + num);

            Console.WriteLine("Enter a number to search: ");
            int given = int.Parse(Console.ReadLine());
            Found(given, topTrack);

            // /////////////////// /////////////////// /////////////////
            // 3. Implement a method to create a dice array with unique numbers
            // no repetition with the previous numbers in array
            // if found repetition, roll again

            //arrs[] = {1,0,0,0,0}
            // 1. roll the numbers to create another array

            // 2. check if there's repetition,
            // compare the element with other elements; bool variable

            // 3. if repetition, roll again, check(2)

            // 4. no more repeat, put the number into the arrray
            Dice dice3 = new Dice();
            int[] dice3track = new int[5];

            for (int i = 0; i < dice3track.Length; i++) //create new array
            {
                dice3.Roll();
                dice3track[i] = dice3.Top;
            }
            for (int i = 0; i < dice3track.Length; i++) //output before check
            {
                Console.WriteLine(dice3track[i]);
            }
            Console.WriteLine("---array before checked-----");

            for (int i = 0; i < dice3track.Length; i++)
            {
                while (checkBefore(dice3track)) // call the function to check if repeated
                {
                    dice3.Roll(); // roll until not repeated
                }
                dice3track[i] = dice3.Top; // assign to the index
            }

            Console.WriteLine("--------new result-----------");
            for (int i = 0; i < dice3track.Length; i++) //output the result
            {
                Console.WriteLine(dice3track[i]);
            }
            // ////////////// 2 //////////////////////////
            // no function put in another function(main)
            static bool Found(int given, int[] topTrack) // need to pass the given and array
            {
                foreach (int diceNum in topTrack)
                {
                    if (given == diceNum)
                    {
                        Console.WriteLine("The number is found.");
                        return true;
                    }
                }
                Console.WriteLine("Number Not Found.");
                return false;
            }

            /////////////////////// 3 ////////////////////////
            bool checkBefore(int[] topTrack)
            {
                foreach (int found in topTrack)
                {
                    if (found == dice3.Top)
                        return true;
                }
                return false;
            }
        }
    }
}
