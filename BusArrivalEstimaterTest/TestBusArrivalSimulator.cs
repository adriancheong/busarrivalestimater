﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusArrivalEstimater;

namespace BusArrivalEstimaterTest
{
    [TestClass]
    public class TestBusArrivalSimulator
    {
        private static readonly double delta = 0.01;

        [TestMethod]
        public void TestMethod1()
        {
            string[] busTimes = { "2", "4", "6" };
            double expected = 0.545455;

            BusArrivalSimulator busArrivalSimulator = new BusArrivalSimulator();
            double actual = busArrivalSimulator.waitForBus(busTimes);

            Assert.AreEqual(expected, actual, delta);
        }

        [TestMethod]
        public void TestMethod2()
        {
            string[] busTimes = { "1" };
            double expected = 0.5;

            BusArrivalSimulator busArrivalSimulator = new BusArrivalSimulator();
            double actual = busArrivalSimulator.waitForBus(busTimes);

            Assert.AreEqual(expected, actual, delta);
        }

        [TestMethod]
        public void TestMethod3()
        {
            string[] busTimes = { "2" };
            double expected = 1;

            BusArrivalSimulator busArrivalSimulator = new BusArrivalSimulator();
            double actual = busArrivalSimulator.waitForBus(busTimes);

            Assert.AreEqual(expected, actual, delta);
        }

        [TestMethod]
        public void TestMethod4()
        {
            string[] busTimes = { "2", "4" };
            double expected = 0.666667;

            BusArrivalSimulator busArrivalSimulator = new BusArrivalSimulator();
            double actual = busArrivalSimulator.waitForBus(busTimes);

            Assert.AreEqual(expected, actual, delta);
        }

        [TestMethod]
        public void TestMethod5()
        {
            string[] busTimes = { "2", "10" };
            double expected = 0.833333;

            BusArrivalSimulator busArrivalSimulator = new BusArrivalSimulator();
            double actual = busArrivalSimulator.waitForBus(busTimes);

            Assert.AreEqual(expected, actual, delta);
        }

        [TestMethod]
        public void TestMethod6()
        {
            string[] busTimes = { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            double expected = 0.176743;

            BusArrivalSimulator busArrivalSimulator = new BusArrivalSimulator();
            double actual = busArrivalSimulator.waitForBus(busTimes);

            Assert.AreEqual(expected, actual, delta);
        }

        [TestMethod]
        public void TestMethod7()
        {
            string[] busTimes = { "1", "9" };
            double expected = 0.45;

            BusArrivalSimulator busArrivalSimulator = new BusArrivalSimulator();
            double actual = busArrivalSimulator.waitForBus(busTimes);

            Assert.AreEqual(expected, actual, delta);
        }

        [TestMethod]
        public void TestMethod8()
        {
            string[] busTimes = { "4", "8", "12" };
            double expected = 1.090909;

            BusArrivalSimulator busArrivalSimulator = new BusArrivalSimulator();
            double actual = busArrivalSimulator.waitForBus(busTimes);

            Assert.AreEqual(expected, actual, delta);
        }

        [TestMethod]
        public void TestMethod9()
        {
            string[] busTimes = { "3" };
            double expected = 1.5;

            BusArrivalSimulator busArrivalSimulator = new BusArrivalSimulator();
            double actual = busArrivalSimulator.waitForBus(busTimes);

            Assert.AreEqual(expected, actual, delta);
        }

        [TestMethod]
        public void TestMethod10()
        {
            string[] busTimes = { "2", "2" };
            double expected = 0.5;

            BusArrivalSimulator busArrivalSimulator = new BusArrivalSimulator();
            double actual = busArrivalSimulator.waitForBus(busTimes);

            Assert.AreEqual(expected, actual, delta);
        }

        [TestMethod]
        public void TestMethod102()
        {
            string[] busTimes = { "2", "2", "2" };
            double expected = 0.333333;

            BusArrivalSimulator busArrivalSimulator = new BusArrivalSimulator();
            double actual = busArrivalSimulator.waitForBus(busTimes);

            Assert.AreEqual(expected, actual, delta);
        }

        [TestMethod]
        public void TestMethod103()
        {
            string[] busTimes = { "2", "2", "2", "2" };
            double expected = 0.25;

            BusArrivalSimulator busArrivalSimulator = new BusArrivalSimulator();
            double actual = busArrivalSimulator.waitForBus(busTimes);

            Assert.AreEqual(expected, actual, delta);
        }

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

        [TestMethod]
        public void TestMethod14()
        {
            string[] busTimes = { "2", "4" };
            double expected = 0.666667;

            BusArrivalSimulator busArrivalSimulator = new BusArrivalSimulator();
            double actual = busArrivalSimulator.waitForBus(busTimes);

            Assert.AreEqual(expected, actual, delta);
        }

        [TestMethod]
        public void TestMethod15()
        {
            string[] busTimes = { "1", "2" };
            double expected = 0.333333;

            BusArrivalSimulator busArrivalSimulator = new BusArrivalSimulator();
            double actual = busArrivalSimulator.waitForBus(busTimes);

            Assert.AreEqual(expected, actual, delta);
        }

        [TestMethod]
        public void TestMethod16()
        {
            string[] busTimes = { "5", "10" };
            double expected = 1.666667;

            BusArrivalSimulator busArrivalSimulator = new BusArrivalSimulator();
            double actual = busArrivalSimulator.waitForBus(busTimes);

            Assert.AreEqual(expected, actual, delta);
        }

        [TestMethod]
        public void earliestBusCannotBeLongerThanFastestBus()
        {
            int[] busTimes = { 1, 1, 1 };
            
            BusArrivalSimulator busArrivalSimulator = new BusArrivalSimulator();
            double actual = busArrivalSimulator.simulateABusComingNTimes(busTimes, 1);

            Assert.IsTrue(actual <= 1);
        }

        [TestMethod]
        public void earliestBusCannotBeLongerThanFastestBus2()
        {
            int[] busTimes = { 1, 60, 999 };

            BusArrivalSimulator busArrivalSimulator = new BusArrivalSimulator();
            double actual = busArrivalSimulator.simulateABusComingNTimes(busTimes, 1);

            Assert.IsTrue(actual <= 1);
        }
    }
}
