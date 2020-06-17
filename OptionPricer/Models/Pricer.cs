using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionPricer
{
    /// <summary>
    /// The class "Pricer" describes a Financial Product
    /// It's based abstract Class that was writen as a model for pricers
    /// </summary>
    public abstract class Pricer
    {
        public abstract double Price(FinancialProduct product);
 
    }
}
