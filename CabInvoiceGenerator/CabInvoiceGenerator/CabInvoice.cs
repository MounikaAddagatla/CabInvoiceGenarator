using System;
using System.Collections.Generic;
using System.Text;

namespace CabInvoiceGenerator
{
   public class CabInvoice
   {
        private static double COST_PER_KILOMETER = 10.0;
        private static double COST_PER_MINUTE = 1.0;
        private static double MINIMUM_FARE = 5.0;
        private double cabFare =0.0;

        // ***passing parameter values of distance and time for calu cabFare **//
        public double CalculateFare(double distance, double time)
        {
            this.cabFare =(distance * COST_PER_KILOMETER) + (time * COST_PER_MINUTE);
            // cbf = 5*10  +  15*1  ====50 +15=65
            return Math.Max(this.cabFare, MINIMUM_FARE);
        }
        //calculate multiple fare
        public double CalculateMultipleRideFare(List<Ride> rides)
        {
            double cabFare = 0.0;
            foreach (Ride ride in rides)
            {
                // Calculate total fare and return it
                cabFare += this.CalculateFare(ride.distance, ride.time);
            }
            return cabFare / rides.Count;
        }
       
    }
}
