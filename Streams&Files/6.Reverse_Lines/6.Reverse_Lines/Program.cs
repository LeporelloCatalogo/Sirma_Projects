using System;
using System.IO;

//Write a program that reads a text file ("input.txt"), reverses each line, and writes the
//result to another file ("output.txt").
class Program
{
    public static void Main()
    {
        using (StreamReader inputReader = new StreamReader("input.txt"))
        {
            using (StreamWriter outputWriter = new StreamWriter("output.txt"))
            {
                string line;
                while ((line = inputReader.ReadLine()) != null)
                {
                    line = string.Join("", line.Reverse());
                    outputWriter.WriteLine(line);
                }
            }
        }

        using (StreamReader outputReader = new StreamReader("output.txt"))
        {
            Console.Write(outputReader.ReadToEnd());
        }
            Console.WriteLine("\nText from input file has been reversed and written to the output file.");

    }
}
