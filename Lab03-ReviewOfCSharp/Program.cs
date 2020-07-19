using System;
using System.IO;

namespace Lab03_ReviewOfCSharp
{
    public class Program
    {
        /// <summary>
        /// This methods is calling all of the methods in this program. 
        /// </summary>
        /// <param name="args">Default, a string array</param>
        public static void Main(string[] args)
        {
            Console.WriteLine("A Review of C#");

            //Calling Challenge 01

            Console.WriteLine("Please enter 3 numbers: ");
            string userInput = Console.ReadLine();
            MultiplyInputNumber(userInput);
            Console.ReadLine();
            Console.Clear();

            // Calling Challenge 02
            ReturnAverageNumber();
            Console.ReadLine();
            Console.Clear();

            // Calling Challenge 03
            OutputDesign();
            Console.ReadLine();
            Console.Clear();
            

            // Calling Challenge 06
            string path = "../../../words.txt";
            FileAppendAWord();
            Console.ReadLine();
            Console.Clear();

            // Calling Challenge 07
            ReadAFileAndOutputContent(path);

            // Calling Challenge 08
            string wordtodelete = UserInputChallengeEight();
            ReadRemoveAndRewriteFile(wordtodelete);
            Console.ReadLine();
            Console.Clear();

            // Calling Challenge 09
            //GetSentenceInput();
        }

        //Challenge01
        /// <summary>
        /// This method takes user input of 3 numbers and returns the product of these 3 numbers multiplied together.
        /// If the user puts in less than 3 numbers, return 0. 
        /// If the user puts in more than 3 number, only multiply the first 3.
        /// If the number is not a number, default that value to 1. 
        /// </summary>
        /// <param name="input">A user input of a string of 3 numbers</param>
        /// <returns>An int, either product of numbers, 0, or 1. </returns>
        public static int MultiplyInputNumber(string input)
        {
            string[] stringArray = input.Split(' ');

            int product = 1;

            if (stringArray.Length < 3)
            {
                product = 0;
                Console.WriteLine($"You have entered less than 3 numbers, so the result is: {product}");
                return product;
            }

            for (int i = 0; i < 3; i++)
            {
                if (int.TryParse(stringArray[i], out int returnValue))
                {
                    product *= returnValue;
                }
                else
                {
                    product *= 1;
                }
            }

            Console.WriteLine($"The product of these first 3 numbers is: {product}");
            return product;
        }

        // Challenge 02
        /// <summary>
        /// This method asks the user to enter a number between 2-10, 
        /// prompts the user that number of times for random numbers,
        /// and calculates the average of the selected numbers using
        /// the CalculateAverageNumber method.
        /// </summary> 
        public static void ReturnAverageNumber()
        {
            int selectedNumber = 0;

            while (selectedNumber == 0)
            {
                try
                {
                    Console.WriteLine("Please enter a number between 2-10");
                    string firstUserInput = Console.ReadLine();
                    int userNum = Convert.ToInt32(firstUserInput);

                    if (userNum < 2 || userNum > 10)
                    {
                        Console.WriteLine($"{userNum} is not a number between 2-10, please try again");
                    }
                    else
                    {
                        selectedNumber = userNum;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            int[] numberArray = new int[selectedNumber];
            for (int i = 0; i < selectedNumber; i++)
            {
                while (true)
                {
                    try
                    {
                        Console.Write($"{i + 1} of {selectedNumber} - Enter a number: ");
                        string secondUserInput = Console.ReadLine();
                        int secondUserNum = Convert.ToInt32(secondUserInput);

                        if (secondUserNum >= 0)
                        {
                            numberArray[i] = secondUserNum;
                            break;
                        }
                        else
                        {
                            Console.WriteLine($"{secondUserNum} is not a valid number, please try again:");
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
            }

            double calculatedAverage = CalculateAverageNumber(numberArray);
            Console.WriteLine($"The average of {String.Join(',', numberArray)} is {calculatedAverage}.");

        }


        /// <summary>
        /// This method takes as its input an int array 
        /// </summary>
        /// <param name="numberArray">An int array between 2-10 numbers in length.</param>
        /// <returns>A double that is the average of all the input numbers</returns>
        public static double CalculateAverageNumber(int[] numberArray)
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

            Console.WriteLine("Please enter a word you wish to add to the file: ");
            string userWord = Console.ReadLine();

            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine(userWord);
            }
        }

        // Challenge 07
        /// <summary>
        /// This method reads a text file and outputs the contents to the console. 
        /// </summary>
        /// <param name="path">The path to the text file the method is reading</param>
        static void ReadAFileAndOutputContent(string path)
        {
            string[] content = File.ReadAllLines(path);

            Console.WriteLine(String.Join('\n', content));
        }

        // Challenge 08
        /// <summary>
        /// This method reads in the file from Challenge 6, removes one of the words, and rewrites it back to the file.
        /// </summary>
        /// <returns>The word to delete from the text file</returns>
        static string UserInputChallengeEight()
        {
            Console.WriteLine("Please enter a word you wish to delete from the file: ");
            string wordToDelete = Console.ReadLine();
            return wordToDelete;
        }

        /// <summary>
        /// This method reads a file, removes one of the words and rewrites it back to the file. 
        /// </summary>
        /// <param name="path">The path to the text file the method is manipulating</param>
        static void ReadRemoveAndRewriteFile(string wordToDelete)
        {
            string path = "../../../words.txt";
            string[] words = File.ReadAllLines(path);
            string[] newWords = new string[words.Length - 1];
            int counter = 0;
            try
            {
                for (int i = 0; i < words.Length; i++)
                {
                    if (words[i] != wordToDelete)
                    {
                        newWords[counter] = words[i];
                        counter++;

                    }
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            

            File.WriteAllLines(path, newWords);

        }

        /// <summary>
        /// This method prompts the user for a sentence and passes the input through the AnalyzeSentenceToWords method.
        /// </summary>
        // Challenge 09
        static void GetSentenceInput()
        {
            Console.WriteLine("Please enter a sentence to be analyzed: ");
            string sentence = Console.ReadLine();
            AnalyzeSentenceToWords(sentence);

        }

        /// <summary>
        /// This method takes a sentence and returns an array that has each word and the number of characters in that word. 
        /// </summary>
        /// <param name="sentence">A string sentence to analyze</param>
        /// <returns>An array of each word from the input and the number of characters in it: "Word: 4"</returns>
        static string[] AnalyzeSentenceToWords(string sentence)
        {
            char[] delimiterChars = { ' ', ',', '.', ':', '\t',};
            string[] words = sentence.Split(delimiterChars);

            foreach (var word in words)
            {
                Console.WriteLine(word);
            }

            return words;
        }
    }
}
