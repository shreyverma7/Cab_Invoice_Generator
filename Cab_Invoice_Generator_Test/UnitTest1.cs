using Cab_Invoice_Generator;

namespace Cab_Invoice_Generator_Test
{
    public class Tests
    {
       

       
            [Test]
            public void GivenDistanceAndTimeWhenCheckedReturnFareValue()
            {
                InvoiceService invoiceservice = new InvoiceService();
                double actual = invoiceservice.CalculateFare(10, 5);
                double expected = 105;
                Assert.AreEqual(actual, expected);

            }
      
    }
}