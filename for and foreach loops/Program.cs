//foreach loop:->
//A foreach loop is used to iterate through the items in a collection. For example, foreach loop can be used with arrays or collections such as ArrayList, HashTable, and Generics.
//We will cover collections and generics in a later session.

/*using System;
class Program
    {
        static void Main()
        {
        int[] Numbers = new int[3];

        Numbers[0] = 101;
        Numbers[1] = 102;
        Numbers[2] = 103;

        foreach (int k in Numbers)                   //foreach loop
        {
           Console.WriteLine(k);
        }

    //    for ( int j=0; j< Numbers.Length; j++)     // for loop
    //    {
    //        Console.WriteLine(Numbers[j]);
    //    }

    //    int i = 0;
    //    while(i< Numbers.Length)                   // while loop
    //    {
    //        Console.WriteLine(Numbers[i]);
    //        i++;
    //    }
        }
    }*/





// break keyword
/*using System;
class Program
{
    static void Main()
    {
        for(int i = 1; i<= 20; i++)
        {
            Console.WriteLine(i);

            if (i == 10)
                break;
        }
    }
}*/



//continue keyword
using System;
class Program
{
    static void Main()
    {
        for(int i = 1; i<= 20; i++)
        {
            if (i % 2 == 1)
                continue;
            Console.WriteLine(i);

            
        }
    }
}