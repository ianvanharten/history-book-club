#pragma checksum "C:\Users\ianvh\OneDrive - Conestoga College\Documents\GitHub\history-book-club\HistoryBookClub\HistoryBookClub\Views\Home\Book.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c3e33ddc0c69a7e599cb20d1a86997bd07cb1755"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Book), @"mvc.1.0.view", @"/Views/Home/Book.cshtml")]
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
#line 1 "C:\Users\ianvh\OneDrive - Conestoga College\Documents\GitHub\history-book-club\HistoryBookClub\HistoryBookClub\Views\_ViewImports.cshtml"
using HistoryBookClub;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ianvh\OneDrive - Conestoga College\Documents\GitHub\history-book-club\HistoryBookClub\HistoryBookClub\Views\_ViewImports.cshtml"
using HistoryBookClub.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3e33ddc0c69a7e599cb20d1a86997bd07cb1755", @"/Views/Home/Book.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dce2ba9702e6b6cada7efb70e08caeb514cf170a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Book : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Topic>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"jumbotron\">\r\n    <h2>History Book Club</h2>\r\n</div>\r\n\r\n<main class=\"page-container\">\r\n    <h3>");
#nullable restore
#line 11 "C:\Users\ianvh\OneDrive - Conestoga College\Documents\GitHub\history-book-club\HistoryBookClub\HistoryBookClub\Views\Home\Book.cshtml"
   Write(ViewBag.Book.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n    <div class=\"card-row\">\r\n");
#nullable restore
#line 13 "C:\Users\ianvh\OneDrive - Conestoga College\Documents\GitHub\history-book-club\HistoryBookClub\HistoryBookClub\Views\Home\Book.cshtml"
         foreach (Topic topic in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"card page-card\">\r\n                <div class=\"card-body\">\r\n                    <h3>");
#nullable restore
#line 17 "C:\Users\ianvh\OneDrive - Conestoga College\Documents\GitHub\history-book-club\HistoryBookClub\HistoryBookClub\Views\Home\Book.cshtml"
                   Write(topic.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 20 "C:\Users\ianvh\OneDrive - Conestoga College\Documents\GitHub\history-book-club\HistoryBookClub\HistoryBookClub\Views\Home\Book.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n\r\n</main>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Topic>> Html { get; private set; }
    }
}
#pragma warning restore 1591