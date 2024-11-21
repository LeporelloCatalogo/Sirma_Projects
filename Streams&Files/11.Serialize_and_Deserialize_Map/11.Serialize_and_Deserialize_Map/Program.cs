using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.Json;

//Write a program that saves and loads a Map of string keys and int values to a file using
//FileStream. Set the name of the file as "map.dat".
class Program
{
    public static void Main()
    {
        string mapPath = "map.dat";
        Dictionary<string, int> map = new Dictionary<string, int>()
        {
            { "Dutch", 49 },
            { "Arthur", 36 },
            { "Hosea", 56 },
            { "John", 33 },
            { "Sadie", 35 }
        };

        using (FileStream writer = new FileStream(mapPath, FileMode.Create, FileAccess.Write))
        {
            /*BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fs, map);*/ // I may very well be wrong, but VS doesn't allow me to use BinaryFormatter in any way, marking it as obsolete

            byte[] buffer = Encoding.UTF8.GetBytes(JsonSerializer.Serialize(map));
            writer.Write(buffer, 0, buffer.Length); // So instead I'm going to use Json to serialize the map
        }

        Dictionary<string, int> loadedMap = new Dictionary<string, int>();
        using (StreamReader reader = new StreamReader(mapPath))
        {
            loadedMap = JsonSerializer.Deserialize<Dictionary<string, int>>(reader.ReadToEnd());
        }

        foreach (KeyValuePair<string, int> kvp in loadedMap)
        {
            Console.WriteLine($"Wanted: {kvp.Key} - Age: {kvp.Value}");
        }
    }
}