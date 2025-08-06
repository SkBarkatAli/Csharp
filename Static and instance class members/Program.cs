using System;

class Circle
{
    public static float _PI = 3.141F;   // static members are invoked using the name of the class. 
    int _Redius;               // And instance members are in the grup usingh an instance or object of the class thats why they are called as instance members


    static Circle()   //->static doesnt allow access modifiers and a static keyword in that and satatic
                      //constructors i used to initialize static fields and static constructors are called befor instance constructors are called even before you refer to any static filed.
    {
        Console.WriteLine("static constractor called");
        Circle._PI = 3.141F;   
    }
    public Circle(int Radius)
    {
        Console.WriteLine("instance constractor called");
        this._Redius = Radius;
    }


    public float CalculateArea()
    {
        return Circle._PI * this._Redius * this._Redius;
    }
}


 class Program
    {
       public static void Main()
        {
        Circle C1 = new Circle(5);
        float Area = C1.CalculateArea();

        Console.WriteLine("Area is = {0}",Area);

        Circle C2 = new Circle(6);
        float Area2 = C2.CalculateArea();

        Console.WriteLine("Area is = {0}", Area2);

    }
}

