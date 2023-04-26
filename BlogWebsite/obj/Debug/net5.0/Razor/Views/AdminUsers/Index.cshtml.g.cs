#pragma checksum "C:\Users\Hieu Hieu\Documents\Zalo Received Files\BlogWebsite\BlogWebsite\BlogWebsite\Views\AdminUsers\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8c74e0df573756869bc1dd2f17284d1698f306f6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdminUsers_Index), @"mvc.1.0.view", @"/Views/AdminUsers/Index.cshtml")]
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
#line 1 "C:\Users\Hieu Hieu\Documents\Zalo Received Files\BlogWebsite\BlogWebsite\BlogWebsite\Views\_ViewImports.cshtml"
using BlogWebsite;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Hieu Hieu\Documents\Zalo Received Files\BlogWebsite\BlogWebsite\BlogWebsite\Views\_ViewImports.cshtml"
using BlogWebsite.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8c74e0df573756869bc1dd2f17284d1698f306f6", @"/Views/AdminUsers/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5c62f4659e58e4f161da2f4232506b072bf24a9a", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_AdminUsers_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BlogWebsite.Models.User>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\Hieu Hieu\Documents\Zalo Received Files\BlogWebsite\BlogWebsite\BlogWebsite\Views\AdminUsers\Index.cshtml"
  
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"container-fluid\">\r\n\r\n    <!-- Page Heading -->\r\n    <h1 class=\"h3 mb-2 text-gray-800\">Quản lý người viết</h1>\r\n    <p class=\"mb-4\">Tổng số người viết: <span class=\"text-primary\">");
#nullable restore
#line 10 "C:\Users\Hieu Hieu\Documents\Zalo Received Files\BlogWebsite\BlogWebsite\BlogWebsite\Views\AdminUsers\Index.cshtml"
                                                              Write(Model.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span> </p>
    <!-- DataTales Example -->
    <div class=""card shadow mb-4"">
        <div class=""card-header py-3"">
            <h6 class=""m-0 font-weight-bold text-primary d-inline-block"">Danh sách người viết</h6>
            <a class=""btn btn-primary ml-5"" href=""/Admin/CreateUser"" role=""button"">Thêm người viết</a>
        </div>
        <div class=""card-body"">
            <div class=""table-responsive-md"">
                <table class=""table table-bordered"" id=""dataTable"" width=""100%"" cellspacing=""0"">
                    <thead>
                        <tr>
                            <th>ID</th>
                            <th>Name</th>
                            <th>Email</th>
                            <th>Role</th>
                            <th>Option</th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 30 "C:\Users\Hieu Hieu\Documents\Zalo Received Files\BlogWebsite\BlogWebsite\BlogWebsite\Views\AdminUsers\Index.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 33 "C:\Users\Hieu Hieu\Documents\Zalo Received Files\BlogWebsite\BlogWebsite\BlogWebsite\Views\AdminUsers\Index.cshtml"
                           Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 34 "C:\Users\Hieu Hieu\Documents\Zalo Received Files\BlogWebsite\BlogWebsite\BlogWebsite\Views\AdminUsers\Index.cshtml"
                           Write(item.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 35 "C:\Users\Hieu Hieu\Documents\Zalo Received Files\BlogWebsite\BlogWebsite\BlogWebsite\Views\AdminUsers\Index.cshtml"
                           Write(item.UserEmail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 36 "C:\Users\Hieu Hieu\Documents\Zalo Received Files\BlogWebsite\BlogWebsite\BlogWebsite\Views\AdminUsers\Index.cshtml"
                           Write(item.UserRole);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8c74e0df573756869bc1dd2f17284d1698f306f66944", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 38 "C:\Users\Hieu Hieu\Documents\Zalo Received Files\BlogWebsite\BlogWebsite\BlogWebsite\Views\AdminUsers\Index.cshtml"
                                                       WriteLiteral(item.Id);

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
            WriteLiteral(" |\r\n                                <a");
            BeginWriteAttribute("onclick", " onclick=\"", 1702, "\"", 1740, 3);
            WriteAttributeValue("", 1712, "deleteUserFunction(", 1712, 19, true);
#nullable restore
#line 39 "C:\Users\Hieu Hieu\Documents\Zalo Received Files\BlogWebsite\BlogWebsite\BlogWebsite\Views\AdminUsers\Index.cshtml"
WriteAttributeValue("", 1731, item.Id, 1731, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1739, ")", 1739, 1, true);
            EndWriteAttribute();
            WriteLiteral(" href=\"#\" data-toggle=\"modal\" data-target=\"#deleteModal\">Delete</a>\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 42 "C:\Users\Hieu Hieu\Documents\Zalo Received Files\BlogWebsite\BlogWebsite\BlogWebsite\Views\AdminUsers\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


                    </tbody>
                </table>
            </div>
        </div>
    </div>
</div>
<script>
    function deleteUserFunction(id) {
        $('#deleteModal .btn-primary').attr('href', '/Admin/DeleteUser/' + id);
    }
</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BlogWebsite.Models.User>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
