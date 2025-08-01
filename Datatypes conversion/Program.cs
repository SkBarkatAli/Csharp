/*//1. Implicit Conversion (Safe, automatic)
using System;
class Program
    {
        static void Main()
        {
        int i = 100;
                        // float is bigger datatype than int. so, no loss of
                        // data and Exceptions. Hence implicit conversion
        float f = i;

        Console.WriteLine(f);
        }
} */



/*// 2. Explicit Conversion (Casting) (You must do manually)
using System;
class Program
{
    static void Main()
    {
        float f = 123.45f;  // Cannot implicity conver float to int Feactional part will be lost. Float is abigger data 
                            // type than int, so there is also a possibility of overflow exception

       //int i = (int)f; // type cast operator
       int i = Convert.ToInt32(f); // use Convert class

        Console.WriteLine(f);
    }
}*/




/*//Using Parse() Method
using System;
class Program
{
    static void Main()
    {
        string strNumber = "100";

        int i = int.Parse(strNumber);  // parse method

        Console.WriteLine(i);
    }
}*/



//Using TryParse() Method
using System;
class Program
{
    static void Main()
    {
        string strNumber = "100";

        int Result = 0;

        bool IsConversionSuccessful = int .TryParse(strNumber, out Result);
        if (IsConversionSuccessful)
        {
            Console.WriteLine(Result);
        }
        else
        {
            Console.WriteLine("plese enter a valid number");
        }
    }
}


