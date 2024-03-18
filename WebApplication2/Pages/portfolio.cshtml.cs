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
        private readonly JsonContext _JsonContext;

        public PortfolioModel(WebContext db, JsonContext jc)
        {
            _context = db;
            _JsonContext = jc;

        }

        public List<Testimonial> Testimonials { get; set; }
        public List<Portfolios> portfolios { get; set; }
        public void OnGet()
        {
            Testimonials = _context.Testimonials.AsNoTracking().ToList();
            portfolios = _JsonContext.portfolios;
        }

    }
}
