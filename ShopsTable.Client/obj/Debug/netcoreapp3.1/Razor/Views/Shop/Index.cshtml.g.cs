#pragma checksum "D:\Labs\ShopsTable\ShopsTable.Client\Views\Shop\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4033b6322ea5f19ffc0ef81c1ef5b7daf3e67b4d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shop_Index), @"mvc.1.0.view", @"/Views/Shop/Index.cshtml")]
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
#line 1 "D:\Labs\ShopsTable\ShopsTable.Client\Views\_ViewImports.cshtml"
using ShopsTable.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Labs\ShopsTable\ShopsTable.Client\Views\_ViewImports.cshtml"
using ShopsTable.Client.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4033b6322ea5f19ffc0ef81c1ef5b7daf3e67b4d", @"/Views/Shop/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7babf2773f51d862e1eba5d7ca4d7b4762daebc", @"/Views/_ViewImports.cshtml")]
    public class Views_Shop_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Shop>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div>\r\n");
#nullable restore
#line 7 "D:\Labs\ShopsTable\ShopsTable.Client\Views\Shop\Index.cshtml"
     if (Model != null)
    {
        var shop = Model.ToArray();
        for (int i = 0; i < Model.Count(); i++)
        {
            if (i == 0 || i % 3 == 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            WriteLiteral(" </div><div class=\"row\">\r\n");
#nullable restore
#line 15 "D:\Labs\ShopsTable\ShopsTable.Client\Views\Shop\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p class=\"example-shadow-2\"><a");
            BeginWriteAttribute("href", " href=\"", 328, "\"", 366, 2);
            WriteAttributeValue("", 335, "/Shop/Detail?shopId=", 335, 20, true);
#nullable restore
#line 16 "D:\Labs\ShopsTable\ShopsTable.Client\Views\Shop\Index.cshtml"
WriteAttributeValue("", 355, shop[i].Id, 355, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><h1>");
#nullable restore
#line 16 "D:\Labs\ShopsTable\ShopsTable.Client\Views\Shop\Index.cshtml"
                                                                                 Write(shop[i].Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1><br><br>");
#nullable restore
#line 16 "D:\Labs\ShopsTable\ShopsTable.Client\Views\Shop\Index.cshtml"
                                                                                                           Write(shop[i].Adress);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br>");
#nullable restore
#line 16 "D:\Labs\ShopsTable\ShopsTable.Client\Views\Shop\Index.cshtml"
                                                                                                                              Write(shop[i].WorkTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></p>\r\n");
#nullable restore
#line 17 "D:\Labs\ShopsTable\ShopsTable.Client\Views\Shop\Index.cshtml"
        }
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Shop>> Html { get; private set; }
    }
}
#pragma warning restore 1591
