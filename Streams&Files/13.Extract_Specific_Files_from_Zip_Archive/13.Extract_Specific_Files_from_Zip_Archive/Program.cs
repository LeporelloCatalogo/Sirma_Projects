using System;
using System.IO;
using System.IO.Compression;

//Write a program that reads a zip archive ("archive.zip") and extracts all .txt files into a
//directory named "extracted_files".
class Program
{
    public static void Main()
    {
        string zipPath = "archive.zip";
        string extractDir = "extracted_files";

        Directory.CreateDirectory(extractDir); // Create the directory files to extract to

        using (ZipArchive archive = ZipFile.OpenRead(zipPath)) 
        {
            foreach (var entry in archive.Entries)
            {
                if (Path.GetExtension(entry.FullName).EndsWith(".txt")) // Loop through the files and see whether they match extension criteria 
                {
                    string destionationFilePath = Path.Combine(extractDir, entry.FullName);

                    Directory.CreateDirectory(Path.GetDirectoryName(destionationFilePath)); // Create a directory for subdirectories in the zipFile

                    entry.ExtractToFile(destionationFilePath, overwrite: true);

                }
            }
        }
        
        PrintAllFiles(extractDir);

    }

    public static void PrintAllFiles (string extractDir)
    {
        foreach (string file in Directory.GetFiles(extractDir, "*.txt", SearchOption.AllDirectories))
        {
            if (file.Contains("/")) // In case we stumble upon a subDirecory
            {
                PrintAllFiles(file);
            }
            Console.WriteLine(file);
        }
    }

}
