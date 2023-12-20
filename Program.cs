using System;
using System.IO;
using static System.Net.Mime.MediaTypeNames;

namespace InsertEnvironmentVariables
{
    class Program
    {
        static readonly string textFile = $"{Environment.CurrentDirectory}\\txtFile.txt";

        static void Main(string[] args)
        {
            if (File.Exists(textFile))
            {
                string[] lines = File.ReadAllLines(textFile);
                foreach (string line in lines)
                {
                    string variable = line.Split('=')[0];
                    string value = line.Split("=")[1];

                    if (Environment.GetEnvironmentVariable(variable) == null)
                    {
                        Environment.SetEnvironmentVariable(variable, value, EnvironmentVariableTarget.Machine);
                        Console.WriteLine($"Inseted: {line}");
                    } else
                    {
                        Console.WriteLine($"Already existe: {line}");
                    }
                }
                
            } else {
                Console.WriteLine("dont exist file");
            }
            Console.ReadKey();
        }
    }
}