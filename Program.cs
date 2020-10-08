using System;
using System.IO;

namespace LabExercise01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Check if file exists
            if (File.Exists("input.txt")) Console.WriteLine("File Exists");
            string data = null;
            char empty = ' ';
            // Read file text to string
            using (var reader = new StreamReader("input.txt"))
            {
                data = reader.ReadToEnd();
            }
            // Remove punctuation from string
            foreach (char c in data)
            {
                if (c == '!' || c == '.' || c == ',' || c == '?')
                {
                    data = data.Replace(c, empty);
                }
            }
            // Write string to console
            Console.WriteLine(data);
        }
    }
}
