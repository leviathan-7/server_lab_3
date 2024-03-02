using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Pages
{
    public class TestimonialsModel : PageModel
    {
        private readonly ILogger<TestimonialsModel> _logger;

        public TestimonialsModel(ILogger<TestimonialsModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
