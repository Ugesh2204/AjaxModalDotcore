#pragma checksum "C:\Users\Ugesh\source\repos\AjaxModal\AjaxModal\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4d4c79a61d747d2c39782e909f038299f012847d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\Ugesh\source\repos\AjaxModal\AjaxModal\Views\_ViewImports.cshtml"
using AjaxModal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ugesh\source\repos\AjaxModal\AjaxModal\Views\_ViewImports.cshtml"
using AjaxModal.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d4c79a61d747d2c39782e909f038299f012847d", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"772ae3adb2a7de5a6a48dd90ced6f955fdab8b81", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Contact>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Ugesh\source\repos\AjaxModal\AjaxModal\Views\Home\Index.cshtml"
   ViewData["Title"] = "Contact form"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("<!-- Modal placeholder -->\r\n<div id=\"modal-placeholder\"></div>\r\n\r\n<!-- Button trigger modal -->\r\n<button type=\"button\" class=\"btn btn-primary\" data-toggle=\"ajax-modal\" data-target=\"#add-contact\" data-url=\"");
#nullable restore
#line 7 "C:\Users\Ugesh\source\repos\AjaxModal\AjaxModal\Views\Home\Index.cshtml"
                                                                                                       Write(Url.Action("Contact"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n    Add contact\r\n</button>\r\n\r\n<!--https://softdevpractice.com/blog/asp-net-core-mvc-ajax-modals/-->\r\n<!--https://github.com/zbma/asp.net-core-bootstrap-ajax-modals/blob/master/AjaxModals/wwwroot/js/site.js-->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Contact> Html { get; private set; }
    }
}
#pragma warning restore 1591
