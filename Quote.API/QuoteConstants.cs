using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Quote.API
{
    public class QuoteConstants
    {
        public const int Hazard = 4;
        public static Dictionary<string, double> States = new Dictionary<string, double>()
        {
            {"OH", 1},
            {"FL", 1.2},
            {"TX", 0.943 }
        };
        public static Dictionary<string, double> Businesses = new Dictionary<string, double>()
        {
            {"Architect", 1},
            {"Plumber", 0.5},
            {"Programmer", 1.25 }
        };
    }
}
