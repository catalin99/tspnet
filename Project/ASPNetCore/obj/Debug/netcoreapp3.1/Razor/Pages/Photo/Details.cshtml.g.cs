#pragma checksum "W:\Faculty\tspnet\Laboratoare Catalin Belu\tspnet\Project\ASPNetCore\Pages\Photo\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4215b3d61b8771ef369c832a2d67903eefd34072"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ASPNetCore.Pages.Photo.Pages_Photo_Details), @"mvc.1.0.razor-page", @"/Pages/Photo/Details.cshtml")]
namespace ASPNetCore.Pages.Photo
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
#line 1 "W:\Faculty\tspnet\Laboratoare Catalin Belu\tspnet\Project\ASPNetCore\Pages\_ViewImports.cshtml"
using ASPNetCore;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4215b3d61b8771ef369c832a2d67903eefd34072", @"/Pages/Photo/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"925d04be98f9661a4f7fd12cbf573abbd75cd31d", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Photo_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
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
#line 4 "W:\Faculty\tspnet\Laboratoare Catalin Belu\tspnet\Project\ASPNetCore\Pages\Photo\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n<div>\r\n    <h4>PhotoDTO</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 14 "W:\Faculty\tspnet\Laboratoare Catalin Belu\tspnet\Project\ASPNetCore\Pages\Photo\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PhotoDTO.FullPath));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 17 "W:\Faculty\tspnet\Laboratoare Catalin Belu\tspnet\Project\ASPNetCore\Pages\Photo\Details.cshtml"
       Write(Html.DisplayFor(model => model.PhotoDTO.FullPath));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 20 "W:\Faculty\tspnet\Laboratoare Catalin Belu\tspnet\Project\ASPNetCore\Pages\Photo\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PhotoDTO.PhotoName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 23 "W:\Faculty\tspnet\Laboratoare Catalin Belu\tspnet\Project\ASPNetCore\Pages\Photo\Details.cshtml"
       Write(Html.DisplayFor(model => model.PhotoDTO.PhotoName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 26 "W:\Faculty\tspnet\Laboratoare Catalin Belu\tspnet\Project\ASPNetCore\Pages\Photo\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PhotoDTO.CreationDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 29 "W:\Faculty\tspnet\Laboratoare Catalin Belu\tspnet\Project\ASPNetCore\Pages\Photo\Details.cshtml"
       Write(Html.DisplayFor(model => model.PhotoDTO.CreationDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 32 "W:\Faculty\tspnet\Laboratoare Catalin Belu\tspnet\Project\ASPNetCore\Pages\Photo\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PhotoDTO.Event));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 35 "W:\Faculty\tspnet\Laboratoare Catalin Belu\tspnet\Project\ASPNetCore\Pages\Photo\Details.cshtml"
       Write(Html.DisplayFor(model => model.PhotoDTO.Event));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 38 "W:\Faculty\tspnet\Laboratoare Catalin Belu\tspnet\Project\ASPNetCore\Pages\Photo\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PhotoDTO.TaggedPersons));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 41 "W:\Faculty\tspnet\Laboratoare Catalin Belu\tspnet\Project\ASPNetCore\Pages\Photo\Details.cshtml"
       Write(Html.DisplayFor(model => model.PhotoDTO.TaggedPersons));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 44 "W:\Faculty\tspnet\Laboratoare Catalin Belu\tspnet\Project\ASPNetCore\Pages\Photo\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PhotoDTO.Location));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 47 "W:\Faculty\tspnet\Laboratoare Catalin Belu\tspnet\Project\ASPNetCore\Pages\Photo\Details.cshtml"
       Write(Html.DisplayFor(model => model.PhotoDTO.Location));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n");
            WriteLiteral("        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 56 "W:\Faculty\tspnet\Laboratoare Catalin Belu\tspnet\Project\ASPNetCore\Pages\Photo\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PhotoDTO.Height));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 59 "W:\Faculty\tspnet\Laboratoare Catalin Belu\tspnet\Project\ASPNetCore\Pages\Photo\Details.cshtml"
       Write(Html.DisplayFor(model => model.PhotoDTO.Height));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 62 "W:\Faculty\tspnet\Laboratoare Catalin Belu\tspnet\Project\ASPNetCore\Pages\Photo\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PhotoDTO.Weight));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 65 "W:\Faculty\tspnet\Laboratoare Catalin Belu\tspnet\Project\ASPNetCore\Pages\Photo\Details.cshtml"
       Write(Html.DisplayFor(model => model.PhotoDTO.Weight));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    <hr />\r\n    <h4>Special Properties</h4>\r\n    <dl>\r\n");
#nullable restore
#line 71 "W:\Faculty\tspnet\Laboratoare Catalin Belu\tspnet\Project\ASPNetCore\Pages\Photo\Details.cshtml"
         foreach (var item in @Model.PhotoDTO.Props)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 74 "W:\Faculty\tspnet\Laboratoare Catalin Belu\tspnet\Project\ASPNetCore\Pages\Photo\Details.cshtml"
           Write(item.Item1);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 77 "W:\Faculty\tspnet\Laboratoare Catalin Belu\tspnet\Project\ASPNetCore\Pages\Photo\Details.cshtml"
           Write(item.Item2);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n");
#nullable restore
#line 79 "W:\Faculty\tspnet\Laboratoare Catalin Belu\tspnet\Project\ASPNetCore\Pages\Photo\Details.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </dl>\r\n</div>\r\n<div>\r\n    <img");
            BeginWriteAttribute("src", " src=\"", 2578, "\"", 2622, 1);
#nullable restore
#line 83 "W:\Faculty\tspnet\Laboratoare Catalin Belu\tspnet\Project\ASPNetCore\Pages\Photo\Details.cshtml"
WriteAttributeValue("", 2584, Url.Content(@Model.PhotoDTO.FullPath), 2584, 38, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"missing\" style=\"width:200px;height:200px\" />\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4215b3d61b8771ef369c832a2d67903eefd3407211163", async() => {
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
#line 86 "W:\Faculty\tspnet\Laboratoare Catalin Belu\tspnet\Project\ASPNetCore\Pages\Photo\Details.cshtml"
                           WriteLiteral(Model.PhotoDTO.ID);

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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4215b3d61b8771ef369c832a2d67903eefd3407213329", async() => {
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ASPNetCore.Pages.Photo.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ASPNetCore.Pages.Photo.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ASPNetCore.Pages.Photo.DetailsModel>)PageContext?.ViewData;
        public ASPNetCore.Pages.Photo.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
