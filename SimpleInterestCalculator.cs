using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestingInVisualStudio
{
    public class SimpleInterestCalculator
    {
        /// <summary>
        /// This class calculates the simple interest amount to be paid 
        /// given:-
        /// i = simeple interest
        /// p = principal 
        /// r = interest rate per year
        /// t = time in years
        /// a = amount
        /// </summary>

        public decimal SimpleInterestValue(decimal p, decimal r, int t)
        {
            decimal simpleInterestValueResult = 0.00m;

            simpleInterestValueResult = p * (r / 100) * t;

            return simpleInterestValueResult; 
        }

        public decimal SimpleInterestAmountValue(decimal p)
        {
            decimal simpleInterestAmountResult = 0.00m;

            simpleInterestAmountResult = p + SimpleInterestValue(1500, 12, 2);

            return simpleInterestAmountResult;
        }

    }
}
