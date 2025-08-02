// 1. A do loop checks its condition at the end of the loop.
//2. This means that the do loop is guaranteed to execute at least one time.
//3. Do loops are used to present a menu to the user
/*ing System;
class Program
{
    static void Main()
    {
        string UserChoice = string.Empty;
        do
        {
            Console.WriteLine("Please enter your target?");
            int UserTarget = int.Parse(Console.ReadLine());

            int Start = 0;

            while (Start <= UserTarget)
            {
                Console.Write(Start + " ");
                Start = Start + 2;
            }




            do
            {
                Console.WriteLine("Do you want to continue - Yes or No?");

                UserChoice = Console.ReadLine().ToUpper();
                if (UserChoice != "YES" && UserChoice != "NO")
                {
                    Console.WriteLine("Invalide Choice , please say Yes or No");
                }
            } while (UserChoice != "YES" && UserChoice != "NO");
        } while (UserChoice == "YES");
    }
}
*/



//coffee maker ewritten Code Using do...while
using System;

class Program
{
    static void Main()
    {
        int TotalCoffeeCost = 0;
        string UserDecision = "";

        do
        {
            Console.WriteLine("Please select your coffee size: 1 - Small, 2 - Medium, 3 - Large");
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
                    continue;  // Skip to next iteration of the loop
            }

            Console.WriteLine("Do you want to buy another coffee? (yes or no)");
            UserDecision = Console.ReadLine();

            // Keep asking for valid input if not "yes" or "no"
            while (UserDecision.ToUpper() != "YES" && UserDecision.ToUpper() != "NO")
            {
                Console.WriteLine("Your choice {0} is invalid. Please enter yes or no.", UserDecision);
                UserDecision = Console.ReadLine();
            }

        } while (UserDecision.ToUpper() == "YES");

        Console.WriteLine("Thank you for shopping with us!");
        Console.WriteLine("Bill Amount = {0}", TotalCoffeeCost);
    }
}
