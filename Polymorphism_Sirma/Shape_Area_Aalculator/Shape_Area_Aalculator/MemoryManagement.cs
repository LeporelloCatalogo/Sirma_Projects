using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

/*namespace Shape_Area_Aalculator
{
    internal class MemoryManagement
    {
        private string filepath { get; set; }

        public MemoryManagement(string path)
        {
            filepath = path;
        }

        public void Save(List<Shape> shapes)
        {
            string jsonShapes = JsonSerializer.Serialize(shapes);
            File.WriteAllText(filepath, jsonShapes);
            Console.WriteLine("Shapes data has been saved.");
        }

        public List<Shape> LoadShapes()
        {
            string jsonShapes = File.ReadAllText(filepath);
            List<Shape> shapes = JsonSerializer.Deserialize<List<Shape>>(jsonShapes);
            Console.WriteLine("List of shapes has been loaded from save file.");
            return shapes;
        }
    }
}*/
