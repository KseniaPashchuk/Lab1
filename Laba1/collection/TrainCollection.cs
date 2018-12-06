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

        public TrainCollection()
        {
            this.trainList = new List<Train>();
        }
        
        public TrainCollection(List<Train> trainList)
        {
            this.trainList = trainList;
        }

        public override bool Equals(object obj)
        {
            var collection = obj as TrainCollection;
            return collection != null &&
                   EqualityComparer<List<Train>>.Default.Equals(trainList, collection.trainList);
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            foreach (Train train in trainList)
            {
                result.Append(train.ToString());
                result.Append("/n");                
            }
            return result.ToString();
        }

        public override int GetHashCode()
        {
            return 272706397 + EqualityComparer<List<Train>>.Default.GetHashCode(trainList);
        }

        public void AddTrain(Train train)
        {
            this.trainList.Add(train);
        }
        
        public List<Train> GetTrainByNumber(int trainNumber)
        {
            List<Train> results = new List<Train>();
            foreach (Train train in trainList)
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
            foreach (Train train in trainList)
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
            foreach (Train train in trainList)
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
            foreach (Train train in trainList)
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
