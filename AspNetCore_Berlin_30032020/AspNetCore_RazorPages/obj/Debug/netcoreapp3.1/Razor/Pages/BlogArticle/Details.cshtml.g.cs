#pragma checksum "C:\Meine Kurse\ASPNETCore_Berlin30_03_2020\AspNetCore_Berlin_30032020\AspNetCore_RazorPages\Pages\BlogArticle\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d7abb6c6131435c843d592673ad62c48a94ce8c4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore_RazorPages.Pages.BlogArticle.Pages_BlogArticle_Details), @"mvc.1.0.razor-page", @"/Pages/BlogArticle/Details.cshtml")]
namespace AspNetCore_RazorPages.Pages.BlogArticle
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d7abb6c6131435c843d592673ad62c48a94ce8c4", @"/Pages/BlogArticle/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a48f33689ec8929ed297347cfb0669936da14c88", @"/Pages/_ViewImports.cshtml")]
    public class Pages_BlogArticle_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Meine Kurse\ASPNETCore_Berlin30_03_2020\AspNetCore_Berlin_30032020\AspNetCore_RazorPages\Pages\BlogArticle\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Pages/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Blog</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 16 "C:\Meine Kurse\ASPNETCore_Berlin30_03_2020\AspNetCore_Berlin_30032020\AspNetCore_RazorPages\Pages\BlogArticle\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Blog.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 19 "C:\Meine Kurse\ASPNETCore_Berlin30_03_2020\AspNetCore_Berlin_30032020\AspNetCore_RazorPages\Pages\BlogArticle\Details.cshtml"
       Write(Html.DisplayFor(model => model.Blog.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 22 "C:\Meine Kurse\ASPNETCore_Berlin30_03_2020\AspNetCore_Berlin_30032020\AspNetCore_RazorPages\Pages\BlogArticle\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Blog.Content));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 25 "C:\Meine Kurse\ASPNETCore_Berlin30_03_2020\AspNetCore_Berlin_30032020\AspNetCore_RazorPages\Pages\BlogArticle\Details.cshtml"
       Write(Html.DisplayFor(model => model.Blog.Content));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 28 "C:\Meine Kurse\ASPNETCore_Berlin30_03_2020\AspNetCore_Berlin_30032020\AspNetCore_RazorPages\Pages\BlogArticle\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Blog.CreatedAt));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 31 "C:\Meine Kurse\ASPNETCore_Berlin30_03_2020\AspNetCore_Berlin_30032020\AspNetCore_RazorPages\Pages\BlogArticle\Details.cshtml"
       Write(Html.DisplayFor(model => model.Blog.CreatedAt));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 34 "C:\Meine Kurse\ASPNETCore_Berlin30_03_2020\AspNetCore_Berlin_30032020\AspNetCore_RazorPages\Pages\BlogArticle\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Blog.CreatedBy));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 37 "C:\Meine Kurse\ASPNETCore_Berlin30_03_2020\AspNetCore_Berlin_30032020\AspNetCore_RazorPages\Pages\BlogArticle\Details.cshtml"
       Write(Html.DisplayFor(model => model.Blog.CreatedBy));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n\r\n");
#nullable restore
#line 42 "C:\Meine Kurse\ASPNETCore_Berlin30_03_2020\AspNetCore_Berlin_30032020\AspNetCore_RazorPages\Pages\BlogArticle\Details.cshtml"
 foreach (var current in Model.Blog.Comments)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "C:\Meine Kurse\ASPNETCore_Berlin30_03_2020\AspNetCore_Berlin_30032020\AspNetCore_RazorPages\Pages\BlogArticle\Details.cshtml"
Write(current.Text);

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "C:\Meine Kurse\ASPNETCore_Berlin30_03_2020\AspNetCore_Berlin_30032020\AspNetCore_RazorPages\Pages\BlogArticle\Details.cshtml"
                 ; 
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d7abb6c6131435c843d592673ad62c48a94ce8c47825", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 47 "C:\Meine Kurse\ASPNETCore_Berlin30_03_2020\AspNetCore_Berlin_30032020\AspNetCore_RazorPages\Pages\BlogArticle\Details.cshtml"
                           WriteLiteral(Model.Blog.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d7abb6c6131435c843d592673ad62c48a94ce8c410015", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AspNetCore_RazorPages.Pages.BlogArticle.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AspNetCore_RazorPages.Pages.BlogArticle.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AspNetCore_RazorPages.Pages.BlogArticle.DetailsModel>)PageContext?.ViewData;
        public AspNetCore_RazorPages.Pages.BlogArticle.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
