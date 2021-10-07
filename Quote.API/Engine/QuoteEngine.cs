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
        public bool ValidateQuoteData(QuoteRequest request)
        {
            bool stateIsValid = QuoteConstants.States.ContainsKey(request.state);
            bool businessIsValid = QuoteConstants.Businesses.ContainsKey(request.business);
            bool revenueIsValid = request.revenue > 0;

            if (stateIsValid == false || businessIsValid == false || revenueIsValid == false)
                return false;
            else
                return true;
        }
    }
}
