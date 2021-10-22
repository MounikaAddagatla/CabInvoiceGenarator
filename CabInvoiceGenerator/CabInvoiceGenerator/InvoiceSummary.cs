using System;
using System.Collections.Generic;
using System.Text;

namespace CabInvoiceGenerator
{
   public class InvoiceSummary
   {
        public double totalRideFare;
        public int noOfRides;
        public double averageFarePerRide;


        // UC 3 Initializes a new instance of the <see cref="InvoiceSummary"/> class.
        public InvoiceSummary(double totalRideFare, int noOfRides)
        {
            this.totalRideFare = totalRideFare;
            this.noOfRides = noOfRides;
            this.averageFarePerRide = this.totalRideFare / this.noOfRides;
        }

        // Returns a hash code for this instance.
        // A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. 
        //public override int GetHashCode()
        //{
        //    return this.totalRideFare.GetHashCode() ^ this.noOfRides.GetHashCode() ^ this.averageFarePerRide.GetHashCode();
        //}
    }
}
