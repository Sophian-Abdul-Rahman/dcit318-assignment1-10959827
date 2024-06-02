/* 
   Name: Sophian Abdul Rahman
   Student ID: 10959827
   Course: DCIT318 
*/
using System;

class TicketPriceCalculator
{
    static void Main()
    {
        Console.Write("Enter your age: ");
        int age = int.Parse(Console.ReadLine());

        int ticketPrice = (age <= 12 || age >= 65) ? 7 : 10;

        Console.WriteLine("Ticket Price: GHC" + ticketPrice);
    }
}
