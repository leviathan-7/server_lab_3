using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using WebApplication2.Data;
using WebApplication2.Models;

namespace WebApplication2.Pages
{
    public class PortfolioModel : PageModel
    {
        private readonly WebContext _context;
        public PortfolioModel(WebContext db)
        {
            _context = db;
        }
        public List<Testimonial> Testimonials { get; set; }
        public void OnGet()
        {
            Testimonials = _context.Testimonials.AsNoTracking().ToList();
        }

        public record Portfolios(string imgHref, string text, string smalText, string cat);

        public static List<Portfolios> GetPortfolios()
        {
            var fs = new FileStream("portfolio.json", FileMode.OpenOrCreate);
            return JsonSerializer.Deserialize<List<Portfolios>>(fs);
        }
    }
}
