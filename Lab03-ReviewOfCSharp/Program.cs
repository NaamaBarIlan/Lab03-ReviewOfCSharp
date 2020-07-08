﻿using System;
using System.IO;

namespace Lab03_ReviewOfCSharp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string path = "../../../words.txt";
            FileAppendAWord();
            ReadAFileAndOutputContent(path);
            //FileAppendText(path);
            //UserInputChallengeTwo();
        }

        /// <summary>
        /// This method askes the user to enter a number between 1-2, prompts the user that number of times for random numbers and returns an int array. 
        /// </summary>
        public static int[] UserInputChallengeTwo()
        {

            Console.WriteLine("Please enter a number between 2-10");
            string firstUserInput = Console.ReadLine();
            int selectedNumber = Convert.ToInt32(firstUserInput);
            int[] numberArray = new int[selectedNumber];
            for (int i = 0; i < selectedNumber; i++)
            {
                Console.Write($"{i} of {selectedNumber} - Enter a number: ");
                string secondUserInput = Console.ReadLine();
                int selectedArrayNumber = Convert.ToInt32(secondUserInput);
                numberArray[i] = selectedArrayNumber;
            }

            //Console.WriteLine(String.Join(',', numberArray));
            return numberArray;
        }


        /// <summary>
        /// This method takes as input an int array of between 2-10 numbers and returns the average of these numbers.
        /// </summary>
        /// <param name="numberArray"></param>
        /// <returns></returns>
        public static int FindAverageNumber(int[] numberArray)
        {
            
            return 5;
        }

        // Challenge 06
        /// <summary>
        /// This method asks the user to input a word, and then saves that word into an external file named words.txt.
        /// </summary>
        static void FileAppendAWord()
        {
            string path = "../../../words.txt";

            Console.WriteLine("Please enter a word: ");
            string word = Console.ReadLine();

            using (StreamWriter sw = File.AppendText(path))
            {
               sw.WriteLine(word);
            }
        }

        // Challenge 07
        /// <summary>
        /// This method reads a text file and outputs the contents to the console. 
        /// </summary>
        /// <param name="path"></param>
        static void ReadAFileAndOutputContent(string path)
        {

            string[] content = File.ReadAllLines(path);

            Console.WriteLine(String.Join('\n', content));

        }

    }
}
