﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Problems
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Using LINQ, write a function that returns all words that contain the substring “th” from a list. 
            //List<string> words = new List<string>() { "the", "bike", "this", "it", "tenth", “mathematics” };

             //void ReturnWordsWithTh() {

                List<string> words = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };

                var wordWithTh = "th";

                var listWithTh = words.Where(w => w.Contains(wordWithTh)); // Could have also writte it this way List<string> listWithTh= words.Where(w => w.Contains(wordWithTh)).ToList();

                foreach (var word in listWithTh)
                {
                    Console.WriteLine(word);
                }
             //}


            //2.Using LINQ, write a function that takes in a list of strings and returns a copy of the list without duplicates.
            //•	List<string> names = new List<string>() { "Mike", "Brad", "Nevin", "Zack", "Mike" };

            // void ListWithoutDuplicates() {
                List<string> names = new List<string>() { "Mike", "Brad", "Nevin", "Zack", "Mike" };

                List<string> distinctNames = names.Distinct().ToList();

                foreach (var name in distinctNames)
                {
                    Console.WriteLine(name);
                }
            //}


            //3.Using LINQ, write a function that calculates the class grade average after dropping the lowest grade for each student.
            //The function should take in a list of strings of grades (e.g., one string might be "90,100,82,89,55"), drops the lowest 
            //grade from each string, averages the rest of the grades from that string, then averages the averages.

            //  List<string> classGrades = new List<string>()
            //    {
            //    "80,100,92,89,65",
            //    "93,81,78,84,69",
            //    "73,88,83,99,64",
            //    "98,100,66,74,55"
            //    };
            //    Expected output: 86.125


           // void AverageOfGrades() {
                List<string> classGrades = new List<string>()
                {
                "80,100,92,89,65",
                "93,81,78,84,69",
                "73,88,83,99,64",
                "98,100,66,74,55"
                };

                var newClassGrades = classGrades.Select(c => c.Split(',').Select(n => Convert.ToInt32(n)).OrderByDescending(n => n).Take(c.Split(',').Length - 1).Average()).Average();
                
                Console.WriteLine(newClassGrades);

            // }


            //4. Write a function that takes in a string of letters (i.e. “Terrill”) and 
            //returns an alphabetically ordered string corresponding to the letter frequency 
            //(i.e. "E1I1L2R2T1")

            //public static string GetLetterString()
            //{
                Console.WriteLine("Please enter a word");
                string input = Console.ReadLine();

                var nameArray = input.ToUpper().ToArray().OrderBy(n => n).GroupBy(n => n);
                var resultName = nameArray.Select(n => $"{ n.Last()}{ n.Count()}");
                string finalResult = "";
                foreach (var letter in resultName)
                {
                finalResult += letter.ToString();
                }
                Console.WriteLine(finalResult);
                Console.ReadLine();
             // }
  
        }
    }
}
