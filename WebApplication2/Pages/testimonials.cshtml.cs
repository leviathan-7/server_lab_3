using CsvHelper.Configuration;
using CsvHelper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Data;
using WebApplication2.Models;


namespace WebApplication2.Pages
{
    [IgnoreAntiforgeryToken]
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
        public record Inf(string name, string title, string ocupation, string description);

        public IActionResult OnPost(Inf inf)
        {
            _context.Testimonials.Add(new Testimonial { name = inf.name, img_irl = "avatar.jpg", ocupation = inf.ocupation, title = inf.title, description = inf.description });
            _context.SaveChanges();
            return Content("<fieldset><div id='success_page'><h1>Email Sent Successfully.</h1><p>Thank you <strong>" + inf.name + "</strong></p></div></fieldset>");
        }
    }
}
