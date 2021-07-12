#pragma checksum "D:\Ceyda-2020-softwareWorld\projects\cloned PPT\PowerPointGenerator\Views\Form\SelectImage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6bf2a2bdb8139c356aaea731413afe499de183ea"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Form_SelectImage), @"mvc.1.0.view", @"/Views/Form/SelectImage.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6bf2a2bdb8139c356aaea731413afe499de183ea", @"/Views/Form/SelectImage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d362e0e7f49706d21255244aa6f2299eb31638aa", @"/Views/_ViewImports.cshtml")]
    public class Views_Form_SelectImage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FormModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div >\r\n    <h2>Select Images for your PowerPoint: </h2>\r\n    <p><em>Select images that you want to see on your PowerPoint and click the \"Create PowerPoint!\" button below.</em></p>\r\n    <ul class=\"list-group\" id=\"ItemList\">\r\n");
#nullable restore
#line 7 "D:\Ceyda-2020-softwareWorld\projects\cloned PPT\PowerPointGenerator\Views\Form\SelectImage.cshtml"
       foreach (var item in (List<ImageModel>)ViewData["Images"])
      { 

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li class=\"list-group-item col-md-4\">\r\n          <div class=\"checkbox\">\r\n            <input type=\"checkbox\"");
            BeginWriteAttribute("id", " id=\"", 437, "\"", 456, 2);
            WriteAttributeValue("", 442, "Check_", 442, 6, true);
#nullable restore
#line 11 "D:\Ceyda-2020-softwareWorld\projects\cloned PPT\PowerPointGenerator\Views\Form\SelectImage.cshtml"
WriteAttributeValue("", 448, item.Id, 448, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("checked", " checked=\"", 457, "\"", 483, 1);
#nullable restore
#line 11 "D:\Ceyda-2020-softwareWorld\projects\cloned PPT\PowerPointGenerator\Views\Form\SelectImage.cshtml"
WriteAttributeValue("", 467, item.IsSelected, 467, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("name", " name=\"", 484, "\"", 505, 1);
#nullable restore
#line 11 "D:\Ceyda-2020-softwareWorld\projects\cloned PPT\PowerPointGenerator\Views\Form\SelectImage.cshtml"
WriteAttributeValue("", 491, item.ImageUrl, 491, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            <img class=\"img-responsive\"");
            BeginWriteAttribute("id", " id=\"", 548, "\"", 572, 2);
            WriteAttributeValue("", 553, "thumbnails_", 553, 11, true);
#nullable restore
#line 12 "D:\Ceyda-2020-softwareWorld\projects\cloned PPT\PowerPointGenerator\Views\Form\SelectImage.cshtml"
WriteAttributeValue("", 564, item.Id, 564, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("src", " src=\"", 573, "\"", 610, 1);
#nullable restore
#line 12 "D:\Ceyda-2020-softwareWorld\projects\cloned PPT\PowerPointGenerator\Views\Form\SelectImage.cshtml"
WriteAttributeValue("", 579, Url.Content(item.ThumbnailUrl), 579, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"image\" />\r\n          </div>\r\n        </li>\r\n");
#nullable restore
#line 15 "D:\Ceyda-2020-softwareWorld\projects\cloned PPT\PowerPointGenerator\Views\Form\SelectImage.cshtml"
      }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"      <li class=""list-group-item"">
        <a class=""btn btn-success"" onclick=""SaveList()"" >Create PowerPoint!</a>
      </li>
    </ul>


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
        url:""/Form/CreatePowerPoint"",
        type: ""POST"",
        dataType: 'json',
        data: { ItemList: commaSeparatedIds, dataList: arrList },
        success: function(response) {
          window.location.href = ""/"";
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
