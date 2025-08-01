using System;
class Program
{
    static void Main()
    {
        //string name = null; //Already nullable (reference type)
        // int i = null; // Cannot convert null to 'type' because it is a non-nullable value type
        // int? i = null; //that makes is nullable data type.



        /*  bool? AreYouMajor = null;
          if (AreYouMajor == true)
          {
              Console.WriteLine("User is major");
          }
          else if (AreYouMajor == false)
          {
              Console.WriteLine("user is Not Major");
          }
          else
          { Console.WriteLine("User did not answer the Question"); } */



        //Null Coalesing Operator-------------->



      /*  // using without Null Coalesing Operator
        int? TicketOnSale = 0;
        int AvailableTickers;
        if (TicketOnSale == null)
        {
            AvailableTickers = 0;
        }
        else {
            AvailableTickers =(int) TicketOnSale;  // the cast operator (for conversion-nullble data type to be converted into
                                                   // non nullable data type)
            // AvailableTickers = TicketOnSale.Value; // we can also use it

        }
        Console.WriteLine("AvailableTickets = {0}", AvailableTickers);   */






        // using Null Coalesing Operator

        int ? TicketOnSale = 0;

        int AvaialableTickets = TicketOnSale ?? 0;

        Console.WriteLine("AvailableTickets = {0}", AvaialableTickets);

    }

}