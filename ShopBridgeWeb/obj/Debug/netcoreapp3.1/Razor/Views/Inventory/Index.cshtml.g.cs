#pragma checksum "C:\Users\spalaniappan\source\ShopBridge\WebAPI\ShopBridgeWeb\Views\Inventory\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2abc451b0a5a0bbc8d7225d9b9b5b0e92d310279"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Inventory_Index), @"mvc.1.0.view", @"/Views/Inventory/Index.cshtml")]
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
#line 1 "C:\Users\spalaniappan\source\ShopBridge\WebAPI\ShopBridgeWeb\Views\_ViewImports.cshtml"
using ShopBridgeWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\spalaniappan\source\ShopBridge\WebAPI\ShopBridgeWeb\Views\_ViewImports.cshtml"
using ShopBridgeWeb.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2abc451b0a5a0bbc8d7225d9b9b5b0e92d310279", @"/Views/Inventory/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67d2934702217f431b83a543e559e08dcf3cab68", @"/Views/_ViewImports.cshtml")]
    public class Views_Inventory_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/Inventory/Inventory.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2abc451b0a5a0bbc8d7225d9b9b5b0e92d3102793858", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<style>
    .button {
        padding-top: 12px;
        padding-bottom: 12px;
        text-align: left;
        background-color: #4CAF50;
        color: white;
    }

    #myOverlay {
        position: absolute;
        top: 0;
        left: 0;
        height: 100%;
        width: 100%;
    }

    #myOverlay {
        background: black;
        backdrop-filter: blur(4px);
        opacity: .4;
        z-index: 2;
        display: none;
    }

    #loadingGIF {
        position: absolute;
        top: 10%;
        left: 35%;
        z-index: 3;
        display: none;
    }


    #tblGrid {
        font-family: Arial, Helvetica, sans-serif;
        border-collapse: collapse;
        width: 100%;
    }

        #tblGrid td, #tblGrid th {
            border: 1px solid #ddd;
            padding: 8px;
        }

        #tblGrid tr:nth-child(even) {
            background-color: #f2f2f2;
        }

        #tblGrid tr:hover {
            background-color: #ddd;
");
            WriteLiteral(@"        }

        #tblGrid th {
            padding-top: 12px;
            padding-bottom: 12px;
            text-align: left;
            background-color: #4CAF50;
            color: white;
        }
</style>
<div class=""w-50"">
    <div class=""col-md-2"">
        Name
    </div>
    <div class=""col-md-10"">
        <input type=""text"" id=""txtInventoryName"" class=""form-control"" placeholder=""Enter Inventory Name"" />
    </div>
    <div class=""col-md-2"">
        Description
    </div>
    <div class=""col-md-10"">
        <input type=""text"" id=""txtInventoryDescription"" class=""form-control"" placeholder=""Enter Inventory Description"" />
    </div>

    <div class=""col-md-2"">
        Price
    </div>
    <div class=""col-md-10"">
        <input type=""text"" id=""txtInventoryPrice"" class=""form-control"" placeholder=""Enter Inventory Price"" />
    </div>
    <br />

    <div class=""col-md-12"">
        <button class=""btn btn-success"" onclick=""SaveInventory(this)"">Save Inventory</button>
      ");
            WriteLiteral(@"  <button class=""btn btn-success"" onclick=""Clear()"">Clear</button>
    </div>
</div>
<br />
<br />
<div class=""container"">
    <table id=""tblGrid"" class=""table table-striped table-bordered table-sm"" cellspacing=""0"" width=""100%"">
    </table>
    <input type=""hidden"" id=""idinv"" name=""idinv"" value=""0"" />
</div>
");
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
