using System;
using PATA = ProjectA.TeamA;  // Namespace alias
using PATB = ProjectA.TeamB;  // Namespace alias

class Program
{
    public static void Main()
    {
        // ProjectA.TeamA.ClassA.Print(); // We can resolve the ambiguity between classes using fully qualified names
        // ProjectA.TeamB.ClassA.Print();

        PATA.ClassA.Print();
        PATB.ClassA.Print();
    }
}


