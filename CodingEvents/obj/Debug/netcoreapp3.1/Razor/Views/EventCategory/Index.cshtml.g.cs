#pragma checksum "C:\Users\msurm\csharp-practice\Class9and10\CodingEvents\CodingEvents\Views\EventCategory\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "249a665270b7f2090b4ac8cc1ab1309c5d58f59c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_EventCategory_Index), @"mvc.1.0.view", @"/Views/EventCategory/Index.cshtml")]
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
#line 1 "C:\Users\msurm\csharp-practice\Class9and10\CodingEvents\CodingEvents\Views\_ViewImports.cshtml"
using CodingEvents;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\msurm\csharp-practice\Class9and10\CodingEvents\CodingEvents\Views\_ViewImports.cshtml"
using CodingEvents.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"249a665270b7f2090b4ac8cc1ab1309c5d58f59c", @"/Views/EventCategory/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc2964dd59c32e4df324b99d9423fb70affcb2b3", @"/Views/_ViewImports.cshtml")]
    public class Views_EventCategory_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<CodingEvents.Models.EventCategory>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>All Event Categories</h1>\r\n\r\n");
#nullable restore
#line 5 "C:\Users\msurm\csharp-practice\Class9and10\CodingEvents\CodingEvents\Views\EventCategory\Index.cshtml"
 if (Model.Count == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>No Event Categories Yet!</p>\r\n");
#nullable restore
#line 8 "C:\Users\msurm\csharp-practice\Class9and10\CodingEvents\CodingEvents\Views\EventCategory\Index.cshtml"
}

else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <table class=\"table\">\r\n        <tr>\r\n            <th>Id</th>\r\n            <th>Category Name</th>\r\n        </tr>\r\n\r\n");
#nullable restore
#line 18 "C:\Users\msurm\csharp-practice\Class9and10\CodingEvents\CodingEvents\Views\EventCategory\Index.cshtml"
         foreach (EventCategory category in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 21 "C:\Users\msurm\csharp-practice\Class9and10\CodingEvents\CodingEvents\Views\EventCategory\Index.cshtml"
               Write(category.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 22 "C:\Users\msurm\csharp-practice\Class9and10\CodingEvents\CodingEvents\Views\EventCategory\Index.cshtml"
               Write(category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 24 "C:\Users\msurm\csharp-practice\Class9and10\CodingEvents\CodingEvents\Views\EventCategory\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n");
#nullable restore
#line 26 "C:\Users\msurm\csharp-practice\Class9and10\CodingEvents\CodingEvents\Views\EventCategory\Index.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<CodingEvents.Models.EventCategory>> Html { get; private set; }
    }
}
#pragma warning restore 1591
