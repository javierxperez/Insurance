using Quote.API;
using Quote.API.Interfaces;
using Quote.API.Models.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Quote.API.Engine
{
    public class QuoteEngine : IQuoteEngine
    {
        public double CalculatePremium(QuoteRequest request)
        {
            QuoteConstants.States.TryGetValue(request.state, out double stateFactor);
            QuoteConstants.Businesses.TryGetValue(request.business, out double businessFactor);
            var basePremium = Math.Ceiling(request.revenue/1000);         
            return (stateFactor * businessFactor * basePremium * QuoteConstants.Hazard);
        }
    }
}
