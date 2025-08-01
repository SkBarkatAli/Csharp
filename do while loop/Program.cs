// 1. A do loop checks its condition at the end of the loop.
//2. This means that the do loop is guaranteed to execute at least one time.
//3. Do loops are used to present a menu to the user
using System;
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
