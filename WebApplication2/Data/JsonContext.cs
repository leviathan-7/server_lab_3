using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using WebApplication2.Models;
using static WebApplication2.Data.JsonContext;
using static WebApplication2.Pages.PortfolioModel;

namespace WebApplication2.Data
{
    public class JsonContext
    {

        public JsonContext() 
        {
            var fs = new FileStream("portfolio.json", FileMode.OpenOrCreate);
            portfolios =  JsonSerializer.Deserialize<List<Portfolios>>(fs);
        }

        public List<Portfolios> portfolios { get; set; }

    }
}
