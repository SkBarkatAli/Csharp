// Polimorphism enables us to invoke derived class method using a base class referance variable at runtime
// thatis polimofphism

using System;

public class Employee
{
    public string FistName = "FN";
    public string LastName = "LN";

    public virtual void PrintFullName()   // any derived class can override the method you know the virtual method
    {
        Console.WriteLine(FistName + " " + LastName);
    }
}

public class PartTimeEmployee : Employee
{
    public override void PrintFullName()
    {
        Console.WriteLine(FistName + " " + LastName + " - Part Time");
    }
}
public class FullTimeEmployee : Employee
{
    public override void PrintFullName()
    {
        Console.WriteLine(FistName + " " + LastName + " - Full Time");
    }
}
public class TemporaryEmployee : Employee
{
    // here we don't  have the overidden method so the base class virtual method implementation will bw used.
}

public class Program
{
    static void Main()
    {
        Employee[] employees = new Employee[4];

        employees[0] = new Employee();
        employees[1] = new PartTimeEmployee();
        employees[2] = new FullTimeEmployee();
        employees[3] = new TemporaryEmployee();

        foreach (Employee e in employees)
        {
            e.PrintFullName();
        }
    }
}

