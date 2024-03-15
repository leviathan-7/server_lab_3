using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace WebApplication2.Pages
{
    public class PortfolioModel : PageModel
    {
        private readonly ILogger<PortfolioModel> _logger;

        public PortfolioModel(ILogger<PortfolioModel> logger)
        {
            _logger = logger;
        }

        public record Portfolios(string imgHref, string text, string smalText, string cat);

        public static List<Portfolios> GetPortfolios()
        {
            var fs = new FileStream("portfolio.json", FileMode.OpenOrCreate);
            return JsonSerializer.Deserialize<List<Portfolios>>(fs);
        }
    }
}
