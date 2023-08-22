using Cab_Invoice_Generator_problem;

namespace Cab_Invoice_Generator
{
    public class InvoiceService
    {
        private readonly int costPerKilometerNormal = 10;
        private readonly int minimumFareNormal = 5;
        private readonly int costPerMinuteNormal = 1;
        private readonly int costPerKilometerPremium = 15;
        private readonly int minimumFarePremium = 20;
        private readonly int costPerMinutePremium = 2;
        private const string NORMAL = "NORMAL";
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
        public double CalculateFare(string rideType,double distance , double time)
        {
            double TotalAmount = 0;
            if (rideType.Equals(NORMAL))
            {
                TotalAmount = distance * costPerKilometerNormal + time * costPerMinuteNormal;
                if (TotalAmount > minimumFareNormal)
                {
                    return TotalAmount;
                }
                return minimumFareNormal;
            }
            TotalAmount = distance * costPerKilometerPremium + time * costPerMinutePremium;
            if (TotalAmount > minimumFarePremium)
            {
                return TotalAmount;
            }
            return minimumFarePremium;

        }
        public double CalculateFare(Ride[] rides)
        {
            totalFare = 0;
            foreach (var ride in rides) 
            {
                totalFare += CalculateFare(ride.RideType, ride.Distance, ride.Time);
            }
            totalNumOfRides = rides.Length;
           averageFare = totalFare / totalNumOfRides;
            return totalFare;
        }
    }
}