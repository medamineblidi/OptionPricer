using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionPricer
{
    /// <summary>
    /// The class "EuropeanOption" describes the Euroean Option with all the attributes needed as below:
    /// S: Stock price
    /// K: strike price
    /// T: Time to maturity in years
    /// sigma: σ Standard deviation of underlying stock
    /// r: Risk-free interest rate
    /// It's derived from a based Class Named FinancialProduct, we could implement other products based on this extendable inheritence model
    /// </summary>
    public class EuropeanOption : FinancialProduct
    {
        public double S { get; set; }
        public double K { get; set; }
        public double T { get; set; }
        public double Sigma { get; set; }
        public double R { get; set; }
        public Constants.EuroOptionType OptionType { get; set; }

        public EuropeanOption() { }
        public EuropeanOption(double s, double k, double t, double sigma, double r, Constants.EuroOptionType optionType)
        {
            this.S = s;
            this.K = k;
            this.T = t;
            this.Sigma = sigma;
            this.R = r;
            this.OptionType = optionType;
        }
    }
}
