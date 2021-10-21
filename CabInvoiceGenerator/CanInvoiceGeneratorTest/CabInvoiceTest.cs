using CabInvoiceGenerator;
using NUnit.Framework;

namespace CanInvoiceGeneratorTest
{
    public class CabInvoiceTest
    {
        public CabInvoice CabInvoice { get; private set; }

        [SetUp]
        public void Setup()
        {
            this.CabInvoice = new CabInvoice();
        }

        [Test]
        public void GivenDistanceAndTime_WhenCaluclate_ShouldReturnTotalFare()
        {
            double totalFare = this.CabInvoice.CalculateFare(5, 15);
            Assert.AreEqual(65, totalFare);
        }
    }
}