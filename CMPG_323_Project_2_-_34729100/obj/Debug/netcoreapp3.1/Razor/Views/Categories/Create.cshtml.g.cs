#pragma checksum "C:\Users\Simangaliso\OneDrive - NORTH-WEST UNIVERSITY\Documents\GitHub\CMPG_323_Project_2_-_34729100\CMPG_323_Project_2_-_34729100\Views\Categories\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "05ec5252ab0ebf21730ede31db7e516f07937583"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Categories_Create), @"mvc.1.0.view", @"/Views/Categories/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"05ec5252ab0ebf21730ede31db7e516f07937583", @"/Views/Categories/Create.cshtml")]
    #nullable restore
    public class Views_Categories_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CMPG_323_Project_2___34729100.Models.Category>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Simangaliso\OneDrive - NORTH-WEST UNIVERSITY\Documents\GitHub\CMPG_323_Project_2_-_34729100\CMPG_323_Project_2_-_34729100\Views\Categories\Create.cshtml"
  
    ViewData["Title"] = "Create";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Create</h1>

<h4>Category</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Create"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <div class=""form-group"">
                <label asp-for=""CategoryId"" class=""control-label""></label>
                <input asp-for=""CategoryId"" class=""form-control"" />
                <span asp-validation-for=""CategoryId"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""CategoryName"" class=""control-label""></label>
                <input asp-for=""CategoryName"" class=""form-control"" />
                <span asp-validation-for=""CategoryName"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""CategoryDescription"" class=""control-label""></label>
                <input asp-for=""CategoryDescription"" class=""form-control"" />
                <span asp-validati");
            WriteLiteral(@"on-for=""CategoryDescription"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Create"" class=""btn btn-primary"" />
            </div>
        </form>
    </div>
</div>

<div>
    <a asp-action=""Index"">Back to List</a>
</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 42 "C:\Users\Simangaliso\OneDrive - NORTH-WEST UNIVERSITY\Documents\GitHub\CMPG_323_Project_2_-_34729100\CMPG_323_Project_2_-_34729100\Views\Categories\Create.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
            }
            );
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CMPG_323_Project_2___34729100.Models.Category> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
