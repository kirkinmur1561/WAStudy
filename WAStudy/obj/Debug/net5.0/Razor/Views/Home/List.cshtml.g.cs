#pragma checksum "S:\ReposProject\WAStudy\WAStudy\Views\Home\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c01bdcb095db3cd9f3e628b558bf15ab573c66a3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_List), @"mvc.1.0.view", @"/Views/Home/List.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c01bdcb095db3cd9f3e628b558bf15ab573c66a3", @"/Views/Home/List.cshtml")]
    public class Views_Home_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WAStudy.Models.m1.GuestResponse>>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "S:\ReposProject\WAStudy\WAStudy\Views\Home\List.cshtml"
  
    ViewData["Title"] = "List";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>List</h1>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c01bdcb095db3cd9f3e628b558bf15ab573c66a32739", async() => {
                WriteLiteral("\r\n<table>\r\n    <thead>\r\n    <tr>\r\n        <th>Name</th>\r\n        <th>Phone</th>\r\n        <th>Email</th>\r\n    </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 18 "S:\ReposProject\WAStudy\WAStudy\Views\Home\List.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 21 "S:\ReposProject\WAStudy\WAStudy\Views\Home\List.cshtml"
           Write(item.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 22 "S:\ReposProject\WAStudy\WAStudy\Views\Home\List.cshtml"
           Write(item.Phone);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n             <td>");
#nullable restore
#line 23 "S:\ReposProject\WAStudy\WAStudy\Views\Home\List.cshtml"
            Write(item.Email);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 25 "S:\ReposProject\WAStudy\WAStudy\Views\Home\List.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </tbody>\r\n</table>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WAStudy.Models.m1.GuestResponse>> Html { get; private set; }
    }
}
#pragma warning restore 1591
