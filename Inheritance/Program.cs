/*using System;

public class Employee  // parent Class Implemention
{
    public string FirstName;
    public string LastName;
    public string Email;


    public void printFullName()
    {
      Console.WriteLine(FirstName + " " + LastName); 
    }
}

public class FullTimeEmployee : Employee   // childClass Implementation
{
    public float YearlySalary;
}


public class PartTimeEmployee : Employee
{
    public float HourlyRate;
}


public class Program
    {
        static void Main()
        {
        FullTimeEmployee FTE = new FullTimeEmployee();
        FTE.FirstName = "Barkat";
        FTE.LastName = "Ali";
        FTE.YearlySalary = 50000000000;
        FTE.printFullName();

        PartTimeEmployee PTE = new PartTimeEmployee();
        PTE.FirstName = "luci";
        PTE.LastName = "far";
        PTE.HourlyRate = 10000;
        PTE.printFullName();

        }
    }

*/


using System;

public class ParentClass 
{
    public  ParentClass ()
    {
        Console.WriteLine("ParentClass Constructor called");

    }
     public ParentClass (string message)
    {
        Console.WriteLine(message);
    }
}


public class ChildClass : ParentClass
{
    public ChildClass(): base("Derived Class controlling Parent class")
    {
        Console.WriteLine("childClass Constructor called");
    }
}
public class Program
    {
       public static void Main()
        {
           ChildClass CC = new ChildClass();

        }
    }




