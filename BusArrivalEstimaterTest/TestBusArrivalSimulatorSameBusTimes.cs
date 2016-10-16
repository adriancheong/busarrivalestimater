using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusArrivalEstimater;

namespace BusArrivalEstimaterTest
{
    [TestClass]
    public class TestBusArrivalSimulatorSameBusTimes
    {
        private static readonly double delta = 0.01;

        [TestMethod]
        public void TestOnes1()
        {
            string[] busTimes = { "1" };
            double expected = 0.5;

            BusArrivalSimulator busArrivalSimulator = new BusArrivalSimulator();
            double actual = busArrivalSimulator.waitForBus(busTimes);

            Assert.AreEqual(expected, actual, delta);
        }

        [TestMethod]
        public void TestOnes2()
        {
            string[] busTimes = { "1", "1" };
            double expected = 0.333333;

            BusArrivalSimulator busArrivalSimulator = new BusArrivalSimulator();
            double actual = busArrivalSimulator.waitForBus(busTimes);

            Assert.AreEqual(expected, actual, delta);
        }

        [TestMethod]
        public void TestOnes3()
        {
            string[] busTimes = { "1", "1", "1" };
            double expected = 0.25;

            BusArrivalSimulator busArrivalSimulator = new BusArrivalSimulator();
            double actual = busArrivalSimulator.waitForBus(busTimes);

            Assert.AreEqual(expected, actual, delta);
        }

        [TestMethod]
        public void TestOnes4()
        {
            string[] busTimes = { "1", "1", "1", "1" };
            double expected = 0.2;

            BusArrivalSimulator busArrivalSimulator = new BusArrivalSimulator();
            double actual = busArrivalSimulator.waitForBus(busTimes);

            Assert.AreEqual(expected, actual, delta);
        }

        [TestMethod]
        public void TestOnes5()
        {
            string[] busTimes = { "1", "1", "1", "1", "1" };
            double expected = 0.166667;

            BusArrivalSimulator busArrivalSimulator = new BusArrivalSimulator();
            double actual = busArrivalSimulator.waitForBus(busTimes);

            Assert.AreEqual(expected, actual, delta);
        }

        [TestMethod]
        public void TestOnes6()
        {
            string[] busTimes = { "1", "1", "1", "1", "1", "1" };
            double expected = 0.142857;

            BusArrivalSimulator busArrivalSimulator = new BusArrivalSimulator();
            double actual = busArrivalSimulator.waitForBus(busTimes);

            Assert.AreEqual(expected, actual, delta);
        }

        [TestMethod]
        public void TestOnes7()
        {
            string[] busTimes = { "1", "1", "1", "1", "1", "1", "1" };
            double expected = 0.125;

            BusArrivalSimulator busArrivalSimulator = new BusArrivalSimulator();
            double actual = busArrivalSimulator.waitForBus(busTimes);

            Assert.AreEqual(expected, actual, delta);
        }

        [TestMethod]
        public void TestOnes8()
        {
            string[] busTimes = { "1", "1", "1", "1", "1", "1", "1", "1" };
            double expected = 0.111111;

            BusArrivalSimulator busArrivalSimulator = new BusArrivalSimulator();
            double actual = busArrivalSimulator.waitForBus(busTimes);

            Assert.AreEqual(expected, actual, delta);
        }

        [TestMethod]
        public void TestOnes9()
        {
            string[] busTimes = { "1", "1", "1", "1", "1", "1", "1", "1", "1" };
            double expected = 0.1;

            BusArrivalSimulator busArrivalSimulator = new BusArrivalSimulator();
            double actual = busArrivalSimulator.waitForBus(busTimes);

            Assert.AreEqual(expected, actual, delta);
        }
    }
}
