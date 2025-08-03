//passing a parameter by value.
/*using System;
 class Program
    {
        public static void Main()
        {
           int i  = 0;       
        SimpleMethod(i);
        Console.WriteLine(i); //o.p = 0           // I and J are pointing to different memory locations. Operations one 
                                      //variable will not affect the value of the other variable.
       
        }

       public static void SimpleMethod(int j)
    {
        j = 101;
    }
    }*/



//passing a parameter by reference.
/*using System;
class Program
{
    public static void Main()
    {
        int i = 0;
        SimpleMethod(ref i);
        Console.WriteLine( i);  // o.p= 101       
                                                
    }                            //i and j are pointing to the same memory location. Operations one variable 
                                 // will affect the value of the other variable.
    public static void SimpleMethod(ref int j)
    {
        j = 101;
    }
}*/





//passing a parameter by Out Parameters
/*using System;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Security.Policy;
class Program
{
    public static void Main()
    {
        int Total = 0;
        int Product = 0;

        Calculate(10, 20, out Total, out Product);

        Console.WriteLine("Sum = {0} && Product = {1}",Total,Product);

    }
//✅ You don’t have to initialize the variable before passing it.

//✅ The method must assign a value to the out parameter.

//✅ The value will be available to the caller after the method returns.

//✅ Multiple out parameters can be used in one method (to return multiple values).


    public static void Calculate(int FN, int SN, out int Sum, out int Product)
    {
        Sum = FN + SN;
       Product = FN * SN;
    }
}*/







//passing a parameter by Out Parameters
using System;
class Program
{
    public static void Main()
    {
        int[] Numbers = new int[3];

        Numbers[0] = 101;
        Numbers[1] = 102;
        Numbers[2] = 103;

        //ParamsMethod();
       // ParamsMethod(Numbers);
       ParamsMethod(1, 2, 3 ,4 ,5); // when we pass values rhose values are called as Arguments for those parameters
    }
    
    public static void ParamsMethod(params int[] Numbers) // method parameter is (params int[] Numbers)  


                                                            // if your method is going to have multiple parameters
    {                                                      // the parameters array should be the last one in that parameter list.(public static void ParamsMethod(int x, params int[] Numbers)){}.
                                                           // You can only have one parameter as a parameter arry. you can not have parameter array.(params int[] Numbers ,params string[] Names)-> can not do that.
        Console.WriteLine("There asre {0} elements", Numbers.Length);
            foreach(int i in Numbers)
        {
            Console.WriteLine(i);
        }
    }

    
}