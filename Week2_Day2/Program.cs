using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_Day2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare and initialize a string array of first names.Choose a name to find and print the IndexOf.
            string[] firstNames = { "Cody", "Zack", "Dmitri", "Harold" };
            Console.WriteLine(Array.LastIndexOf(firstNames, "Dmitri"));

            //Create an array of lucky numbers. Each number should repeat at least once.Choose a lucky number, 
                //find and print the last index of it.
            int[] luckyNum = { 1, 4, 6, 4, 6, 7, 9, 1, 9, 7 };
            Console.WriteLine(Array.LastIndexOf(luckyNum, 6));

            //Create an array of alphabet characters. Print the first index of the array.
                //Now reverse the array and print the first index.
            string[] letters = { "a", "z", "b", "e", "f", "h" };
            Console.WriteLine(letters[0]);
            Array.Reverse(letters);
            Console.WriteLine(letters[0]);

            //Create an array of student names in random order. Order the students’ names using the sort method.
                    //Print the first and last students’ names.
            string[] studentNames = { "Nathan", "Jeff", "Monica", "Chris", "Joey", "Steve" };
            Array.Sort(studentNames);
            Console.WriteLine(studentNames[0] + " " + studentNames[5]);

            //Ask 10 people for their favorite numbers and create an array of those numbers.
                //Order the numbers using the sort method.Print the first and last numbers.
            int[] favNum = { 2, 4, 17, 8, 9, 13, 5, 16, 20, 18};
            Array.Sort(favNum);
            Console.WriteLine(favNum[0]);
            Console.WriteLine(favNum[favNum.Length - 1]);



        }
    }
}
