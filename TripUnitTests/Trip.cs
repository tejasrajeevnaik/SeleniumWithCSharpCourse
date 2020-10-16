using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripUnitTests
{
    class Trip
    {
        // Private variables
        private int totalDistanceTravelled;
        private int totalCostOfGasoline;
        private int totalNumberOfGallons;

        // Constructor
        public Trip(string destination, int totalDistanceTravelled, int totalCostOfGasoline, int totalNumberOfGallons)
        {
            Destination = destination;
            TotalDistanceTravelled = totalDistanceTravelled;
            TotalCostOfGasoline = totalCostOfGasoline;
            TotalNumberOfGallons = totalNumberOfGallons;
        }

        // Properties
        public string Destination
        {
            get;
            set;
        }

        public int TotalDistanceTravelled
        {
            get { return totalDistanceTravelled; }
            set
            { 
                if(value > 0)
                {
                    totalDistanceTravelled = value;
                }
                else
                {
                    totalDistanceTravelled = 0;
                }
            }
        }

        public int TotalCostOfGasoline
        {
            get { return totalCostOfGasoline; }
            set
            {
                if (value > 0)
                {
                    totalCostOfGasoline = value;
                }
                else
                {
                    totalCostOfGasoline = 0;
                }
            }
        }

        public int TotalNumberOfGallons
        {
            get { return totalNumberOfGallons; }
            set
            {
                if (value > 0)
                {
                    totalNumberOfGallons = value;
                }
                else
                {
                    totalNumberOfGallons = 0;
                }
            }
        }

        // Methods
        public float GetMilesPerGallon()
        {
            return (float)TotalDistanceTravelled / (float)TotalNumberOfGallons;
        }

        public float GetCostPerMile()
        {
            return (float)TotalCostOfGasoline / (float)TotalDistanceTravelled;
        }

        public override string ToString()
        {
            return $"Trip summary: Destination - {Destination}, Total distance travelled - {TotalDistanceTravelled} miles, Total cost of gasoline - ${TotalCostOfGasoline}, Total number of gallons - {TotalNumberOfGallons}";
        }
    }
}
