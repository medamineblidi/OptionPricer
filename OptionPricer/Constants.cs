using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionPricer
{
    /// <summary>
    /// The class Constants contains all Constants and enums declarations
    /// </summary>
    public static class Constants
    {
        public const string CALL = "Call";
        public const string PUT = "Put";
        public const int DEFAULT_FLOAT_PRECISION = 4;
        public const string CULTURE_GB = "en-GB";
        public const string CULTURE_FR = "fr-FR";
        public const string CULTURE_ES = "es-ES";
        public enum EuroOptionType
        {
            Call,
            Put
        }
        public enum Culture
        {
            GB,
            FR,
            ES
        }
    }
}
