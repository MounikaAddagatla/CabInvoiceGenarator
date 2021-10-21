using System;

namespace CabInvoiceGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" This is Cab Invoice Generator For caluclate Monthly SubScription");
            CabInvoice cabInvoice = new CabInvoice();
           Console.WriteLine( cabInvoice.CalculateFare(5, 15));
           
            Console.ReadLine();
        }
    }
}
