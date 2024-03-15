#pragma checksum "C:\Users\Mike\Desktop\Labs\Серверное программирование\Лаба 3\WebApplication2\WebApplication2\Pages\portfolio.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "a2076bd4da3f1eadfb88a898f05fa09fccd031c58b6a31ead0c2559572b0de73"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WebApplication2.Pages.Pages_portfolio), @"mvc.1.0.razor-page", @"/Pages/portfolio.cshtml")]
namespace WebApplication2.Pages
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Mike\Desktop\Labs\Серверное программирование\Лаба 3\WebApplication2\WebApplication2\Pages\_ViewImports.cshtml"
using WebApplication2;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"a2076bd4da3f1eadfb88a898f05fa09fccd031c58b6a31ead0c2559572b0de73", @"/Pages/portfolio.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"f1486e9be7d62c34b9ab7fa66f88a59ef23183df66ef0a00608368fb36d32a9b", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_portfolio : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Mike\Desktop\Labs\Серверное программирование\Лаба 3\WebApplication2\WebApplication2\Pages\portfolio.cshtml"
  
    ViewData["Title"] = "Portfolio";
    ViewData["ActivePortfolio"] = "active";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"   	<div class=""banner-area banner-bg-1"">
		<div class=""container"">
			<div class=""row"">
				<div class=""col-md-12"">
					<div class=""banner"">
						<h2>Our Portfolio</h2>
						<ul class=""page-title-link"">
							<li><a href=""#"">Home</a></li>
							<li><a href=""#"">Our Portfolio</a></li>
						</ul>
					</div>
				</div>
			</div>
		</div>
	</div>

    <div id=""portfolio"" class=""section wb"">
        <div class=""container"">
            <div class=""section-title text-center"">
                <h3>Our Portfolio</h3>
                <p class=""lead"">We build professional website templates, web design projects, material designs and UI kits. <br>Some of our awesome completed projects in below.</p>
            </div><!-- end title -->
        </div><!-- end container -->

        <div class=""container-fluid"">
