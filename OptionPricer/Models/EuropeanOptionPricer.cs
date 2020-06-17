using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace OptionPricer
{
    /// <summary>
    /// The class "EuropeanOptionPricer" describes the Euroean Option Pricer, it's derived from a based Class
    /// Named Pricer, we could implement other product pricer based on this extendable inheritence model
    /// </summary>
    public class EuropeanOptionPricer : Pricer
    {
        public int iPrecision { get; set; }
        public EuropeanOptionPricer(int iPrecision)
        {
            this.iPrecision = iPrecision;
        }

        /// <summary>
        /// The method "Price" is dedicated to compute the price of the European Call or Put 
        /// </summary>
        /// <param name=product>The product to be priced</param>
        /// <returns>The expected price</returns>
        public override double Price(FinancialProduct product)
        {
            double result = 0;

            EuropeanOption euroOption  = (product as EuropeanOption);
            if (euroOption != null)
            {
                //do something with it

                double d1 = (Log(euroOption.S / euroOption.K) + (euroOption.R + 0.5 * Pow(euroOption.Sigma, 2)) * euroOption.T) / (euroOption.Sigma * Sqrt(euroOption.T));
                double d2 = (Log(euroOption.S / euroOption.K) + (euroOption.R - 0.5 * Pow(euroOption.Sigma, 2)) * euroOption.T) / (euroOption.Sigma * Sqrt(euroOption.T));

                if (euroOption.OptionType == Constants.EuroOptionType.Call)
                {
                    result = (euroOption.S * Cndf(d1) - euroOption.K * Exp(-euroOption.R * euroOption.T) * Cndf(d2));
                }
                else if (euroOption.OptionType == Constants.EuroOptionType.Put)
                {
                    result = (euroOption.K * Exp(-euroOption.R * euroOption.T) * Cndf(-d2) - euroOption.S * Cndf(-d1));
                }
            }
            return Math.Round(result, iPrecision) ;
        }

        /// <summary>
        /// The method "Cndf" is the cumulative normal density function (CNDF) of a standard normal (Gaussian) random variable.
        /// </summary>
        /// <param name=x>The random attribute of the probability density function</param>
        /// <returns>The repartition function</returns>
        static double Cndf(double x)
        {
            // constants
            double a1 = 0.254829592;
            double a2 = -0.284496736;
            double a3 = 1.421413741;
            double a4 = -1.453152027;
            double a5 = 1.061405429;
            double p = 0.3275911;

            // Save the sign of x
            int sign = 1;
            if (x < 0)
                sign = -1;
            x = Math.Abs(x) / Math.Sqrt(2.0);

            // A&S formula 7.1.26
            double t = 1.0 / (1.0 + p * x);
            double y = 1.0 - (((((a5 * t + a4) * t) + a3) * t + a2) * t + a1) * t * Math.Exp(-x * x);

            return 0.5 * (1.0 + sign * y);
        }
    }
}
