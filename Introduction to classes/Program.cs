using System;

class Customer
{
    string _firstName;
    string LastName;


    public Customer() : this("No FirstName Provided", "No LastName Provaided") // default parameter less Constructor 
    { 
    }
    public Customer( string FirstName, string LastName)
    {
        this._firstName = FirstName;
        this.LastName = LastName;
    }

    public void PrintFullName()
    {
        Console.WriteLine("Full Name = {0}", this._firstName+" "+this.LastName);

    }

    ~Customer() // Destructors will have the same name as that of your class it cannot take parameters and 
                // it has a tilled symbol in fornt of it and destructors are basically used to clean up any resources that
                // your class was holding on to during its liftime and this are aitomatically called by the garbage collector when it turns up to clean
                // your objects from the memory 
    {
      //Clean up code
    }
}
 class Program
    {
        static void Main()
        {
        Customer C1 = new Customer("Barkat", "Ali");

        C1.PrintFullName();
                                              //Constructos can be overloaded by the number and type of parameters.
        Customer C2 = new Customer(); 

        C2.PrintFullName();
    }

    }

