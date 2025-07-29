using System;
class Program
    {
        static void Main()
        {
        Console.WriteLine("Please enter your first name"); //Prompt the user name for his name

        string firstName = Console.ReadLine();  // Red the name console

        Console.WriteLine("Please enter your last name");

        string lastname = Console.ReadLine();

        //Console.WriteLine("Hello " + UserName);  // Concatenate name with hello word and print
        
        Console.WriteLine("Hello {0} {1}",  firstName,lastname);  // Placeholder syntax to print name with hello word
    }
}


