using CabInvoiceGenerator;
using NUnit.Framework;
using System.Collections.Generic;

namespace CanInvoiceGeneratorTest
{
    public class CabInvoiceTest
    {
        private CabInvoice cabInvoice;

     
        [SetUp]
        public void Setup()
        {
            this.cabInvoice = new CabInvoice();
        }

        
        [Test]
        public void GivenDistanceAndTime_WhenProper_ShouldReturnTotalFare()
        {
            double totalFare = this.cabInvoice.CalculateFare(5.0, 15.0);
            Assert.AreEqual(65, totalFare);
        }

      

        /// <summary>
        /// Test to get total fare for Multiple Rides.
        /// </summary>
        [Test]
        public void GivenDistanceAndTimeForCaluclateMultipleRideFare_WhenProper_ShouldReturnRideFair()
        {
            List<Ride> rides = new List<Ride>();
            Ride r1 = new Ride(2.0, 5);
            Ride r2 = new Ride(3.0, 5);
            Ride r3 = new Ride(4.0, 5);
            Ride r4 = new Ride(5.0, 5);
            rides.Add(r1);
            rides.Add(r2);
            rides.Add(r3);
            rides.Add(r4);

            double cabFair =this.cabInvoice.CalculateMultipleRideFare(rides);
            Assert.AreEqual(40.0, cabFair);
        }
      
    }
}