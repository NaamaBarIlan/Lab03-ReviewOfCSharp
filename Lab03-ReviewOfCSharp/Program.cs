using System;
using System.IO;

namespace Lab03_ReviewOfCSharp
{
    public class Program
    {
        /// <summary>
        /// This methods is calling all of the challenge methods in this program. 
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            string path = "../../../words.txt";

            //int[] numberArray = UserInputChallengeTwo();
            OutputDesign();
            //FindAverageNumber(numberArray);

            //FileAppendAWord();
            //ReadAFileAndOutputContent(path);
            //FileAppendText(path);
            //ReadRemoveAndRewriteFile(path);
        }

        //Challenge01
        /// <summary>
        /// This method takes user input of 3 numbers and returns the product of these 3 numbers multiplied together.
        /// If the user puts in less than 3 numbers, return 0. 
        /// If the user puts in more than 3 numbesr, only multiply the first 3.
        /// If the number is not a number, default that value to 1. 
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static int MultiplyInputNumber(string input)
        {
            string[] stringArray = input.Split(',');

            if (stringArray.Length < 3)
            {
                return 0;
            }

            int product = 1;

            for (int i = 0; i < 3; i++)
            {

                if (int.TryParse(stringArray[i], out int returnValue))
                {
                    product = returnValue;
                }
                else
                {
                    product *= 1;
                }
            }

            return product;
        }

        // Challenge 02
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
        public static double FindAverageNumber(int[] numberArray) 
        {
            int sum = 0;
            if (numberArray.Length == 0)
            {
                return 0;
            }

            for (int i = 0; i < numberArray.Length; i++)
            {
                sum += numberArray[i];
            }

            double average = sum / numberArray.Length;
            //Console.WriteLine("the average: " + average);
            return average;
        }

        // Challenge 03
        /// <summary>
        /// This method outputs to the console a diamond design. 
        /// </summary>
        public static void OutputDesign()
        {
            int number = 5;
            int count = number - 1;
            for (int i = 1; i <= number; i++)
            {
                for (int j = 1; j <= count; j++)
                    Console.Write(" ");
                count--;
                for (int j = 1; j <= 2 * i - 1; j++)
                    Console.Write("*");
                Console.WriteLine();
            }
            count = 1;
            for (int i = 1; i <= number - 1; i++)
            {
                for (int j = 1; j <= count; j++)
                    Console.Write(" ");
                count++;
                for (int j = 1; j <= 2 * (number - i) - 1; j++)
                    Console.Write("*");
                Console.WriteLine();
            }
            Console.ReadLine();
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

        // Challenge 08
        /// <summary>
        /// This method reads a file, removes one of the words and rewrites it back to the file. 
        /// </summary>
        /// <param name="path"></param>
        static void ReadRemoveAndRewriteFile(string path)
        {
            string[] words = File.ReadAllLines(path);
            string[] newWords = new string[words.Length - 1];

            for (int i = 0; i < words.Length - 1 ; i++)
            {       
                newWords[i] = words[i];
            }

            File.WriteAllLines(path, newWords);
        }

    }
}
