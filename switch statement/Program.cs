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
            case 20:
            case 30:
                Console.WriteLine("YOUR NUMBER IS {0}",UserNumber);
                break;
            default:
                Console.WriteLine("YOUR NUMBER IS NOT 10, 20 4 30");
                break;
        }


    }
}*/





// Break Statement: if breackstatement is used inside a switch statement, the control will leave the switch statement.
//goto statement: You can either jumpe to another casw statemnet or to aspecific lable.
//WARNING: Using goto is bad programming style. We can shuld avoid goto by all means.

//One Coffee maker
using System;
class Program
{
    static void Main()
    {
        int TotalCoffeeCost = 0;

        Start:
        Console.WriteLine("Please Select your coffee size : 1 - small, 2 - Medium , 3 - Large");
        int UserChoice = int.Parse(Console.ReadLine());

        switch (UserChoice) 
        {
           case 1:
                TotalCoffeeCost += 1;
                break;
                case 2:
                TotalCoffeeCost += 2;
                break;
                case 3:
                TotalCoffeeCost += 3;
                break;
                default:
                Console.WriteLine("Your choice {0} is invalid", UserChoice);
                goto Start;
        }
        Decide:
        Console.WriteLine("Do you want to buy another coffe - yes or no?");
        string UserDecision = Console.ReadLine();
        
        switch(UserDecision.ToUpper())
        {
            case "YES":
                goto Start;          //There is no need to include break statement if you have a goto statement there 
            case "NO":
                break;
            default:
                Console.WriteLine("your choice {0} is invalid. Please try again...",UserDecision);
                goto Decide;
        }




        Console.WriteLine("Thank you for shopping with us");
        Console.WriteLine("Bill Amount = {0}",TotalCoffeeCost);



        }


    }


