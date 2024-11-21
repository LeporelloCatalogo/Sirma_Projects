using System;
using System.IO;

//Write a program that copies the content of a text file ("input.txt") to another file
//("output.txt").
class Program
{
    public static void Main()
    {
        string inputPath = "input.txt";
        string outputPath = "output.txt";

        using (FileStream inputFs = new FileStream(inputPath, FileMode.Open))
        using (FileStream outputFs = new FileStream(outputPath, FileMode.Create, FileAccess.Write))
        {
            byte[] buffer = new byte[250];
            while (inputFs.Read(buffer, 0, buffer.Length) > 0)
            {
                outputFs.Write(buffer, 0, buffer.Length);
            }
        }

        using (StreamReader outputReader = new StreamReader(outputPath))
        {
            char[] textBuffer = new char[250];

            while (outputReader.ReadBlock(textBuffer, 0, textBuffer.Length) > 0)
            {
                Console.WriteLine(string.Join("", textBuffer));
            }
        }

    }
}
