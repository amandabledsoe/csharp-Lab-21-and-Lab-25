#pragma checksum "C:\Users\xando\OneDrive\Desktop\ALL GRAND CIRCUS\Grand Circus Projects\Bootcamp Projects\LABS\ASP.NET\Lab_21_Movie_Registration\Lab_21_Movie_Registration\Views\Home\ShowMovieResultSummary.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "678d7a7c18abc64e1aca27079b01dc4b02829879"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ShowMovieResultSummary), @"mvc.1.0.view", @"/Views/Home/ShowMovieResultSummary.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\xando\OneDrive\Desktop\ALL GRAND CIRCUS\Grand Circus Projects\Bootcamp Projects\LABS\ASP.NET\Lab_21_Movie_Registration\Lab_21_Movie_Registration\Views\_ViewImports.cshtml"
using Lab_21_Movie_Registration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\xando\OneDrive\Desktop\ALL GRAND CIRCUS\Grand Circus Projects\Bootcamp Projects\LABS\ASP.NET\Lab_21_Movie_Registration\Lab_21_Movie_Registration\Views\_ViewImports.cshtml"
using Lab_21_Movie_Registration.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"678d7a7c18abc64e1aca27079b01dc4b02829879", @"/Views/Home/ShowMovieResultSummary.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0c08cc187db3f4c137074176d816972acf6e687", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ShowMovieResultSummary : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MovieModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"align-content-center\">\r\n    <h3>Your Movie \"");
#nullable restore
#line 4 "C:\Users\xando\OneDrive\Desktop\ALL GRAND CIRCUS\Grand Circus Projects\Bootcamp Projects\LABS\ASP.NET\Lab_21_Movie_Registration\Lab_21_Movie_Registration\Views\Home\ShowMovieResultSummary.cshtml"
               Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" has been registered.</h3>\r\n    <p>Here are some additional details, too:</p>\r\n    <br />\r\n    <br />\r\n    <p>ID: ");
#nullable restore
#line 8 "C:\Users\xando\OneDrive\Desktop\ALL GRAND CIRCUS\Grand Circus Projects\Bootcamp Projects\LABS\ASP.NET\Lab_21_Movie_Registration\Lab_21_Movie_Registration\Views\Home\ShowMovieResultSummary.cshtml"
      Write(Model.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>Year: ");
#nullable restore
#line 9 "C:\Users\xando\OneDrive\Desktop\ALL GRAND CIRCUS\Grand Circus Projects\Bootcamp Projects\LABS\ASP.NET\Lab_21_Movie_Registration\Lab_21_Movie_Registration\Views\Home\ShowMovieResultSummary.cshtml"
        Write(Model.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>Genre: ");
#nullable restore
#line 10 "C:\Users\xando\OneDrive\Desktop\ALL GRAND CIRCUS\Grand Circus Projects\Bootcamp Projects\LABS\ASP.NET\Lab_21_Movie_Registration\Lab_21_Movie_Registration\Views\Home\ShowMovieResultSummary.cshtml"
         Write(Model.Genre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>Actors: ");
#nullable restore
#line 11 "C:\Users\xando\OneDrive\Desktop\ALL GRAND CIRCUS\Grand Circus Projects\Bootcamp Projects\LABS\ASP.NET\Lab_21_Movie_Registration\Lab_21_Movie_Registration\Views\Home\ShowMovieResultSummary.cshtml"
          Write(Model.Actors);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>Director: ");
#nullable restore
#line 12 "C:\Users\xando\OneDrive\Desktop\ALL GRAND CIRCUS\Grand Circus Projects\Bootcamp Projects\LABS\ASP.NET\Lab_21_Movie_Registration\Lab_21_Movie_Registration\Views\Home\ShowMovieResultSummary.cshtml"
            Write(Model.Directors);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n</div>\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MovieModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
