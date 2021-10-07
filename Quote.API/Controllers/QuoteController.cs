using Microsoft.AspNetCore.Mvc;
using Quote.API.Interfaces;
using Quote.API.Models.Requests;
using Quote.API.Models.Responses;

namespace Quote.API.Controllers
{
    [ApiController]
    [ApiVersion("1")]
    [Route("api/v1/quotes")]
    [Consumes("application/json")]
    [Produces("application/json")]
    public class QuoteController : Controller
    {
        IQuoteEngine _engine;
        public QuoteController(IQuoteEngine engine)
        {
            _engine = engine;
        }

        [HttpPost("createQuote")]
        public ActionResult<QuoteResponse> CreateQuote([FromBody] QuoteRequest quoteRequest)
        {
            if (!_engine.ValidateQuoteData(quoteRequest))
                return BadRequest("Revenue, state, or business is not valid");
                
            var response = new QuoteResponse
            {
                premium = _engine.CalculatePremium(quoteRequest)
            };
            return response;
        }
    }
}
