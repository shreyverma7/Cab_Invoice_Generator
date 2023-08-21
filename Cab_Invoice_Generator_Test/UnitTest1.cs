using Cab_Invoice_Generator;
using Cab_Invoice_Generator_problem;

namespace Cab_Invoice_Generator_Test
{
    public class Tests
    {

        InvoiceService invoiceservice = new InvoiceService();
        [Test]
        public void GivenDistanceAndTime_WhenChecked_ReturnFareValue()
        {
            double actual = invoiceservice.CalculateFare(10, 5);
            double expected = 105;
            Assert.AreEqual(actual, expected);
        }
        [Test]
        public void GivenRides_WhenChecked_ReturnFareValue()
        {
            Ride[] ride =
            {
                new Ride(){Distance = 10,Time = 5}
            };
            double actual = invoiceservice.CalculateFare(ride);
            double expected = 105;
            Assert.AreEqual(actual, expected);
        }




    }
}