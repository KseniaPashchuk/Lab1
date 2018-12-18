using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Laba1.model;
using System.Threading.Tasks;

namespace Laba1.collection
{
    public class TrainCollection
    {
        private List<Train> trainList;

        public List<Train> TrainList { get => trainList; set => trainList = value; }

        public TrainCollection()
        {
            this.TrainList = new List<Train>();
        }
        
        public TrainCollection(List<Train> trainList)
        {
            this.TrainList = trainList;
        }

        public override bool Equals(object obj)
        {
            var collection = obj as TrainCollection;
            return collection != null &&
                   TrainList.SequenceEqual(collection.TrainList);
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            foreach (Train train in TrainList)
            {
                result.Append(train.ToString());
                result.Append("/n");                
            }
            return result.ToString();
        }

        public override int GetHashCode()
        {
            return 272706397 + EqualityComparer<List<Train>>.Default.GetHashCode(TrainList);
        }

        public void AddTrain(Train train)
        {
            this.TrainList.Add(train);
        }
        
        public List<Train> GetTrainByNumber(int trainNumber)
        {
            List<Train> results = new List<Train>();
            foreach (Train train in TrainList)
            {
                if (train.TrainNumber.Equals(trainNumber))
                {
                    results.Add(train);
                }

            }
            return results;
        }

        //point a
        public List<Train> GetTrainByDestinationPoint(string destinationPoint)
        {
            List<Train> results = new List<Train>();
            foreach (Train train in TrainList)
            {
                if (train.DestinationPoint.Equals(destinationPoint))
                {
                    results.Add(train);
                }

            }
            return results;
        }


        //point b
        public List<Train> GetTrainByDestinationPointAndTime(string destinationPoint, TimeSpan departureTime)
        {
            List<Train> results = new List<Train>();
            foreach (Train train in TrainList)
            {
                if (train.DestinationPoint.Equals(destinationPoint) && train.DepartureTime.TimeOfDay > departureTime)
                {
                    results.Add(train);
                }

            }
            return results;
        }

        //point c
        public List<Train> GetTrainByDestinationPointAndHaveGeneralSeats(string destinationPoint)
        {
            List<Train> results = new List<Train>();
            foreach (Train train in TrainList)
            {
                if (train.DestinationPoint.Equals(destinationPoint) && train.NumberOfSeats.GeneralSeats > 0)
                {
                    results.Add(train);
                }

            }
            return results;
        }

    }
}
