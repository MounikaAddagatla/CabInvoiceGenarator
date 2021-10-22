using System;
using System.Collections.Generic;

namespace CabInvoiceGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" This is Cab Invoice Generator For caluclate Monthly SubScription");
            CabInvoice cabInvoice = new CabInvoice();
            Console.WriteLine(cabInvoice.CalculateFare(5.0, 15.0));
            // caluclate multiple ride 
            List<Ride> rides = new List<Ride>();
            Ride r1 = new Ride(1.0, 5);
            Ride r2 = new Ride(3.0, 5);
            Ride r3 = new Ride(4.0, 5);
            Ride r4 = new Ride(5.0, 5);

            rides.Add(r1);
            rides.Add(r2);
            rides.Add(r3);
            rides.Add(r4);
            Console.WriteLine(cabInvoice.CalculateMultipleRideFare(rides));
            InvoiceSummary invoice = cabInvoice.CalculateMultipleRideFareSummary(rides);
            Console.WriteLine($"Total no.of Rides: {invoice.noOfRides}\nTotal Fare: {invoice.totalRideFare}\nAverage Fare Per Ride: {invoice.averageFarePerRide}\n");
            Console.ReadLine();
        }
    }
}
