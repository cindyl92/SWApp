#pragma checksum "/Users/cindy/Downloads/WebApp/SWApp/Views/Films/Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a563b0f3b559fb0caf252f161385112207b3ce5a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Films_Details), @"mvc.1.0.view", @"/Views/Films/Details.cshtml")]
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
#line 1 "/Users/cindy/Downloads/WebApp/SWApp/Views/_ViewImports.cshtml"
using SWApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/cindy/Downloads/WebApp/SWApp/Views/_ViewImports.cshtml"
using SWApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a563b0f3b559fb0caf252f161385112207b3ce5a", @"/Views/Films/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57e8146f5455eda09c58dc7e20360c271ea91a82", @"/Views/_ViewImports.cshtml")]
    public class Views_Films_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h2>");
#nullable restore
#line 1 "/Users/cindy/Downloads/WebApp/SWApp/Views/Films/Details.cshtml"
Write(ViewData["FilmTitle"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\n\n<p>");
#nullable restore
#line 3 "/Users/cindy/Downloads/WebApp/SWApp/Views/Films/Details.cshtml"
Write(ViewData["OpeningCrawl"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n\n<ul></ul>\n\n<table style=\"width:100%\" border=\"1\">\n  <tr>\n    <td>Episode ID</td>\n    <td>");
#nullable restore
#line 10 "/Users/cindy/Downloads/WebApp/SWApp/Views/Films/Details.cshtml"
   Write(ViewData["EpisodeId"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n  </tr>\n  <tr>\n    <td>Director</td>\n    <td>");
#nullable restore
#line 14 "/Users/cindy/Downloads/WebApp/SWApp/Views/Films/Details.cshtml"
   Write(ViewData["Director"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n  </tr>\n  <tr>\n    <td>Producer</td>\n    <td>");
#nullable restore
#line 18 "/Users/cindy/Downloads/WebApp/SWApp/Views/Films/Details.cshtml"
   Write(ViewData["Producer"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n  </tr>\n  <tr>\n    <td>Release Date</td>\n    <td>");
#nullable restore
#line 22 "/Users/cindy/Downloads/WebApp/SWApp/Views/Films/Details.cshtml"
   Write(ViewData["ReleaseDate"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n  </tr>\n  <tr>\n    <td>Vehicles</td>\n    <td>\n");
#nullable restore
#line 27 "/Users/cindy/Downloads/WebApp/SWApp/Views/Films/Details.cshtml"
         foreach (string name in @ViewData["Vehicles"] as ICollection<string>)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li>");
#nullable restore
#line 29 "/Users/cindy/Downloads/WebApp/SWApp/Views/Films/Details.cshtml"
           Write(name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n");
#nullable restore
#line 30 "/Users/cindy/Downloads/WebApp/SWApp/Views/Films/Details.cshtml"
        } 

#line default
#line hidden
#nullable disable
            WriteLiteral("    </td>\n  </tr>\n</table>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
