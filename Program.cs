using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

/************************
* Project Name: Seven Segment Displays
* By: Eric Huang
* Date: 2019 Jan. 26th
* 
* Seven segment displays are usually used for numbers, but they can also display letters. 
* However, not every letter can be displayed. 
* Either because they have diagonal lines such as V and Z, or because they have thee same appearance as numbers such as I and O.
* This program finds the longest words in the English language that can be displayed on a seven-segment display.
************************/

namespace SevenSegmentDisplays
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // words.txt contains all English words.
                // words_alpha.txt only contains words using alphabetical characters.
                // Eg: 2D or 11-point will not appear in words_alpha.txt
                string path = @"E:\C#\SevenSegmentDisplays\SevenSegmentDisplays\words.txt";
                string pathAlpha = @"E:\C#\SevenSegmentDisplays\SevenSegmentDisplays\words_alpha.txt";
                StreamReader file = new StreamReader(path);

                List<String> allWords = new List<string>();
                String word;
                while ((word = file.ReadLine()) != null)
                {
                    //Console.WriteLine(word);
                    allWords.Add(word);
                }
                //Console.WriteLine($"There are {allWords.Count()} words in the file.");
                //Console.WriteLine($"list can hold {allWords.Capacity} elements.");

                string longestWord = LongestWord(allWords);
                string longest7SegmentWord = Longest7SegmentWord(allWords);
                List<String> otherLong7SegmentWords = AllLongest7SegmentWords(allWords);

                Console.WriteLine($"Longest word is {longestWord} at {longestWord.Length} letters long.");
                Console.WriteLine($"Longest seven-segment compatible word is {longest7SegmentWord} at " +
                                    $"{longest7SegmentWord.Length} letters long.");

                // Outputs other possible longest words, if there are any
                otherLong7SegmentWords.Remove(longest7SegmentWord);
                if (otherLong7SegmentWords.Count == 0)
                {
                    Console.WriteLine("There are no other compatible words of the same length.");
                }
                else
                {
                    Console.WriteLine($"Other compatible words of the same length include: ");
                    foreach (string longWord in otherLong7SegmentWords)
                    {
                        Console.WriteLine("\t" + longWord);
                    }
                }

                Console.ReadLine(); //Keeps console on screen
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

        static string LongestWord(List<String> allWords) {
            string longestWord = "";
            for (int i = 0; i < allWords.Count(); i++)
            {
                if (allWords[i].Length > longestWord.Length)
                {
                    longestWord = allWords[i];
                }
            }
            return longestWord;
        }

        static string Longest7SegmentWord(List<String> allWords)
        {
            string scottPattern = @"[gkmqvwxzio]";   //letters that cannot go fit 7-Segment Displays according to Tom Scott
            Regex rgx = new Regex(scottPattern);
            string longest7SegmentWord = "";
            foreach (string word in allWords)
            {
                //word is longer than current longest AND does not match the regex
                if ((word.Length > longest7SegmentWord.Length) && !rgx.IsMatch(word))
                {
                    longest7SegmentWord = word;
                }
            }
            return longest7SegmentWord;
        }

        static List<String> AllLongest7SegmentWords(List<String> allWords)
        {
            string scottPattern = @"[gkmqvwxzio]";
            Regex rgx = new Regex(scottPattern);
            List<String> longestWords = new List<String>();
            longestWords.Add("acyclically");  //Allows the loop to ignore short words
            foreach(string word in allWords)
            {
                if (!rgx.IsMatch(word)) {
                    if (word.Length > longestWords[0].Length)
                    {
                        longestWords.Clear();
                        longestWords.Add(word);
                    }
                    else if (word.Length == longestWords[0].Length)
                    {
                        longestWords.Add(word);
                    }
                }
            }
            return longestWords;
        }
    }
}
