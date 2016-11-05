using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunnersCalculations
{
    public class Class1
    {
        public double CalculatedTime(double givenTime, double givenDistance, double distanceToPredict)
        {
            return givenTime * (distanceToPredict / givenDistance) * 1.06;
        }
    }
}
