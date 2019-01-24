using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevenSegmentDisplays
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // words.txt contains all english words.
                // words_alpha.txt only contains words using alphabetical characters.
                //Eg: 2D or 11-point will not appear in words_alpha
                string path = @"E:\C#\SevenSegmentDisplays\SevenSegmentDisplays\words.txt";
                string pathAlpha = @"E:\C#\SevenSegmentDisplays\SevenSegmentDisplays\words_alpha.txt";
                StreamReader file = new StreamReader(pathAlpha);

                List<String> allWords = new List<string>();
                String word;
                while ((word = file.ReadLine()) != null)
                {
                    //Console.WriteLine(word);
                    allWords.Add(word);
                }
                Console.WriteLine($"{allWords.Count()} words in the file.");
                //Console.WriteLine($"list can hold {allWords.Capacity} elements.");

                string longestWord = "";
                string longest7SegmnentWord = "";
                for(int i = 0; i < allWords.Count(); i++)
                {
                    if (allWords[i].Length > longestWord.Length)
                    {
                        longestWord = allWords[i];
                    }
                }
                Console.WriteLine($"Longest word is {longestWord}");



                Console.ReadLine();

            }
            catch(Exception e)
            {
                String fileNotFoundMsg = "There was an error in reading words.txt. Please check that the path is correct and that the file exists.";
                Console.WriteLine(fileNotFoundMsg);
                Console.WriteLine("Exception Message: " +e.Message);
                Console.ReadLine(); //Keeps console on screen
                return;
            }


        }
    }
}
