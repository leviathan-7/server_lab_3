using System.Linq;
using System.Xml.Linq;
using WebApplication2.Models;

namespace WebApplication2.Data
{
    public static class DbInitializer
    {
        public static void Initialize(WebContext context)
        {
            if (context.Testimonials.Any())
                return;   // DB has been seeded

            var testimonials = new Testimonial[]
            {
                new Testimonial{name = "James Fernando", img_irl = "testi_01.png", ocupation = "They have got my project on time with the competition with a sed highly skilled, and experienced & professional team.", title = "Wonderful Support!", description = "Manager of Racer" },
                new Testimonial{name = "Jacques Philips", img_irl = "testi_02.png", ocupation = "Explain to you how all this mistaken idea of denouncing pleasure and praising pain was born and I will give you completed.", title = "Great & Talented Team!", description = "Designer" },
                new Testimonial{name = "Venanda Mercy", img_irl = "testi_03.png", ocupation = "The master-builder of human happines no one rejects, dislikes avoids pleasure itself, because it is very pursue pleasure.", title = "Wonderful Support!", description = "Newyork City" }

            };

            context.Testimonials.AddRange(testimonials);
            context.SaveChanges();
        }
    }
}
