#pragma checksum "D:\Ceyda-2020-softwareWorld\projects\cloned PPT\PowerPointGenerator\Views\Form\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fdf33e966e97e11a59cd575a775d4ba075f8ec83"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Form_Edit), @"mvc.1.0.view", @"/Views/Form/Edit.cshtml")]
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
#line 1 "D:\Ceyda-2020-softwareWorld\projects\cloned PPT\PowerPointGenerator\Views\_ViewImports.cshtml"
using PowerPointGenerator;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Ceyda-2020-softwareWorld\projects\cloned PPT\PowerPointGenerator\Views\_ViewImports.cshtml"
using PowerPointGenerator.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fdf33e966e97e11a59cd575a775d4ba075f8ec83", @"/Views/Form/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d362e0e7f49706d21255244aa6f2299eb31638aa", @"/Views/_ViewImports.cshtml")]
    public class Views_Form_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div>\r\n  <h4>Title:</h4>\r\n  ");
#nullable restore
#line 4 "D:\Ceyda-2020-softwareWorld\projects\cloned PPT\PowerPointGenerator\Views\Form\Edit.cshtml"
Write(ViewBag.title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n<h4>Content:</h4>\r\n<p><em>Please bold words you want to search images for:</em></p>\r\n<a href=\"#\" id=\"bolden\" class=\"btn btn-outline-dark\">Bold</a><br>\r\n<div id=\"content\" contenteditable>\r\n  ");
#nullable restore
#line 10 "D:\Ceyda-2020-softwareWorld\projects\cloned PPT\PowerPointGenerator\Views\Form\Edit.cshtml"
Write(ViewBag.content);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
</div>
<a class=""btn btn-secondary"" onclick=""Update()"" >Next => Select Images </a>


<script src=""https://ajax.googleapis.com/ajax/libs/jquery/2.1.1/jquery.min.js""></script>
<script>
  let boldedWords = [];
   $('#bolden').click(function(){
   document.execCommand('bold');
    var selected = document.getElementById(""content"").innerHTML;
    var highlighted = window.getSelection().toString();
    boldedWords.push(highlighted);

     console.log(boldedWords);
  });

  var Update = function(){
    debugger
    console.log($('#content').html());
    $.ajax({
        url: """);
#nullable restore
#line 31 "D:\Ceyda-2020-softwareWorld\projects\cloned PPT\PowerPointGenerator\Views\Form\Edit.cshtml"
         Write(Url.Action("SelectImage"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\",\r\n        type: \"POST\",\r\n        data: { content: $(\'#content\').html() , boldedWords: boldedWords},\r\n        success: function(response) {\r\n            alert(\'success\');\r\n            window.location.href = \'");
#nullable restore
#line 36 "D:\Ceyda-2020-softwareWorld\projects\cloned PPT\PowerPointGenerator\Views\Form\Edit.cshtml"
                               Write(Url.Action("SelectImage"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\';\r\n");
            WriteLiteral("        }\r\n\r\n    });\r\n  }\r\n</script>");
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
