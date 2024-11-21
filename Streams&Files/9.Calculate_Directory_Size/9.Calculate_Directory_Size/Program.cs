using System;
using System.IO;

class Program
{
    public static long GetDirectorySize (string dirPath)
    {
        long dirSize = 0;

        string[] files = Directory.GetFiles(dirPath);
        foreach (string filepath in files)
        {
            FileInfo file = new FileInfo(filepath);
            dirSize += file.Length;
        }

        string[] subDirs = Directory.GetDirectories(dirPath);
        foreach(string subDirPath in subDirs)
        {
            GetDirectorySize(subDirPath);
        }

        return dirSize;

    }
    public static void Main()
    {
        string directoryPath = "mainDir";

        long dirSize = GetDirectorySize(directoryPath);
        Console.WriteLine($"Total size: {dirSize}");
 
    }
}