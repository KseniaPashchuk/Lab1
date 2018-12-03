using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1.model
{
    public class Train
    {
        private String destinationPoint;
        private int trainNumber;
        private DateTime departureTime;
        private SeatsNumber numberOfSeats;         

        public class SeatsNumber
        {
            private int generalSeats;
            private int coupeSeats;
            private int luxSeats;
            private int reservedSeats;

            public SeatsNumber()
            {
            }

            public SeatsNumber(int generalSeats, int coupeSeats, int luxSeats, int reservedSeats)
            {
                GeneralSeats = generalSeats;
                CoupeSeats = coupeSeats;
                LuxSeats = luxSeats;
                ReservedSeats = reservedSeats;
            }

            public int GeneralSeats { get => generalSeats; set => generalSeats = value; }
            public int CoupeSeats { get => coupeSeats; set => coupeSeats = value; }
            public int LuxSeats { get => luxSeats; set => luxSeats = value; }
            public int ReservedSeats { get => reservedSeats; set => reservedSeats = value; }

            public override string ToString()
            {
                StringBuilder result = new StringBuilder();
                result.Append("general: " + GeneralSeats + ", ");
                result.Append("coupe: " + CoupeSeats + ", ");
                result.Append("lux: " + LuxSeats + ", ");
                result.Append("reserved seats: " + ReservedSeats + "; ");

                return result.ToString();
            }
        }

        public string DestinationPoint { get => destinationPoint; set => destinationPoint = value; }
        public int TrainNumber { get => trainNumber; set => trainNumber = value; }
        public SeatsNumber NumberOfSeats { get => numberOfSeats; set => numberOfSeats = value; }
        public DateTime DepartureTime { get => departureTime; set => departureTime = value; }

        public Train()
        {
        }

        public Train(string destinationPoint, int trainNumber, DateTime departureTime)
        {
            DestinationPoint = destinationPoint;
            TrainNumber = trainNumber;
            DepartureTime = departureTime;
        }

        public Train(string destinationPoint, int trainNumber, DateTime departureTime, int generalSeats, int coupeSeats, int luxSeats, int reservedSeats)
        {
            DestinationPoint = destinationPoint;
            TrainNumber = trainNumber;
            DepartureTime = departureTime;
            NumberOfSeats = new SeatsNumber(generalSeats, coupeSeats, luxSeats, reservedSeats);
        }
                     

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append("Train: ");
            result.Append("Number: " + TrainNumber + ", ");
            result.Append("Destination point: " + DestinationPoint + ", ");
            result.Append("Departure time: " + DepartureTime + ", ");
            result.Append("Number of seats: " + NumberOfSeats  + "; ");

            return result.ToString();
        }

        public override int GetHashCode()
        {
            var hashCode = 584242990;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(DestinationPoint);
            hashCode = hashCode * -1521134295 + TrainNumber.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<SeatsNumber>.Default.GetHashCode(NumberOfSeats);
            hashCode = hashCode * -1521134295 + DepartureTime.GetHashCode();
            return hashCode;
        }

        public override bool Equals(object obj)
        {
            var train = obj as Train;
            return train != null &&
                   DestinationPoint == train.DestinationPoint &&
                   TrainNumber == train.TrainNumber &&
                   EqualityComparer<SeatsNumber>.Default.Equals(NumberOfSeats, train.NumberOfSeats) &&
                   DepartureTime == train.DepartureTime;
        }
    }
}
