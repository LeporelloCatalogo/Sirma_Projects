using System;
using System.IO;

//Write a program that reads a text file ("input.txt") and prints on the console the number
//of lines, words, and characters in the file.
class Program
{
    public static void Main()
    {
        string filepath = "input.txt";

        int lines = 0;
        int words = 0;
        int chars = 0;

        using (StreamReader reader = new StreamReader(filepath))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                lines++;
                words += line.Split(" ").Length;
                chars += line.Length;
            }
        }

        Console.WriteLine($"lines : {lines}");
        Console.WriteLine($"words : {words}");
        Console.WriteLine($"characters : {chars}");

    }
}