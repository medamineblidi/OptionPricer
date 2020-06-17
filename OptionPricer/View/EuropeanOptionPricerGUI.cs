using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OptionPricer
{
    /// <summary>
    /// The class EuropeanOptionPricerGUI represents the graphical user interface for tha application, 
    /// it contains the definition of the input part, the verification of these ones and the display of the output results
    /// </summary>
    public partial class EuropeanOptionPricerGUI : Form
    {
        public EuropeanOptionPricerGUI()
        {
            InitializeComponent();

            Cache.optionPricesCache.Clear();
        }
        private void clearButton_Click(object sender, EventArgs e)
        {
            StockPriceTextBox.Clear();
            RiskFreeInterestRateTextBox.Clear();
            StdDerivUnderlyingTextBox.Clear();
            strikePriceTextBox.Clear();
            timeToMatTextBox.Clear();
            optionTypeComboBox.SelectedIndex = -1;
            floatPrecisionTextBox.Text = "4";
            cultureComboBox.SelectedIndex = -1;
        }
        private void Pricebutton_Click(object sender, EventArgs e)
        {
            FinancialProduct product;
            string strErrorMsg = System.String.Empty;
            int iPrecision = Constants.DEFAULT_FLOAT_PRECISION;
            bool bDataInput = CheckInputData(out product, ref iPrecision, ref strErrorMsg);

            if (bDataInput)
            {
                Pricer pricer = new EuropeanOptionPricer(iPrecision);
                double dResultPricing = pricer.Price(product);
                resultLabel.Text = "The result is : " + dResultPricing.ToString();
                Cache.AddResultInCache(pricer, dResultPricing);
            }
            else
            {
                MessageBox.Show(strErrorMsg);
            }
        }

        /// <summary>
        /// The method CheckInputData represents parts that check the input data, converts them to the suitable formats
        /// and build the product to be priced later, 
        /// it contains the definition of the input part, the verification of these ones and the display of the output results
        /// </summary>
        /// <param name=product>The product to be build and returned</param>
        /// <param name=iPrecision>The precision of Round of the final result, </param>
        /// <param name=strErrorMsg>The error Message that will be returned in case of issue</param>
        /// <returns>bool: the method was successfully finished or not</returns>
        private bool CheckInputData(out FinancialProduct product, ref int iPrecision, ref string strErrorMsg)
        {
            string strStockPrice = StockPriceTextBox.Text.ToString();
            string strStrikePrice = strikePriceTextBox.Text.ToString();
            string strTimeToMaturity = timeToMatTextBox.Text.ToString();
            string strStdDerivUnderlying = StdDerivUnderlyingTextBox.Text.ToString();
            string strRiskFreeInterestRate = RiskFreeInterestRateTextBox.Text.ToString();
            string strFloatPrecision = floatPrecisionTextBox.Text.ToString();

            double dStockPrice = 0;
            double dStrikePrice = 0;
            double dTimeToMaturity = 0;
            double dStdDerivUnderlying = 0;
            double dRiskFreeInterestRate = 0;       
            bool bDataInput = true;
            Constants.Culture culture = 0;

            if (cultureComboBox.SelectedIndex > -1)
            {
                if (cultureComboBox.SelectedItem.ToString().Equals(Constants.CULTURE_GB))
                {
                    culture = Constants.Culture.GB;
                }
                else if (cultureComboBox.SelectedItem.ToString().Equals(Constants.CULTURE_FR))
                {
                    culture = Constants.Culture.FR;
                }
                else if (cultureComboBox.SelectedItem.ToString().Equals(Constants.CULTURE_ES))
                {
                    culture = Constants.Culture.ES;
                }
            }
            else
            {
                product = null;
                strErrorMsg = "Please select a choice in the culture box";
                Console.WriteLine("Please select a choice in the culture box ");
                return false;
            }

            if (bDataInput)
            {
                if (ConvertStringToDouble(strStockPrice, culture, out dStockPrice))
                {
                    Console.WriteLine("StockPrice --> {0}", dStockPrice);
                }
                else
                {
                    strErrorMsg = "Please insert a correct format for the field Stock price, the suitable format is float";
                    Console.WriteLine("Unable to parse StockPrice '{0}'.", strStockPrice);
                    product = null;
                    return false;
                }
            }

            if (bDataInput)
            {
                if (ConvertStringToDouble(strStrikePrice, culture, out dStrikePrice))
                {
                    Console.WriteLine("StrikePrice --> {0}", dStrikePrice);
                }
                else
                {
                    strErrorMsg = "Please insert a correct format for the field Strike price, the suitable format is float";
                    Console.WriteLine("Unable to parse StrikePrice '{0}'.", strStrikePrice);
                    product = null;
                    return false;
                }
            }
            if (bDataInput)
            {
                if (ConvertStringToDouble(strTimeToMaturity, culture, out dTimeToMaturity))
                {
                    Console.WriteLine("TimeToMaturity --> {0}", dTimeToMaturity);
                }
                else if (EvaluateDoubleWithSplit(strTimeToMaturity, culture, out dTimeToMaturity))
                {
                    Console.WriteLine("TimeToMaturity --> {0}", dTimeToMaturity);
                }
                else
                {
                    strErrorMsg = "Please insert a correct format for the field Time to maturity in years, the suitable format is integer";
                    Console.WriteLine("Unable to parse TimeToMaturity '{0}'.", strTimeToMaturity);
                    product = null;
                    return false;
                }
            }
            if (bDataInput)
            {
                if (ConvertStringToDouble(strStdDerivUnderlying, culture, out dStdDerivUnderlying))
                {
                    Console.WriteLine("StdDerivUnderlying --> {0}", dStdDerivUnderlying);
                }
                else
                {
                    strErrorMsg = "Please insert a correct format for the field Standard deviation of underlying stock, the suitable format is float";
                    Console.WriteLine("Unable to parse StdDerivUnderlying '{0}'.", strStdDerivUnderlying);
                    product = null;
                    return false;
                }
            }
            if (bDataInput)
            {
                if (ConvertStringToDouble(strRiskFreeInterestRate, culture, out dRiskFreeInterestRate))
                {
                    Console.WriteLine("RiskFreeInterestRate --> {0}", dRiskFreeInterestRate);
                }
                else
                {
                    strErrorMsg = "Please insert a correct format for the field Risk-free interest rate, the suitable format is float";
                    Console.WriteLine("Unable to parse RiskFreeInterestRate '{0}'.", strRiskFreeInterestRate);
                    product = null;
                    return false;
                }
            }

            Constants.EuroOptionType euroOptionType = 0;
            if (bDataInput)
            {
                if (optionTypeComboBox.SelectedIndex > -1)
                {
                    if (optionTypeComboBox.SelectedItem.ToString().Equals(Constants.CALL))
                    {
                        euroOptionType = Constants.EuroOptionType.Call; // todo if 
                    }
                    else if (optionTypeComboBox.SelectedItem.ToString().Equals(Constants.PUT))
                    {
                        euroOptionType = Constants.EuroOptionType.Put; // todo if 
                    }
                }
                else
                {                
                    strErrorMsg = "Please select a choice in the Option type box";
                    Console.WriteLine("Please select a choice in the Option type box");
                    product = null;
                    return false;
                }
            }

            if (bDataInput)
            {
                if (int.TryParse(strFloatPrecision, out iPrecision))
                {
                    Console.WriteLine("RiskFreeInterestRate --> {0}", iPrecision);
                }
                else
                {
                    strErrorMsg = "Please insert a correct format for the field Risk-free interest rate, the suitable format is float";
                    Console.WriteLine("Unable to parse RiskFreeInterestRate '{0}'.", strFloatPrecision);
                    product = null;
                    return false;
                }
            }

            product = new EuropeanOption(dStockPrice, dStrikePrice, dTimeToMaturity, dStdDerivUnderlying, dRiskFreeInterestRate, euroOptionType);
            return bDataInput;
        }

        /// <summary>
        /// The method ConvertStringToDouble will convert the string parameters to the double result
        /// </summary>
        /// <param name=strToConvert>The entry point: the chain to be converted</param>
        /// <param name=culture>The culture to take into consideration during the conversation </param>
        /// <param name=dResult>The result of the conversation</param>
        /// <returns>bool: the method was successfully finished or not</returns>
        private bool ConvertStringToDouble(string strToConvert, Constants.Culture culture,  out double dResult)
        {
            strToConvert = Regex.Replace(strToConvert, @"[\s]+", ""); // Remove space from string
            dResult = 0;
            bool bResultOk= true;
            //Parse currency value using en-GB culture.

            if (culture == Constants.Culture.GB)
            {
                if (double.TryParse(strToConvert, NumberStyles.Number ^ NumberStyles.AllowCurrencySymbol, CultureInfo.CreateSpecificCulture(Constants.CULTURE_GB), out dResult))
                {
                    Console.WriteLine("Converted '{0}' to {1}.", strToConvert, dResult);
                }
                else
                {
                    bResultOk = false;
                    Console.WriteLine("Unable to convert '{0}'.", strToConvert);
                }
            }
            else if (culture == Constants.Culture.FR)
            {
                if (double.TryParse(strToConvert, NumberStyles.AllowDecimalPoint, CultureInfo.CreateSpecificCulture(Constants.CULTURE_FR), out dResult))
                {
                    Console.WriteLine("Converted '{0}' to {1}.", strToConvert, dResult);
                }
                else
                {
                    bResultOk = false;
                    Console.WriteLine("Unable to convert '{0}'.", strToConvert);
                }
            }
            else if (culture == Constants.Culture.ES)
            {
                if (double.TryParse(strToConvert, NumberStyles.AllowDecimalPoint ^ NumberStyles.AllowThousands, CultureInfo.CreateSpecificCulture(Constants.CULTURE_ES), out dResult))
                {
                    Console.WriteLine("Converted '{0}' to {1}.", strToConvert, dResult);
                }
                else
                {
                    bResultOk = false;
                    Console.WriteLine("Unable to convert '{0}'.", strToConvert);
                }
            }
            return bResultOk;
        }
        /// <summary>
        /// The method EvaluateDoubleWithSplit will convert the expression with '/' separator, evaluate it and convert it to double
        /// </summary>
        /// <param name=expression>The entry point: the chain to be converted</param>
        /// <param name=culture>The culture to take into consideration during the conversation </param>
        /// <param name=dResult>The result of the conversation</param>
        /// <returns>bool: the method was successfully finished or not</returns>
        public bool EvaluateDoubleWithSplit(string expression, Constants.Culture culture, out double dResult)
        {
            bool bResult = true;
            dResult = 0; 

            string[] words = expression.Split('/');

            if(words !=null  && words[0] != null)
            {
                bResult = ConvertStringToDouble(words[0], culture, out dResult);
            }
            foreach (string word in words.Skip(1))
            {
                bResult = EvaluateDoubleWithSplit(word, culture, out double dResultTmp);
                dResult /= dResultTmp;
            }
      
            return bResult;
        }
    }
}