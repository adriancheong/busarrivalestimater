using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusArrivalEstimater
{
    public class BusArrivalSimulator
    {
        private static readonly int NO_OF_SIMLUATIONS = 100000;
        private static readonly int NO_OF_THREADS = 4;

        public double waitForBus(string[] busTimesString)
        {
            int[] busTimes = convertBusTimesToInt(busTimesString);
            double sum = 0;

            Task<double>[] tasks = new Task<double>[NO_OF_THREADS];
            for (int i = 0; i < tasks.Length; i++)
            {
                tasks[i] = Task.Run<double>(() => simulateABusComingNTimes(busTimes, NO_OF_SIMLUATIONS/NO_OF_THREADS));
            }

            for (int i = 0; i < tasks.Length; i++)
            {
                sum += tasks[i].Result;
            }

            return sum / (double)NO_OF_SIMLUATIONS;
        }

        public double simulateABusComingNTimes(int[] busTimes, int noOfSimulations)
        {
            double sum = 0;
            for (int i = 0; i < noOfSimulations; i++)
            {
                var waitTime = simulateABusComing(busTimes);
                System.Diagnostics.Debug.WriteLine("Average " + sum/i);
                sum += waitTime;
            }
            return sum;
        }

        private double simulateABusComing(int[] busTimes)
        {
            double earliestBusThatCame = double.MaxValue;
            foreach (int busTime in busTimes)
            {
                double randomBusTimeForThisBus = generateARandomNumberBetweenZeroAndThisBusTime(busTime);
                if (randomBusTimeForThisBus < earliestBusThatCame)
                    earliestBusThatCame = randomBusTimeForThisBus;
            }

            return earliestBusThatCame;
        }

        private double generateARandomNumberBetweenZeroAndThisBusTime(int busTime)
        {
            Random random = new Random(Guid.NewGuid().GetHashCode());
            return random.NextDouble() * busTime;
        }

        private int[] convertBusTimesToInt(string[] busTimesString)
        {
            return Array.ConvertAll<string, int>(busTimesString, int.Parse);
        }
    }
}
