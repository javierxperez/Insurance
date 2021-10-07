using Quote.API.Models.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Quote.API.Interfaces
{
    public interface IQuoteEngine
    {
        double CalculatePremium(QuoteRequest request);
        bool ValidateQuoteData(QuoteRequest request);
    }
}
