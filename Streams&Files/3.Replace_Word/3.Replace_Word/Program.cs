using System;
using System.IO;
using System.Text;

//Write a program that reads a text file ("input.txt"), replaces all occurrences of a given
//word with another word, and writes the result to another file ("output.txt").
class Program
{
    public static void Main()
    {

        string inputFilePath = "input.txt";
        string outputFilePath = "output.txt";

        string[] change;
        string text;

        using (StreamReader reader = new StreamReader(inputFilePath))
        {
            change = reader.ReadLine().Split(" -> ");
            text = reader.ReadToEnd();
        }

        text = text.Replace(change[0], change[1]);

        using (StreamWriter writer = new StreamWriter(outputFilePath))
        {
            writer.Write(text);
        }

        using (StreamReader reader = new StreamReader(outputFilePath))
        {
            string loadedText = reader.ReadToEnd();
            Console.WriteLine(loadedText);
        }
    }
}