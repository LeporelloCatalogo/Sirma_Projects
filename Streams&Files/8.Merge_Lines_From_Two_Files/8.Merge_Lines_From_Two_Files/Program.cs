using System;
using System.IO;

class Program
{
    // Description:
    //Write a program that reads lines from two text files ("input1.txt" and "input2.txt") and
    //writes them alternatively into a third file ("output.txt").
    public static void Main()
    {
        string file1 = "file1.txt";
        using (var fs = File.Create(file1)) { }
        using (var writer = new StreamWriter(file1)) 
        {
            writer.WriteLine("Line 1 from file 1");
            writer.WriteLine("Line 3 from file 1");
        }

        string file2 = "file2.txt";
        using (var fs = File.Create(file2)) { }
        using (var writer = new StreamWriter(file2))
        {
            writer.WriteLine("Line 2 from file 2");
            writer.WriteLine("Line 4 from file 2");
        }

        string output = "output.txt";
        using (var fs = File.Create(output)) { }

        using (var reader1 = new StreamReader(file1))
        using (var reader2 = new StreamReader(file2))
        using (var writer = new StreamWriter(output))
        {
            string line1;
            string line2;

            while ((line1 = reader1.ReadLine()) != null | (line2 = reader2.ReadLine()) != null) // The "|" operator here is needed for both of the conditions to be evaluated fully
            {
                if (line1 != null) // I'm writing this check combined with the while condition to ensure both files are read fully, regardless of the input 
                {
                    writer.WriteLine(line1);
                }

                if (line2 != null) // Goes without saying
                {
                    writer.WriteLine(line2);
                }
            }
        }

        using (var outputReader = new StreamReader(output)) 
        {
            string line;
            while ((line = outputReader.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
        }


        // Badabim badabum
    }
}