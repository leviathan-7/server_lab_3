using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Data;
using WebApplication2.Models;


namespace WebApplication2.Pages
{
    public class TestimonialsModel : PageModel
    {
        private readonly WebContext _context;
        public TestimonialsModel(WebContext db)
        {
            _context = db;
        }
        public List<Testimonial> Testimonials { get; set; }
        public void OnGet()
        {
            Testimonials = _context.Testimonials.AsNoTracking().ToList();
        }
    }
}
