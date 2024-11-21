using System;
using System.IO;
using System.Text;

//Write a program that reads a text file (input.txt) and prints on the console the
//frequency of each character in the file. Use StreamReader.
class Program
{
    public static void Main()
    {

        string filepath = "text.txt";

        var dict = new Dictionary<char, int>();
        string text;

        using (StreamReader reader = new StreamReader(filepath))
        {
            int unicode;
            while((unicode = reader.Read()) != -1)
            {
                char symbol = (char)unicode;
                if (dict.ContainsKey(symbol))
                {
                    dict[symbol]++;
                }
                else
                {
                    dict.Add(symbol, 1);
                }
            }
        }

        foreach (var item in dict)
        {
            Console.WriteLine($"{item.Key} : {item.Value}");
        }

    }
}
