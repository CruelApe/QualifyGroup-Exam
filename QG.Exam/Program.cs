using System;

namespace QG.Exam
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] text = { "Tyron", "Hello" , "This is a sample text!!!"};

            Console.WriteLine($"1. Get all substrings.");
            Console.WriteLine($"------------------------------------------------------");
            Console.WriteLine($"Input: {text[0]}");
            Console.WriteLine();
            Console.WriteLine($"Output:");
            Requirements.GetAllSubstring(text[0]);


            Console.WriteLine();
            Console.WriteLine($"2. Remove duplicate characters.");
            Console.WriteLine($"------------------------------------------------------");
            Console.WriteLine($"Input: {text[1]}");
            Console.WriteLine();
            Console.WriteLine($"Output:");
            Requirements.RemoveDuplicateCharacters(text[1]);


            Console.WriteLine();
            Console.WriteLine($"3. Character occurence count.");
            Console.WriteLine($"------------------------------------------------------");
            Console.WriteLine($"Input: {text[2]}");
            Console.WriteLine();
            Console.WriteLine($"Output:");
            Requirements.OccurenceCount(text[2]);
        }
    }
}
