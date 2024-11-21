using System;
using System.IO;
using System.Text;

class Program
{
    //Write a program that reads a text file ("input.txt") and prints the number of unique words
    //in the file.
    public static void Main()
    {
        Console.WriteLine("Type in a message");
        byte[] byteText = Encoding.UTF8.GetBytes(Console.ReadLine());

        using (FileStream fs = new FileStream("input.txt", FileMode.Create)) 
        {
            fs.Write(byteText, 0, byteText.Length);
        }

        HashSet<string> uniqueWords = new HashSet<string>();

        using (StreamReader reader = new StreamReader("input.txt"))
        {
            string line;
            char[] splitBy = new char[] { ' ', '.', ','};
            while ((line = reader.ReadLine()) != null)
            {
                string[] words = line.Split(splitBy, StringSplitOptions.RemoveEmptyEntries);
                foreach (string word in words)
                {
                    uniqueWords.Add(word);
                }
            }
        }

        Console.WriteLine($"Number of unique words: {uniqueWords.Count}");

    }
}