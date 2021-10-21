using System;
using System.Collections.Generic;
using System.Text;

namespace CabInvoiceGenerator
{
   public class CabInvoice
   {
        private static int COST_PER_KILOMETER = 10;
        private static int COST_PER_MINUTE = 1;
        private static int MINIMUM_FARE = 5;
        private int cabFare = 0;

        // ***passing parameter values of distance and time for calu cabFare **//
        public int CalculateFare(int distance, int time)
        {
            this.cabFare =(distance * COST_PER_KILOMETER) + (time * COST_PER_MINUTE);
            // cbf = 5*10  +  15*1  ====50 +15=65
            return Math.Max(this.cabFare, MINIMUM_FARE);
        }
   }
}
