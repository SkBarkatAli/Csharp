using System;
class Program
    {
        static void Main()
        {
        /* string Name = "\"Barkat\"";    --> \"	Double quote */
        /* string Name = "one\nTwo\nThree";  --> \n New line */
        /* string Name = "c:\\barkat\\DotNet\\Trining\\Csharp";  --> \\	Backslash Escape Sequences */
        string Name = @"c:\barkat\DotNet\Trining\Csharp";  // --> verbatim Literal
        Console.WriteLine(Name);
        }
    }

