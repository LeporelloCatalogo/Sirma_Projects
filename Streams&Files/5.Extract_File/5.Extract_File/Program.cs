using System;
using System.IO;

//Write a program that reads the path to a file and subtracts the file name and its
//extension.
//Then print the file size in Bytes
class Program
{
    public static void Main()
    {
        Console.WriteLine("Type in desired filepath:");
        string filepath = Console.ReadLine();
        if (!File.Exists(filepath))
        {
            File.Create(filepath);
        }

        Console.WriteLine($"File name: {Path.GetFileName(filepath)}");
        Console.WriteLine($"File extention: {Path.GetExtension(filepath)}");
        Console.WriteLine($"File size: {new FileInfo(filepath).Length} bytes");
    }

}