/*using System;
class Program
{
    public static void Main(string[] args)
    {
        Program p = new Program();     // if you have to invoke an instance method you create an instance of thatclass and on the instance of that
                                       // class you invoke this method using the dot operator

        p.EvenNumbers();
    }

         public void EvenNumbers()
    {
        int Start = 0;

        while (Start <= 20)
        {
            Console.WriteLine(Start);
            Start = Start + 2;
        }
    }
  }*/






//Made this method a static method now if you look
using System;
class Program
{
    public static void Main(string[] args)
    {
        Program.EvenNumbers(30);   // for static method

        Program P = new Program();  // for instance method
        int Sum = P.Add(10, 20);    

        Console.WriteLine("Sum = {0}",Sum);
    }

    public int Add(int FN, int SN)   // Add method for sum 2 number.
    {
        return FN + SN;
    }

    public static void EvenNumbers(int Target)  // Print all the even number.
    //  |      |    |
    //access modifier
    //         |    |
    // static modifier
    //              |
    //          return type
    {
        int Start = 0; 

        while (Start <= Target)
        {
            Console.WriteLine(Start);
            Start = Start + 2;
        }
    }
}


