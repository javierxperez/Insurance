using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Quote.API.Models.Requests
{
    public class QuoteRequest
    {
        [Required]
        public double revenue { get; set; }
        [Required]
        public string state { get; set; }
        [Required]
        public string business { get; set; }
    }
}
