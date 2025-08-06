using System;

public class Employee  // parent Class Implemention
{
    public string FirstName;
    public string LastName;
    


    public void printFullName()
    {
      Console.WriteLine(FirstName + " " + LastName); 
    }
}

public class FullTimeEmployee : Employee   // childClass Implementation
{
    public new void printFullName()  
    {
        //base.printFullName(); // -> for parent class used base keyword
        Console.WriteLine(FirstName + " " + LastName + " - from child") ;
    }
}


public class PartTimeEmployee : Employee
{
   
}


public class Program
    {
       public static void Main()
        {

        Employee FTE = new FullTimeEmployee();// a parent class reference variable can point to a child class object wherea
        FTE.FirstName = "Barkat";
        FTE.LastName = "Ali";

        //((Employee)FTE).printFullName(); // for parent class method calld not child class.
        FTE.printFullName();

        PartTimeEmployee PTE = new PartTimeEmployee();
        PTE.FirstName = "luci";
        PTE.LastName = "far";
        PTE.printFullName();
        

    }
    }



