using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace LabExercise01
{
    class Program
    {
        static void Main(string[] args)
        {
            string data = null;
            var sb = new StringBuilder();
            // Check if file exists
            if (File.Exists("input.txt")) Console.WriteLine("File Exists");
            // Read file text to string
            using (var reader = new StreamReader("input.txt"))
            {
                data = reader.ReadToEnd();
            }
            // Remove punctuation from string
            foreach (char c in data)
            {
                if (!char.IsPunctuation(c))
                {
                    sb.Append(c);
                }
            }
            data = sb.ToString();
            // Make all letters lowercase
            data = data.ToLower();
            // Sort words into alphabetical order
            List<string> words = data.Split(" ").ToList();
            words.Sort();
            // Write new string to text file
            using (var writer = new StreamWriter("output.txt"))
            {
                foreach (string word in words)
                {
                    writer.Write(word + " ");
                }
            }
            // Write string to console
            Console.WriteLine(data);
        }
    }
}
