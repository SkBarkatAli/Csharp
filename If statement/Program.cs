//It checks this condition again and it checks this is extra processing (if)
/*using System;
class Program
    {
        static void Main()
        {
        Console.WriteLine("Please Enter a number");
        int UserNumber = int.Parse(Console.ReadLine());

        if (UserNumber == 1) 
        {
           Console.WriteLine("Your number is one");
        }
        if (UserNumber == 2)
        {
            Console.WriteLine("Your number is two");
        }
        if (UserNumber == 3)
        {
            Console.WriteLine("Your number is three");
        }
        if (UserNumber != 1 && UserNumber != 2 && UserNumber != 3) 
        {
            Console.WriteLine("Your number is not between 123");
        }

    }
    }*/




// it is Little more Efficient(using else if)
/*using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Please Enter a number");
        int UserNumber = int.Parse(Console.ReadLine());

        if (UserNumber == 1)
        {
            Console.WriteLine("Your number is one");
        }
        else if (UserNumber == 2)
        {
            Console.WriteLine("Your number is two");
        }
        else if (UserNumber == 3)
        {
            Console.WriteLine("Your number is three");
        }
        else 
        {
            Console.WriteLine("Your number is not between 123");
        }

    }
}*/



//If first operand is true, second is not evaluated
using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Please Enter a number");
        int UserNumber = int.Parse(Console.ReadLine());
        if (UserNumber == 10 || UserNumber == 20)// it is fast
        //if (UserNumber == 10 | UserNumber == 20)// it is not fast

            {
            Console.WriteLine("Your number is 10 or 20");
        }
        else {
            Console.WriteLine("your number not match");
        }

    }
}






