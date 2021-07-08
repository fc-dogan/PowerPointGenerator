#pragma checksum "D:\Ceyda-2020-softwareWorld\projects\son hali\PowerPointGenerator\Views\Home\SelectImage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c6a2b0581d3ea552d6f78d109e4e6c52a8887a97"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_SelectImage), @"mvc.1.0.view", @"/Views/Home/SelectImage.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c6a2b0581d3ea552d6f78d109e4e6c52a8887a97", @"/Views/Home/SelectImage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d362e0e7f49706d21255244aa6f2299eb31638aa", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_SelectImage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FormModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div>\r\n    <p>Select Image page</p>\r\n    <ul class=\"list-group\" id=\"ItemList\">\r\n");
#nullable restore
#line 6 "D:\Ceyda-2020-softwareWorld\projects\son hali\PowerPointGenerator\Views\Home\SelectImage.cshtml"
       foreach (var item in (List<ImageModel>)ViewData["Images"])
      { 

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li class=\"list-group-item\">\r\n          <div class=\"checkbox\">\r\n            <input type=\"checkbox\"");
            BeginWriteAttribute("id", " id=\"", 283, "\"", 302, 2);
            WriteAttributeValue("", 288, "Check_", 288, 6, true);
#nullable restore
#line 10 "D:\Ceyda-2020-softwareWorld\projects\son hali\PowerPointGenerator\Views\Home\SelectImage.cshtml"
WriteAttributeValue("", 294, item.Id, 294, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("checked", " checked=\"", 303, "\"", 329, 1);
#nullable restore
#line 10 "D:\Ceyda-2020-softwareWorld\projects\son hali\PowerPointGenerator\Views\Home\SelectImage.cshtml"
WriteAttributeValue("", 313, item.IsSelected, 313, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("name", " name=\"", 330, "\"", 351, 1);
#nullable restore
#line 10 "D:\Ceyda-2020-softwareWorld\projects\son hali\PowerPointGenerator\Views\Home\SelectImage.cshtml"
WriteAttributeValue("", 337, item.ImageUrl, 337, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            <img");
            BeginWriteAttribute("id", " id=\"", 371, "\"", 395, 2);
            WriteAttributeValue("", 376, "thumbnails_", 376, 11, true);
#nullable restore
#line 11 "D:\Ceyda-2020-softwareWorld\projects\son hali\PowerPointGenerator\Views\Home\SelectImage.cshtml"
WriteAttributeValue("", 387, item.Id, 387, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("src", " src=\"", 396, "\"", 433, 1);
#nullable restore
#line 11 "D:\Ceyda-2020-softwareWorld\projects\son hali\PowerPointGenerator\Views\Home\SelectImage.cshtml"
WriteAttributeValue("", 402, Url.Content(item.ThumbnailUrl), 402, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"image\" />\r\n          </div>\r\n        </li>\r\n");
#nullable restore
#line 14 "D:\Ceyda-2020-softwareWorld\projects\son hali\PowerPointGenerator\Views\Home\SelectImage.cshtml"
      }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"      <li class=""list-group-item"">
        <a class=""btn btn-success"" onclick=""SaveList()"">Select Images</a>
      </li>
    </ul>
    }


<script>
  var SaveList = function() {
    var arrItem = [];
    var arrList = [];
    var commaSeparatedIds = """";
    $(""#ItemList li input[type=checkbox]"").each(function(index, val) {
");
            WriteLiteral(@"      var imgData = $(val).attr(""name"")
      var checkId = $(val).attr(""Id"");
      var arr = checkId.split(""_"");
      var currentCheckboxId = arr[1];
      var isChecked = $(""#"" + checkId).is("":checked"", true);
      if(isChecked) {
        arrItem.push(currentCheckboxId);
        arrList.push(imgData);
      }
    })
    if(arrItem.length != 0){
");
            WriteLiteral(@"      commaSeparatedIds = arrItem.toString();
      $.ajax({
        url:""/Home/SelectImage"",
        type: ""POST"",
        data: { ItemList: commaSeparatedIds, dataList: arrList },
        success: function(response) {
          alert(response);
        }
      })
    }
  }
</script>");
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
