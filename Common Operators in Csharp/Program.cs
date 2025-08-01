using System;
class Program
{
    static void Main()
    {
        /*  // = Simple Assignment
         int x = 10;
         string name = "Lucifar";  */


        /* // += Addition Assignment
         int x = 5;
         x += 3; // x = x + 3 → x becomes 8  */


        /*  // -= Subtraction Assignment
           int x = 10;
           x -= 4; // x = x - 4 → x becomes 6  */


        /* //  *= Multiplication Assignment
          int x = 6;
          x *= 2; // x = x * 2 → x becomes 12  */


        /*  // /= Division Assignment
         int x = 10;
         x /= 2; // x = x / 2 → x becomes 5 */

        /*  //  %= Modulus Assignment
          int x = 10;
          x %= 3; // x = x % 3 → x becomes 1 */





        /*   //Arithmetic Operators
           int x = 12;
           int y = 5;

           Console.WriteLine("Addition: " + (x + y));      // 17
           Console.WriteLine("Subtraction: " + (x - y));   // 7
           Console.WriteLine("Multiplication: " + (x * y));// 60
           Console.WriteLine("Division: " + (x / y));      // 2  Divides the left operand by the right. Integer division truncates the decimal, To get decimal results, use double or float.
           Console.WriteLine("Modulus: " + (x % y));       // 2   Returns the remainder after division ,Use case: Check if a number is even or odd */



        /*  //All Comparison Operators in One Example

              int a = 10;
              int b = 20;

              Console.WriteLine("a = " + a);
              Console.WriteLine("b = " + b);
              Console.WriteLine("------------------------------");

              // 1. Equal to
              Console.WriteLine("a == b : " + (a == b));  // False

              // 2. Not equal to
              Console.WriteLine("a != b : " + (a != b));  // True

              // 3. Greater than
              Console.WriteLine("a > b  : " + (a > b));   // False

              // 4. Less than
              Console.WriteLine("a < b  : " + (a < b));   // True

              // 5. Greater than or equal to
              Console.WriteLine("a >= b : " + (a >= b));  // False

              // 6. Less than or equal to
              Console.WriteLine("a <= b : " + (a <= b));  // True  */



        /*   // All Conditional Operators in One Program
           int age = 22;
               bool isStudent = true;

               // Logical AND
               if (age < 30 && isStudent)
                   Console.WriteLine("Young student");

               // Logical OR
               if (age < 18 || age > 60)
                   Console.WriteLine("Either too young or senior");

               // Logical NOT
               if (!isStudent)
                   Console.WriteLine("Not a student");
               else
                   Console.WriteLine("Confirmed: Student");

                */

        //Ternary Operators
        int Number = 15;
        bool IsNumber10 = Number == 10 ? true : false;
        Console.WriteLine("Number == 10 is {0}", IsNumber10);
     
    }
}









