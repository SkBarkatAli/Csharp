/*using System;
 class Program
    {
        static void Main()
        {
        Console.WriteLine("plese enter the number");
        int UserNumber = int.Parse(Console.ReadLine());

        switch (UserNumber) 
        {

            case 10:
                Console.WriteLine("YOUR NUMBER IS 10");
                break;
            case 20:
                Console.WriteLine("YOUR NUMBER IS 20");
                break;
                case 30:
                Console.WriteLine("YOUR NUMBER IS 30");
                     break;
            default:
                Console.WriteLine("YOUR NUMBER IS NOT 10, 20 4 30");
                break;
        }


        }
    }*/






//NOTE-Case statements, with no code in-between,creates a single case for multiple values. A case Without any code
//will automatically fall through to next case. in this example, case 10 and case 20 will fall through and execute code for case 30.
using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("plese enter the number");
        int UserNumber = int.Parse(Console.ReadLine());

        switch (UserNumber)
        {

            case 10:
            case 20:
            case 30:
                Console.WriteLine("YOUR NUMBER IS {0}",UserNumber);
                break;
            default:
                Console.WriteLine("YOUR NUMBER IS NOT 10, 20 4 30");
                break;
        }


    }
}


