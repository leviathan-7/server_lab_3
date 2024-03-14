using CsvHelper;
using CsvHelper.Configuration;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Pages
{
    [IgnoreAntiforgeryToken]
    public class ContactModel : PageModel
    {
        private readonly ILogger<ContactModel> _logger;

        public ContactModel(ILogger<ContactModel> logger)
        {
            _logger = logger;
        }

        public record Inf(string first_name, string last_name, string email, string phone, string select_service, string select_price, string comments);

        public IActionResult OnPost(Inf inf)
        {
            using var fs = new StreamWriter("logs.csv", true);
            using var csvWriter = new CsvWriter(fs, new CsvConfiguration(CultureInfo.CurrentCulture));

            csvWriter.NextRecord();
            csvWriter.WriteRecord(inf);

            return Content("<fieldset><div id='success_page'><h1>Email Sent Successfully.</h1><p>Thank you <strong>$first_name</strong>, your message has been submitted to us.</p></div></fieldset>");
        }
    }
}
