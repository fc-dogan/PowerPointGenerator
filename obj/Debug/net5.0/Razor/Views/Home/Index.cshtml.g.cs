#pragma checksum "D:\Ceyda-2020-softwareWorld\projects\son hali\PowerPointGenerator\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3c5d58d08ce92e2054a3400d284b3698744ed0d9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "D:\Ceyda-2020-softwareWorld\projects\son hali\PowerPointGenerator\Views\_ViewImports.cshtml"
using PowerPointGenerator;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Ceyda-2020-softwareWorld\projects\son hali\PowerPointGenerator\Views\_ViewImports.cshtml"
using PowerPointGenerator.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c5d58d08ce92e2054a3400d284b3698744ed0d9", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d362e0e7f49706d21255244aa6f2299eb31638aa", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FormModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Ceyda-2020-softwareWorld\projects\son hali\PowerPointGenerator\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<div class=\"text-center\">\r\n");
#nullable restore
#line 8 "D:\Ceyda-2020-softwareWorld\projects\son hali\PowerPointGenerator\Views\Home\Index.cshtml"
      Html.BeginForm();
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div>\r\n            Title: <br>\r\n            ");
#nullable restore
#line 12 "D:\Ceyda-2020-softwareWorld\projects\son hali\PowerPointGenerator\Views\Home\Index.cshtml"
       Write(Html.TextAreaFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div>\r\n            Content: <br>\r\n            ");
#nullable restore
#line 16 "D:\Ceyda-2020-softwareWorld\projects\son hali\PowerPointGenerator\Views\Home\Index.cshtml"
       Write(Html.TextAreaFor(model => model.Content));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div>\r\n            <input type=\"submit\" value=\"Create\"/>\r\n        </div>\r\n");
#nullable restore
#line 21 "D:\Ceyda-2020-softwareWorld\projects\son hali\PowerPointGenerator\Views\Home\Index.cshtml"
    }
    Html.EndForm();

            

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div>\r\n        Posted Title: <br>\r\n        ");
#nullable restore
#line 27 "D:\Ceyda-2020-softwareWorld\projects\son hali\PowerPointGenerator\Views\Home\Index.cshtml"
   Write(Html.DisplayFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div>\r\n            Posted Content: <br>\r\n            ");
#nullable restore
#line 31 "D:\Ceyda-2020-softwareWorld\projects\son hali\PowerPointGenerator\Views\Home\Index.cshtml"
       Write(Html.DisplayFor(model => model.Content));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div>\r\n            Split words: <br>\r\n            <ol>\r\n");
#nullable restore
#line 36 "D:\Ceyda-2020-softwareWorld\projects\son hali\PowerPointGenerator\Views\Home\Index.cshtml"
             for (int i = 0; i < 3; i++)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li>");
#nullable restore
#line 38 "D:\Ceyda-2020-softwareWorld\projects\son hali\PowerPointGenerator\Views\Home\Index.cshtml"
               Write(Html.DisplayFor(model => model.SearchWords[i]));

#line default
#line hidden
#nullable disable
            WriteLiteral("   </li>\r\n");
#nullable restore
#line 39 "D:\Ceyda-2020-softwareWorld\projects\son hali\PowerPointGenerator\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </ol>             \r\n        </div>\r\n");
            WriteLiteral("        <div>\r\n            ");
#nullable restore
#line 44 "D:\Ceyda-2020-softwareWorld\projects\son hali\PowerPointGenerator\Views\Home\Index.cshtml"
       Write(Html.DisplayFor(model => model.ImageList.Count));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n");
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FormModel> Html { get; private set; }
    }
}
#pragma warning restore 1591