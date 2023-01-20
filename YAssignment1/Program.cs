/*
Programmer: Y Ha
Date: Winter 2023
Purpose: Write a program that displays my initials by using Comments/ Escape Sequence Characters and Build-in methods .
*/
using System;
using static System.Console;

namespace YAssignment1
{
    class Assignment1
    {
        static void Main()
        //Following intructor's requirement, I choose letter "Y" as my first name and letter "O" in my middle name.
        //The program starts to display one blank line by Write ("\n) statement
        //Then shows sentence: I am excited... and I know "Practice..." in the next line because of WriteLine() statement.
        //The program continues to create two blank lines by the Write("\n").
        //Write("**\t**") displays ** and ** to create first line of letter "Y". In the same line, WriteLine("\t  ******") display ****** to create first line of letter "O".
        //Two blocks are seperated by a tab (\t).The program continues to run statements from lines 30 to 37 to complete the letter Y & O.
        //Finally, the program displays 2 blank lines after 2 letters.

        {
            Write("\n");
            WriteLine("I am excited about writing about my first program.");
            WriteLine("I know \"Practice make perfect\"");
            Write("\n");
            Write("\n");
            Write("**\t**");
            WriteLine("\t  ******");
            Write("\\\\\t**");
            WriteLine("\t//\t\\\\");
            Write(" ******\t**");
            WriteLine("\t**\t**");
            Write("\t**");
            WriteLine("\t\\\\\t//");
            Write("\\\\*****//");
            WriteLine("\t  ******");
            WriteLine();
            WriteLine();
            ReadKey();
        }
    }
}