");
#nullable restore
#line 32 "C:\Users\Mike\Desktop\Labs\Серверное программирование\Лаба 3\WebApplication2\WebApplication2\Pages\portfolio.cshtml"
          
            var portfolios = PortfolioModel.GetPortfolios();
        

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"row\">\n                <div class=\"col-md-12\">\n                    <nav class=\"portfolio-filter text-center\">\n                        <ul>\n");
#nullable restore
#line 39 "C:\Users\Mike\Desktop\Labs\Серверное программирование\Лаба 3\WebApplication2\WebApplication2\Pages\portfolio.cshtml"
                              
                            int cat1 = (from portfolio in portfolios where portfolio.cat == "cat1" select portfolio).Count();
                            int cat2 = (from portfolio in portfolios where portfolio.cat == "cat2" select portfolio).Count();
                            int cat3 = (from portfolio in portfolios where portfolio.cat == "cat3" select portfolio).Count();
                            int cat4 = (from portfolio in portfolios where portfolio.cat == "cat4" select portfolio).Count();
                            

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <li><a class=""btn btn-dark btn-radius btn-brd active"" href=""#"" data-filter=""*""><span class=""oi hidden-xs"" data-glyph=""grid-three-up""></span> All</a></li>
                        <li><a class=""btn btn-dark btn-radius btn-brd"" data-toggle=""tooltip"" data-placement=""top""");
            BeginWriteAttribute("title", " title=\"", 2034, "\"", 2047, 1);
#nullable restore
#line 46 "C:\Users\Mike\Desktop\Labs\Серверное программирование\Лаба 3\WebApplication2\WebApplication2\Pages\portfolio.cshtml"
WriteAttributeValue("", 2042, cat1, 2042, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" href=\"#\" data-filter=\".cat1\">Design</a></li>\n                        <li><a class=\"btn btn-dark btn-radius btn-brd\" href=\"#\" data-toggle=\"tooltip\" data-placement=\"top\"");
            BeginWriteAttribute("title", " title=\"", 2216, "\"", 2229, 1);
#nullable restore
#line 47 "C:\Users\Mike\Desktop\Labs\Серверное программирование\Лаба 3\WebApplication2\WebApplication2\Pages\portfolio.cshtml"
WriteAttributeValue("", 2224, cat2, 2224, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" href=\"#\" data-filter=\".cat2\">Mockup</a></li>\n                        <li><a class=\"btn btn-dark btn-radius btn-brd\" href=\"#\" data-toggle=\"tooltip\" data-placement=\"top\"");
            BeginWriteAttribute("title", " title=\"", 2398, "\"", 2411, 1);
#nullable restore
#line 48 "C:\Users\Mike\Desktop\Labs\Серверное программирование\Лаба 3\WebApplication2\WebApplication2\Pages\portfolio.cshtml"
WriteAttributeValue("", 2406, cat3, 2406, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" href=\"#\" data-filter=\".cat3\">Logos</a></li>\n                        <li><a class=\"btn btn-dark btn-radius btn-brd\" href=\"#\" data-toggle=\"tooltip\" data-placement=\"top\"");
            BeginWriteAttribute("title", " title=\"", 2579, "\"", 2592, 1);
#nullable restore
#line 49 "C:\Users\Mike\Desktop\Labs\Серверное программирование\Лаба 3\WebApplication2\WebApplication2\Pages\portfolio.cshtml"
WriteAttributeValue("", 2587, cat4, 2587, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" href=\"#\" data-filter=\".cat4\">HTML</a></li>\n                        </ul>\n                    </nav>\n                </div>\n            </div>\n\n            <hr class=\"invis\">\n\n            <div id=\"da-thumbs\" class=\"da-thumbs portfolio\">\n");
#nullable restore
#line 58 "C:\Users\Mike\Desktop\Labs\Серверное программирование\Лаба 3\WebApplication2\WebApplication2\Pages\portfolio.cshtml"
             for (var i = 0; i < portfolios.Count; i++)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div");
            BeginWriteAttribute("class", " class=\"", 2924, "\"", 2983, 5);
            WriteAttributeValue("", 2932, "post-media", 2932, 10, true);
            WriteAttributeValue(" ", 2942, "pitem", 2943, 6, true);
            WriteAttributeValue(" ", 2948, "item-w1", 2949, 8, true);
            WriteAttributeValue(" ", 2956, "item-h1", 2957, 8, true);
#nullable restore
#line 60 "C:\Users\Mike\Desktop\Labs\Серверное программирование\Лаба 3\WebApplication2\WebApplication2\Pages\portfolio.cshtml"
WriteAttributeValue(" ", 2964, portfolios[i].cat, 2965, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                    <a");
            BeginWriteAttribute("href", " href=\"", 3008, "\"", 3045, 2);
            WriteAttributeValue("", 3015, "uploads/", 3015, 8, true);
#nullable restore
#line 61 "C:\Users\Mike\Desktop\Labs\Серверное программирование\Лаба 3\WebApplication2\WebApplication2\Pages\portfolio.cshtml"
WriteAttributeValue("", 3023, portfolios[i].imgHref, 3023, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-rel=\"prettyPhoto[gal]\">\n                        <img");
            BeginWriteAttribute("src", " src=\"", 3104, "\"", 3140, 2);
            WriteAttributeValue("", 3110, "uploads/", 3110, 8, true);
#nullable restore
#line 62 "C:\Users\Mike\Desktop\Labs\Серверное программирование\Лаба 3\WebApplication2\WebApplication2\Pages\portfolio.cshtml"
WriteAttributeValue("", 3118, portfolios[i].imgHref, 3118, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 3141, "\"", 3147, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"img-responsive\">\n                        <div>\n                            <h3>");
#nullable restore
#line 64 "C:\Users\Mike\Desktop\Labs\Серверное программирование\Лаба 3\WebApplication2\WebApplication2\Pages\portfolio.cshtml"
                           Write(portfolios[i].text);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <small>");
#nullable restore
#line 64 "C:\Users\Mike\Desktop\Labs\Серверное программирование\Лаба 3\WebApplication2\WebApplication2\Pages\portfolio.cshtml"
                                                      Write(portfolios[i].smalText);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small></h3>\n                            <i class=\"flaticon-unlink\"></i>\n                        </div>\n                    </a>\n                </div>\n");
#nullable restore
#line 69 "C:\Users\Mike\Desktop\Labs\Серверное программирование\Лаба 3\WebApplication2\WebApplication2\Pages\portfolio.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div><!-- end portfolio -->
        </div><!-- end container -->
    </div><!-- end section -->
	
	<div id=""services"" class=""parallax section lb"">
        <div class=""container"">
            <div class=""section-title text-center"">
                <h3>Our Service</h3>
                <p class=""lead"">Our Service unlimited solutions to all your business needs. in the installation package we prepare search engine optimization, social media support, we provide corporate identity and graphic design services.</p>
            </div><!-- end title -->

            <div class=""owl-services owl-carousel owl-theme"">
                <div class=""service-widget"">
                    <div class=""post-media wow fadeIn"">
                        <a href=""uploads/service_01.jpg"" data-rel=""prettyPhoto[gal]"" class=""hoverbutton global-radius""><i class=""flaticon-unlink""></i></a>
                        <img src=""uploads/service_01.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 4390, "\"", 4396, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""img-responsive img-rounded"">
                    </div>
					<div class=""service-dit"">
						<h3>Smart Swatch Editions</h3>
						<p>Aliquam sagittis ligula et sem lacinia, ut facilisis enim sollicitudin. Proin nisi est, convallis nec purus vitae, iaculis posuere sapien. Cum sociis natoque.</p>
					</div>
                </div>
                <!-- end service -->

                <div class=""service-widget"">
                    <div class=""post-media wow fadeIn"">
                        <a href=""uploads/service_02.jpg"" data-rel=""prettyPhoto[gal]"" class=""hoverbutton global-radius""><i class=""flaticon-unlink""></i></a>
                        <img src=""uploads/service_02.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 5087, "\"", 5093, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""img-responsive img-rounded"">
                    </div>
					<div class=""service-dit"">
						<h3>Web UI Kit Design</h3>
						<p>Duis at tellus at dui tincidunt scelerisque nec sed felis. Suspendisse id dolor sed leo rutrum euismod. Nullam vestibulum fermentum erat. It nam auctor. </p>
					</div>
                </div>
                <!-- end service -->

                <div class=""service-widget"">
                    <div class=""post-media wow fadeIn"">
                        <a href=""uploads/service_03.jpg"" data-rel=""prettyPhoto[gal]"" class=""hoverbutton global-radius""><i class=""flaticon-unlink""></i></a>
                        <img src=""uploads/service_03.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 5775, "\"", 5781, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""img-responsive img-rounded"">
                    </div>
					<div class=""service-dit"">
						<h3>Mobile Optimization</h3>
						<p>Etiam materials ut mollis tellus, vel posuere nulla. Etiam sit amet lacus vitae massa sodales aliquam at eget quam. Integer ultricies et magna quis accumsan.</p>
					</div>
                </div>
                <!-- end service -->

                <div class=""service-widget"">
                    <div class=""post-media wow fadeIn"">
                        <a href=""uploads/service_04.jpg"" data-rel=""prettyPhoto[gal]"" class=""hoverbutton global-radius""><i class=""flaticon-unlink""></i></a>
                        <img src=""uploads/service_04.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 6469, "\"", 6475, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""img-responsive img-rounded"">
                    </div>
					<div class=""service-dit"">
						<h3>Digital Design for Mac</h3>
						<p>Praesent in neque congue sapien lobortis faucibus id eget erat. <br>Pellentesque maximus rutrum felis. Interdum et malesuada fames ac ante ipsum primis in faucibus.</p>
					</div>
                </div>
                <!-- end service -->
            </div><!-- end row -->

            <hr class=""hr1"">

            <div class=""text-center"">
                <a data-scroll href=""#portfolio"" class=""btn btn-light btn-radius btn-brd"">View Our Portfolio</a>
            </div>
        </div><!-- end container -->
    </div><!-- end section -->

    <div id=""testimonials"" class=""parallax section db parallax-off"" style=""background-image:url('uploads/parallax_03.jpg');"">
        <div class=""container"">
            <div class=""section-title text-center"">
                <h3>Testimonials</h3>
                <p class=""lead"">We thanks for all our awesome testimonials! There are hu");
            WriteLiteral(@"ndreds of our happy customers! <br>Let's see what others say about GoodWEB Solutions website template!</p>
            </div><!-- end title -->

            <div class=""row"">
                <div class=""col-md-12 col-sm-12"">
                    <div class=""testi-carousel owl-carousel owl-theme"">
                        <div class=""testimonial clearfix"">
                            <div class=""desc"">
                                <h3><i class=""fa fa-quote-left""></i> Wonderful Support!</h3>
                                <p class=""lead"">They have got my project on time with the competition with a sed highly skilled, and experienced & professional team.</p>
                            </div>
                            <div class=""testi-meta"">
                                <img src=""uploads/testi_01.png""");
            BeginWriteAttribute("alt", " alt=\"", 8317, "\"", 8323, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""img-responsive alignleft"">
                                <h4>James Fernando <small>- Manager of Racer</small></h4>
                            </div>
                            <!-- end testi-meta -->
                        </div>
                        <!-- end testimonial -->

                        <div class=""testimonial clearfix"">
                            <div class=""desc"">
                                <h3><i class=""fa fa-quote-left""></i> Awesome Services!</h3>
                                <p class=""lead"">Explain to you how all this mistaken idea of denouncing pleasure and praising pain was born and I will give you completed.</p>
                            </div>
                            <div class=""testi-meta"">
                                <img src=""uploads/testi_02.png""");
            BeginWriteAttribute("alt", " alt=\"", 9141, "\"", 9147, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""img-responsive alignleft"">
                                <h4>Jacques Philips <small>- Designer</small></h4>
                            </div>
                            <!-- end testi-meta -->
                        </div>
                        <!-- end testimonial -->

                        <div class=""testimonial clearfix"">
                            <div class=""desc"">
                                <h3><i class=""fa fa-quote-left""></i> Great & Talented Team!</h3>
                                <p class=""lead"">The master-builder of human happines no one rejects, dislikes avoids pleasure itself, because it is very pursue pleasure. </p>
                            </div>
                            <div class=""testi-meta"">
                                <img src=""uploads/testi_03.png""");
            BeginWriteAttribute("alt", " alt=\"", 9963, "\"", 9969, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""img-responsive alignleft"">
                                <h4>Venanda Mercy <small>- Newyork City</small></h4>
                            </div>
                            <!-- end testi-meta -->
                        </div>
                        <!-- end testimonial -->
                        <div class=""testimonial clearfix"">
                            <div class=""desc"">
                                <h3><i class=""fa fa-quote-left""></i> Wonderful Support!</h3>
                                <p class=""lead"">They have got my project on time with the competition with a sed highly skilled, and experienced & professional team.</p>
                            </div>
                            <div class=""testi-meta"">
                                <img src=""uploads/testi_01.png""");
            BeginWriteAttribute("alt", " alt=\"", 10777, "\"", 10783, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""img-responsive alignleft"">
                                <h4>James Fernando <small>- Manager of Racer</small></h4>
                            </div>
                            <!-- end testi-meta -->
                        </div>
                        <!-- end testimonial -->

                        <div class=""testimonial clearfix"">
                            <div class=""desc"">
                                <h3><i class=""fa fa-quote-left""></i> Awesome Services!</h3>
                                <p class=""lead"">Explain to you how all this mistaken idea of denouncing pleasure and praising pain was born and I will give you completed.</p>
                            </div>
                            <div class=""testi-meta"">
                                <img src=""uploads/testi_02.png""");
            BeginWriteAttribute("alt", " alt=\"", 11601, "\"", 11607, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""img-responsive alignleft"">
                                <h4>Jacques Philips <small>- Designer</small></h4>
                            </div>
                            <!-- end testi-meta -->
                        </div>
                        <!-- end testimonial -->

                        <div class=""testimonial clearfix"">
                            <div class=""desc"">
                                <h3><i class=""fa fa-quote-left""></i> Great & Talented Team!</h3>
                                <p class=""lead"">The master-builder of human happines no one rejects, dislikes avoids pleasure itself, because it is very pursue pleasure. </p>
                            </div>
                            <div class=""testi-meta"">
                                <img src=""uploads/testi_03.png""");
            BeginWriteAttribute("alt", " alt=\"", 12423, "\"", 12429, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""img-responsive alignleft"">
                                <h4>Venanda Mercy <small>- Newyork City</small></h4>
                            </div>
                            <!-- end testi-meta -->
                        </div><!-- end testimonial -->
                    </div><!-- end carousel -->
                </div><!-- end col -->
            </div><!-- end row -->

            <hr class=""hr1"">

            <div class=""row logos"">
                <div class=""col-md-2 col-sm-2 col-xs-6 wow fadeInUp"">
                    <a href=""#""><img src=""uploads/logo_01.png""");
            BeginWriteAttribute("alt", " alt=\"", 13013, "\"", 13019, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"img-repsonsive\"></a>\n                </div>\n                <div class=\"col-md-2 col-sm-2 col-xs-6 wow fadeInUp\">\n                    <a href=\"#\"><img src=\"uploads/logo_02.png\"");
            BeginWriteAttribute("alt", " alt=\"", 13204, "\"", 13210, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"img-repsonsive\"></a>\n                </div>\n                <div class=\"col-md-2 col-sm-2 col-xs-6 wow fadeInUp\">\n                    <a href=\"#\"><img src=\"uploads/logo_03.png\"");
            BeginWriteAttribute("alt", " alt=\"", 13395, "\"", 13401, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"img-repsonsive\"></a>\n                </div>\n                <div class=\"col-md-2 col-sm-2 col-xs-6 wow fadeInUp\">\n                    <a href=\"#\"><img src=\"uploads/logo_04.png\"");
            BeginWriteAttribute("alt", " alt=\"", 13586, "\"", 13592, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"img-repsonsive\"></a>\n                </div>\n                <div class=\"col-md-2 col-sm-2 col-xs-6 wow fadeInUp\">\n                    <a href=\"#\"><img src=\"uploads/logo_05.png\"");
            BeginWriteAttribute("alt", " alt=\"", 13777, "\"", 13783, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"img-repsonsive\"></a>\n                </div>\n                <div class=\"col-md-2 col-sm-2 col-xs-6 wow fadeInUp\">\n                    <a href=\"#\"><img src=\"uploads/logo_06.png\"");
            BeginWriteAttribute("alt", " alt=\"", 13968, "\"", 13974, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""img-repsonsive""></a>
                </div>
            </div><!-- end row -->

        </div><!-- end container -->
    </div><!-- end section -->

    <footer class=""footer"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-md-4 col-sm-4 col-xs-12"">
                    <div class=""widget clearfix"">
                        <div class=""widget-title"">
                            <img src=""images/logos/logo-2.png""");
            BeginWriteAttribute("alt", " alt=\"", 14443, "\"", 14449, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
                        </div>
                        <p> Integer rutrum ligula eu dignissim laoreet. Pellentesque venenatis nibh sed tellus faucibus bibendum. Sed fermentum est vitae rhoncus molestie. Cum sociis natoque penatibus et magnis dis montes.</p>
                        <p>Sed fermentum est vitae rhoncus molestie. Cum sociis natoque penatibus et magnis dis montes.</p>
                    </div><!-- end clearfix -->
                </div><!-- end col -->

				<div class=""col-md-4 col-sm-4 col-xs-12"">
                    <div class=""widget clearfix"">
                        <div class=""widget-title"">
                            <h3>Pages</h3>
                        </div>

                        <ul class=""footer-links hov"">
                            <li><a href=""#"">Home <span class=""icon icon-arrow-right2""></span></a></li>
							<li><a href=""#"">Blog <span class=""icon icon-arrow-right2""></span></a></li>
							<li><a href=""#"">Pricing <span class=""icon icon-arrow-right2""></span></a></li>
				");
            WriteLiteral(@"			<li><a href=""#"">About <span class=""icon icon-arrow-right2""></span></a></li>
							<li><a href=""#"">Faq <span class=""icon icon-arrow-right2""></span></a></li>
							<li><a href=""#"">Contact <span class=""icon icon-arrow-right2""></span></a></li>
                        </ul><!-- end links -->
                    </div><!-- end clearfix -->
                </div><!-- end col -->
				
                <div class=""col-md-4 col-sm-4 col-xs-12"">
                    <div class=""footer-distributed widget clearfix"">
                        <div class=""widget-title"">
                            <h3>Subscribe</h3>
							<p>There are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form, by injected humour, or randomised words which one know this tricks.</p>
                        </div>
						
						<div class=""footer-right"">
							");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a2076bd4da3f1eadfb88a898f05fa09fccd031c58b6a31ead0c2559572b0de7327829", async() => {
                WriteLiteral("\n\t\t\t\t\t\t\t\t<input placeholder=\"Subscribe our newsletter..\" name=\"search\">\n\t\t\t\t\t\t\t\t<i class=\"fa fa-envelope-o\"></i>\n\t\t\t\t\t\t\t");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\t\t\t\t\t\t</div>                        \n                    </div><!-- end clearfix -->\n                </div><!-- end col -->\n            </div><!-- end row -->\n        </div><!-- end container -->\n    </footer><!-- end footer -->\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PortfolioModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PortfolioModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PortfolioModel>)PageContext?.ViewData;
        public PortfolioModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
