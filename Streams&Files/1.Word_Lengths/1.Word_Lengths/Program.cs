using System;
using System.IO;
using System.Text;

//Write a program that reads a text file ("input.txt") and prints on the console the length of
//each word in the file. Use BufferedReader in combination with FileReader. - I assume this description stands for Java, so instead I'll use StreamReader
class Program
{
    static void Main()
    {

        string filepath = "some_text.txt";

        

        using (StreamReader reader = new StreamReader(filepath))
        {
            string line;

            while ((line = reader.ReadLine()) != null)
            {
                string[] words = line.Split(' ');

                foreach (string word in words)
                {
                    Console.WriteLine($"{word} - {word.Length} ");
                }
            }
        }

    }
}

