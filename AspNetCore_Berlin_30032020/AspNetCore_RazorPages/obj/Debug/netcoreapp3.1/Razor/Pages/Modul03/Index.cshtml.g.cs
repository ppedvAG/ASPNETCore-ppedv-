#pragma checksum "C:\Meine Kurse\ASPNETCore_Berlin30_03_2020\AspNetCore_Berlin_30032020\AspNetCore_RazorPages\Pages\Modul03\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "33b75753a98fbfb3b32d2a4155533cd627a6067f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore_RazorPages.Pages.Modul03.Pages_Modul03_Index), @"mvc.1.0.razor-page", @"/Pages/Modul03/Index.cshtml")]
namespace AspNetCore_RazorPages.Pages.Modul03
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
#line 1 "C:\Meine Kurse\ASPNETCore_Berlin30_03_2020\AspNetCore_Berlin_30032020\AspNetCore_RazorPages\Pages\_ViewImports.cshtml"
using AspNetCore_RazorPages;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"33b75753a98fbfb3b32d2a4155533cd627a6067f", @"/Pages/Modul03/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a48f33689ec8929ed297347cfb0669936da14c88", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Modul03_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<p>Modul03 - Erstes Beispiel</p>\r\n\r\n");
#nullable restore
#line 8 "C:\Meine Kurse\ASPNETCore_Berlin30_03_2020\AspNetCore_Berlin_30032020\AspNetCore_RazorPages\Pages\Modul03\Index.cshtml"
Write(Model.MyProperty);

#line default
#line hidden
#nullable disable
            WriteLiteral(", asdfjkbasdfjbaskj\r\n\r\n<div");
            BeginWriteAttribute("style", " style=\'", 151, "\'", 233, 1);
#nullable restore
#line 10 "C:\Meine Kurse\ASPNETCore_Berlin30_03_2020\AspNetCore_Berlin_30032020\AspNetCore_RazorPages\Pages\Modul03\Index.cshtml"
WriteAttributeValue("", 159, Model.MyProperty==7?"background-color:yellow":"background-color:orange", 159, 74, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">demo</div>\r\n\r\n\r\n");
#nullable restore
#line 13 "C:\Meine Kurse\ASPNETCore_Berlin30_03_2020\AspNetCore_Berlin_30032020\AspNetCore_RazorPages\Pages\Modul03\Index.cshtml"
 if (Model.MyProperty == 7)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div style=\"background-color:green\">demo</div>\r\n");
#nullable restore
#line 16 "C:\Meine Kurse\ASPNETCore_Berlin30_03_2020\AspNetCore_Berlin_30032020\AspNetCore_RazorPages\Pages\Modul03\Index.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div style=\"background-color:blue\">demo</div>\r\n");
#nullable restore
#line 20 "C:\Meine Kurse\ASPNETCore_Berlin30_03_2020\AspNetCore_Berlin_30032020\AspNetCore_RazorPages\Pages\Modul03\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 22 "C:\Meine Kurse\ASPNETCore_Berlin30_03_2020\AspNetCore_Berlin_30032020\AspNetCore_RazorPages\Pages\Modul03\Index.cshtml"
 for (int i = 0; i < 7; i++)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Meine Kurse\ASPNETCore_Berlin30_03_2020\AspNetCore_Berlin_30032020\AspNetCore_RazorPages\Pages\Modul03\Index.cshtml"
Write(DateTime.Now.AddDays(i).ToString("dddd"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Meine Kurse\ASPNETCore_Berlin30_03_2020\AspNetCore_Berlin_30032020\AspNetCore_RazorPages\Pages\Modul03\Index.cshtml"
                                             ;

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 26 "C:\Meine Kurse\ASPNETCore_Berlin30_03_2020\AspNetCore_Berlin_30032020\AspNetCore_RazorPages\Pages\Modul03\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<hr />\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AspNetCore_RazorPages.Pages.Modul03.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AspNetCore_RazorPages.Pages.Modul03.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AspNetCore_RazorPages.Pages.Modul03.IndexModel>)PageContext?.ViewData;
        public AspNetCore_RazorPages.Pages.Modul03.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
