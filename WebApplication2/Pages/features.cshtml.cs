using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Pages
{
    public class FeaturesModel : PageModel
    {
        private readonly ILogger<FeaturesModel> _logger;

        public FeaturesModel(ILogger<FeaturesModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
