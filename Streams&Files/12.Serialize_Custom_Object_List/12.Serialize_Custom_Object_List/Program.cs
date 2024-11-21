using System;
using System.IO;
using System.Text;
using System.Text.Json;

//Write a program that saves and loads a list of custom objects (Person). The Person class
//should have string name and int age. Set the name of the save file as "persons.dat".
class Program
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Person (string name, int age)
        {
            Name = name;
            Age = age;
        }

    }
    public static void Main()
    {
        string filepath = "persons.dat";

        List<Person> list = new List<Person>() 
        { 
            new Person("Henry", 24),
            new Person("Count Yan Ptachek", 25),
            new Person("Sir Kobyla", 48),
            new Person("King Sigizmund", 55),
            new Person("Daniel Vavra", 49)
        };

        using (FileStream fs = new FileStream(filepath, FileMode.Create, FileAccess.Write))
        {
            string jsonString = JsonSerializer.Serialize(list);
            byte[] buffer = Encoding.UTF8.GetBytes(jsonString);

            fs.Write(buffer, 0, buffer.Length);
        }

        List<Person> loadedList = new List<Person>();
        using (FileStream fs = new FileStream(filepath, FileMode.Open, FileAccess.Read))
        {
            byte[] buffer = new byte[fs.Length];
            fs.Read(buffer, 0, buffer.Length);

            string jsonString = Encoding.UTF8.GetString(buffer);

            loadedList = JsonSerializer.Deserialize<List<Person>>(jsonString);
        }

        foreach (Person person in loadedList)
        {
            Console.WriteLine($"{person.Name} - {person.Age}");
        }

    }
}

