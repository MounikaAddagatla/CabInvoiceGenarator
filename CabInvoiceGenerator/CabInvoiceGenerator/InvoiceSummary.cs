using System;
using System.Collections.Generic;
using System.Text;

namespace CabInvoiceGenerator
{
    class InvoiceSummary
    {
        public double totalFare;
        public double averageFare;
        public int noOfRides;

        public InvoiceSummary(double totalFare, int noOfRides)
        {
            this.totalFare = totalFare;
            this.noOfRides = noOfRides;
            this.averageFare = this.totalFare / this.noOfRides;
        }

        public override bool Equals(object invoiceSummary)
        {
            if (invoiceSummary == null)
            {
                return false;
            }
            return invoiceSummary is InvoiceSummary summary &&
                   this.totalFare == summary.totalFare &&
                   this.averageFare == summary.averageFare &&
                   this.noOfRides == summary.noOfRides;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(this.totalFare, this.averageFare, this.noOfRides);
        }
    }
}
