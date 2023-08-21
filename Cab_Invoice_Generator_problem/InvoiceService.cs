using Cab_Invoice_Generator_problem;

namespace Cab_Invoice_Generator
{
    public class InvoiceService
    {
        private readonly int costPerKilometerNormal = 10;
        private readonly int minimumFareNormal = 5;
        private readonly int costPerMinuteNormal = 1;
        public int totalNumOfRides = 0;
        public double totalFare = 0;
        public double averageFare = 0;

        public int TotalNumOfRides()
        {
            return totalNumOfRides;
        }
        public double TotalFare()
        {
            return totalFare;
        }
        public double AverageFare()
        {
            return averageFare;
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
            foreach (var ride in rides) 
            {
                totalFare += ride.Distance * costPerKilometerNormal + ride.Time * costPerMinuteNormal;
            }
            totalNumOfRides = rides.Length;
           averageFare = totalFare / totalNumOfRides;
            return averageFare;

        }
    }
}