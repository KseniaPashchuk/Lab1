using NUnit.Framework;
using Laba1.model;
using Laba1.collection;
using System;
using System.Collections.Generic;

namespace Tests
{
    public class Tests
    {
        private TrainCollection trainList;
        [SetUp]
        public void Setup()
        {

            trainList = new TrainCollection();
            trainList.addTrain(new Train("Sunny Valley", 1, new DateTime(2018, 2, 3, 9, 30, 00), 0, 10, 13, 1));
            trainList.addTrain(new Train("BSU", 2, new DateTime(2018, 7, 21, 11, 15, 00), 0, 1, 0, 15));
            trainList.addTrain(new Train("RAM", 3, new DateTime(2018, 9, 20, 18, 30, 00), 12, 8, 0, 0));
            trainList.addTrain(new Train("BSU", 4, new DateTime(2018, 1, 7, 10, 00, 00), 9, 1, 3, 1));
            trainList.addTrain(new Train("Sunny Valley", 5, new DateTime(2018, 4, 20, 8, 20, 00), 9, 8, 0, 1));
        }

        [Test]
        public void test_getTrainByDestinationPoint()
        {
            List<Train> test1 = trainList.getTrainByDestinationPoint("Sunny Valley");
            Assert.AreEqual(2, test1.Count);
        }

        [Test]
        public void test_getTrainByDestinationPointAndTime()
        {
            List<Train> test1 = trainList.getTrainByDestinationPointAndTime("Sunny Valley", new TimeSpan(9, 00, 00));
            Assert.AreEqual(1, test1.Count);
        }

        [Test]
        public void test_getTrainByDestinationPointAndHaveGeneralSeats()
        {
            List<Train> test1 = trainList.getTrainByDestinationPoint("Sunny Valley");
            Assert.AreEqual(2, test1.Count);
        }
    }
}