#pragma checksum "C:\Meine Kurse\ASPNETCore_Berlin30_03_2020\AspNetCore_Berlin_30032020\AspNetCore_RazorPages\Pages\Modul03\SectionSample.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c5be27d7eafc91ea1485b8fc731128f5c19d8926"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore_RazorPages.Pages.Modul03.Pages_Modul03_SectionSample), @"mvc.1.0.razor-page", @"/Pages/Modul03/SectionSample.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c5be27d7eafc91ea1485b8fc731128f5c19d8926", @"/Pages/Modul03/SectionSample.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a48f33689ec8929ed297347cfb0669936da14c88", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Modul03_SectionSample : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Meine Kurse\ASPNETCore_Berlin30_03_2020\AspNetCore_Berlin_30032020\AspNetCore_RazorPages\Pages\Modul03\SectionSample.cshtml"
  
    ViewData["Title"] = "SectionSample";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>SectionSample</h1>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n        $(\'h1\').text(\'Modifieded Text by jQuery. \');\r\n    </script>\r\n");
            }
            );
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AspNetCore_RazorPages.Pages.Modul03.SectionSampleModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AspNetCore_RazorPages.Pages.Modul03.SectionSampleModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AspNetCore_RazorPages.Pages.Modul03.SectionSampleModel>)PageContext?.ViewData;
        public AspNetCore_RazorPages.Pages.Modul03.SectionSampleModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591