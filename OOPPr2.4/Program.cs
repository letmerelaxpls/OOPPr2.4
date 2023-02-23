using System;
using System.Collections.Generic;

class Program
{
    delegate int StringLengthDelegate(string s);

    static void Main(string[] args)
    {
        List<string> strings = new List<string>() { "Ya", "Sabinina", "mama"};

        StringLengthDelegate stringLengthDelegate = s => s.Length;

        foreach (string s in strings)
        {
            int length = stringLengthDelegate(s);
            Console.WriteLine($"The length of '{s}' is {length} symbols.");
        }
    }
}