using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionPricer
{
    public class Cache
    {
        public static Dictionary<EuropeanOption, double> optionPricesCache = new Dictionary<EuropeanOption, double>();

        public static void AddResultInCache(Pricer pricer, double dResultPricing)
        {

        }
    }
}
