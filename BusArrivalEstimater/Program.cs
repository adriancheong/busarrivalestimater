using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusArrivalEstimater
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args == null || args.Length == 0)
            {
                args = getInputFromUser();
            }
        }

        private static string[] getInputFromUser()
        {
            throw new NotImplementedException();
        }
    }
}
