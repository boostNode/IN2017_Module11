/*
 *  Author: Troy Davis
 *  Project: Module11 - DisplayFile
 *      - Software Development Fundamentals Lesson 5
 *        -- Understanding Console Base Applications - exercise p130
 *
 *  NOTE: Drive letter in command line arguments must be correctly set (see Debug Start Options)
 *      - this sets correct path to file "Sample.txt"
 *              
 *  Class: IN 2017 (Advanced C#)
 *  Date: Apr 12, 2017 
 *  Revision: Original
 */

using System;
using System.IO;

namespace DisplayFile
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 1)
                return;
            string[] lines = File.ReadAllLines(args[0]);
            foreach (string item in lines)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
