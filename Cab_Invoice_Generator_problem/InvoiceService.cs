using Cab_Invoice_Generator_problem;

namespace Cab_Invoice_Generator
{
    public class InvoiceService
    {
        private readonly int costPerKilometerNormal = 10;
        private readonly int minimumFareNormal = 5;
        private readonly int costPerMinuteNormal = 1;


        public int NumberOfRides
        {
            get
            {
                return this.NumberOfRides;
            }
        }
        public double CalculateFare(double distance , double time)
        {
            double TotalAmount = distance * costPerKilometerNormal + time * costPerMinuteNormal;
            if(TotalAmount > minimumFareNormal) 
            {
                return TotalAmount;
            }
            return minimumFareNormal;
        }
        public double CalculateFare(Ride[] rides)
        {
            double totalAmount = 0; 
            foreach (var ride in rides) 
            {
                totalAmount += ride.Distance * costPerKilometerNormal + ride.Time * costPerMinuteNormal;
            }
            int numOfRides = rides.Length;
            double aggregateAmount = totalAmount / numOfRides;
            return aggregateAmount;

        }
    }
}