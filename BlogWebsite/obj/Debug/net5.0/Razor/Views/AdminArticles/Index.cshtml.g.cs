#pragma checksum "C:\Users\Hieu Hieu\Documents\Zalo Received Files\BlogWebsite\BlogWebsite\BlogWebsite\Views\AdminArticles\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "593acc209efa533bc2a60ce78887f593cc4de82d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdminArticles_Index), @"mvc.1.0.view", @"/Views/AdminArticles/Index.cshtml")]
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
#nullable restore
#line 2 "C:\Users\Hieu Hieu\Documents\Zalo Received Files\BlogWebsite\BlogWebsite\BlogWebsite\Views\AdminArticles\Index.cshtml"
using PagedList.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Hieu Hieu\Documents\Zalo Received Files\BlogWebsite\BlogWebsite\BlogWebsite\Views\AdminArticles\Index.cshtml"
using PagedList;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"593acc209efa533bc2a60ce78887f593cc4de82d", @"/Views/AdminArticles/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5c62f4659e58e4f161da2f4232506b072bf24a9a", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_AdminArticles_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IPagedList<BlogWebsite.Models.Article>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("for", new global::Microsoft.AspNetCore.Html.HtmlString("CategoryId"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "CategoryId", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("for", new global::Microsoft.AspNetCore.Html.HtmlString("sortOrder"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "sortOrder", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Admin/Articles"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onsubmit", new global::Microsoft.AspNetCore.Html.HtmlString("removeNullEmptyInputs()"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\Hieu Hieu\Documents\Zalo Received Files\BlogWebsite\BlogWebsite\BlogWebsite\Views\AdminArticles\Index.cshtml"
  
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"container-fluid\">\r\n\r\n    <!-- Page Heading -->\r\n    <h1 class=\"h3 mb-2 text-gray-800\">Quản lý bài viết</h1>\r\n    <p class=\"mb-4\">Tổng số bài viết: <span class=\"text-primary\">");
#nullable restore
#line 14 "C:\Users\Hieu Hieu\Documents\Zalo Received Files\BlogWebsite\BlogWebsite\BlogWebsite\Views\AdminArticles\Index.cshtml"
                                                            Write(Model.TotalItemCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span> </p>
    <!-- DataTales Example -->
    <div class=""card shadow mb-4"">
        <div class=""card-header py-3"">
            <h6 class=""m-0 font-weight-bold text-primary d-inline-block"">Danh sách bài viết</h6>
            <a class=""btn btn-primary ml-5"" href=""/Admin/CreateArticle"" role=""button"">Thêm bài viết</a>
        </div>
        <div class=""card-body"">
            <div class=""table-responsive-md"">

                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "593acc209efa533bc2a60ce78887f593cc4de82d8779", async() => {
                WriteLiteral("\r\n                    <div class=\"form-row\">\r\n                        <div class=\"form-group col-md-3\">\r\n                            <label for=\"q\">Search</label>\r\n\r\n");
#nullable restore
#line 29 "C:\Users\Hieu Hieu\Documents\Zalo Received Files\BlogWebsite\BlogWebsite\BlogWebsite\Views\AdminArticles\Index.cshtml"
                             if (string.IsNullOrEmpty(ViewBag.SearchString))
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <input type=\"text\" class=\"form-control\" id=\"q\" name=\"q\" placeholder=\"Nhập...\"");
                BeginWriteAttribute("value", " value=\"", 1295, "\"", 1303, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n");
#nullable restore
#line 32 "C:\Users\Hieu Hieu\Documents\Zalo Received Files\BlogWebsite\BlogWebsite\BlogWebsite\Views\AdminArticles\Index.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <input type=\"text\" class=\"form-control\" id=\"q\" name=\"q\" placeholder=\"Nhập...\"");
                BeginWriteAttribute("value", " value=", 1514, "", 1542, 1);
#nullable restore
#line 35 "C:\Users\Hieu Hieu\Documents\Zalo Received Files\BlogWebsite\BlogWebsite\BlogWebsite\Views\AdminArticles\Index.cshtml"
WriteAttributeValue("", 1521, ViewBag.SearchString, 1521, 21, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n");
#nullable restore
#line 36 "C:\Users\Hieu Hieu\Documents\Zalo Received Files\BlogWebsite\BlogWebsite\BlogWebsite\Views\AdminArticles\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("                        </div>\r\n                        <div class=\"form-group col-md-3\">\r\n                            <label for=\"CategoryId\" class=\"control-label\">Category</label>\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "593acc209efa533bc2a60ce78887f593cc4de82d11202", async() => {
                    WriteLiteral("\r\n                                ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "593acc209efa533bc2a60ce78887f593cc4de82d11503", async() => {
                        WriteLiteral("Please Select");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n                            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Name = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
#nullable restore
#line 40 "C:\Users\Hieu Hieu\Documents\Zalo Received Files\BlogWebsite\BlogWebsite\BlogWebsite\Views\AdminArticles\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = ViewBag.CategorySelectlist;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        </div>\r\n                        <div class=\"form-group col-md-3\">\r\n                            <label for=\"sortOrder\" class=\"control-label\">Order by</label>\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "593acc209efa533bc2a60ce78887f593cc4de82d14690", async() => {
                    WriteLiteral("\r\n                                ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "593acc209efa533bc2a60ce78887f593cc4de82d14991", async() => {
                        WriteLiteral("Please Select");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n                            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Name = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
#nullable restore
#line 46 "C:\Users\Hieu Hieu\Documents\Zalo Received Files\BlogWebsite\BlogWebsite\BlogWebsite\Views\AdminArticles\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = ViewBag.OrderSelectlist;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        <input type=\"submit\" value=\"Lọc\" class=\"btn btn-primary\" />\r\n                    </div>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"


                <table class=""table table-bordered"" id=""dataTable"" width=""100%"" cellspacing=""0"">
                    <thead>
                        <tr>
                            <th>ID</th>
                            <th>Title</th>
                            <th>Thumb</th>
                            <th>Category</th>
                            <th>Date</th>
");
#nullable restore
#line 65 "C:\Users\Hieu Hieu\Documents\Zalo Received Files\BlogWebsite\BlogWebsite\BlogWebsite\Views\AdminArticles\Index.cshtml"
                             if (User.IsInRole("Admin"))
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <th>Author</th>\r\n                                <th>Status</th>\r\n");
#nullable restore
#line 69 "C:\Users\Hieu Hieu\Documents\Zalo Received Files\BlogWebsite\BlogWebsite\BlogWebsite\Views\AdminArticles\Index.cshtml"

                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <th>Option</th>\r\n                        </tr>\r\n                    </thead>\r\n                    <tbody>\r\n");
#nullable restore
#line 75 "C:\Users\Hieu Hieu\Documents\Zalo Received Files\BlogWebsite\BlogWebsite\BlogWebsite\Views\AdminArticles\Index.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>");
#nullable restore
#line 78 "C:\Users\Hieu Hieu\Documents\Zalo Received Files\BlogWebsite\BlogWebsite\BlogWebsite\Views\AdminArticles\Index.cshtml"
                               Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td class=\"w-25\">");
#nullable restore
#line 79 "C:\Users\Hieu Hieu\Documents\Zalo Received Files\BlogWebsite\BlogWebsite\BlogWebsite\Views\AdminArticles\Index.cshtml"
                                            Write(item.ArticleTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td class=\"text-center\"><img");
            BeginWriteAttribute("src", " src=\"", 3707, "\"", 3731, 1);
#nullable restore
#line 80 "C:\Users\Hieu Hieu\Documents\Zalo Received Files\BlogWebsite\BlogWebsite\BlogWebsite\Views\AdminArticles\Index.cshtml"
WriteAttributeValue("", 3713, item.ArticleThumb, 3713, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n                                <td>");
#nullable restore
#line 81 "C:\Users\Hieu Hieu\Documents\Zalo Received Files\BlogWebsite\BlogWebsite\BlogWebsite\Views\AdminArticles\Index.cshtml"
                               Write(item.Category.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 82 "C:\Users\Hieu Hieu\Documents\Zalo Received Files\BlogWebsite\BlogWebsite\BlogWebsite\Views\AdminArticles\Index.cshtml"
                               Write(item.ArticleDate.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 83 "C:\Users\Hieu Hieu\Documents\Zalo Received Files\BlogWebsite\BlogWebsite\BlogWebsite\Views\AdminArticles\Index.cshtml"
                                 if (User.IsInRole("Admin"))
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <td>");
#nullable restore
#line 85 "C:\Users\Hieu Hieu\Documents\Zalo Received Files\BlogWebsite\BlogWebsite\BlogWebsite\Views\AdminArticles\Index.cshtml"
                                   Write(item.Author.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>\r\n                                        <div class=\"custom-control custom-switch\">\r\n");
#nullable restore
#line 88 "C:\Users\Hieu Hieu\Documents\Zalo Received Files\BlogWebsite\BlogWebsite\BlogWebsite\Views\AdminArticles\Index.cshtml"
                                             if (item.ArticleStatus == true)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <input class=\"custom-control-input\" type=\"checkbox\" checked");
            BeginWriteAttribute("id", " id=\"", 4418, "\"", 4431, 1);
#nullable restore
#line 90 "C:\Users\Hieu Hieu\Documents\Zalo Received Files\BlogWebsite\BlogWebsite\BlogWebsite\Views\AdminArticles\Index.cshtml"
WriteAttributeValue("", 4423, item.Id, 4423, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("onclick", " onclick=\"", 4432, "\"", 4464, 3);
            WriteAttributeValue("", 4442, "changeStatus(", 4442, 13, true);
#nullable restore
#line 90 "C:\Users\Hieu Hieu\Documents\Zalo Received Files\BlogWebsite\BlogWebsite\BlogWebsite\Views\AdminArticles\Index.cshtml"
WriteAttributeValue("", 4455, item.Id, 4455, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4463, ")", 4463, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                <label class=\"custom-control-label\"");
            BeginWriteAttribute("for", " for=\"", 4551, "\"", 4565, 1);
#nullable restore
#line 91 "C:\Users\Hieu Hieu\Documents\Zalo Received Files\BlogWebsite\BlogWebsite\BlogWebsite\Views\AdminArticles\Index.cshtml"
WriteAttributeValue("", 4557, item.Id, 4557, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">&nbsp;</label>\r\n");
#nullable restore
#line 92 "C:\Users\Hieu Hieu\Documents\Zalo Received Files\BlogWebsite\BlogWebsite\BlogWebsite\Views\AdminArticles\Index.cshtml"
                                            }
                                            else
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <input class=\"custom-control-input\" type=\"checkbox\"");
            BeginWriteAttribute("id", " id=\"", 4826, "\"", 4839, 1);
#nullable restore
#line 95 "C:\Users\Hieu Hieu\Documents\Zalo Received Files\BlogWebsite\BlogWebsite\BlogWebsite\Views\AdminArticles\Index.cshtml"
WriteAttributeValue("", 4831, item.Id, 4831, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("onclick", " onclick=\"", 4840, "\"", 4872, 3);
            WriteAttributeValue("", 4850, "changeStatus(", 4850, 13, true);
#nullable restore
#line 95 "C:\Users\Hieu Hieu\Documents\Zalo Received Files\BlogWebsite\BlogWebsite\BlogWebsite\Views\AdminArticles\Index.cshtml"
WriteAttributeValue("", 4863, item.Id, 4863, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4871, ")", 4871, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                <label class=\"custom-control-label\"");
            BeginWriteAttribute("for", " for=\"", 4959, "\"", 4973, 1);
#nullable restore
#line 96 "C:\Users\Hieu Hieu\Documents\Zalo Received Files\BlogWebsite\BlogWebsite\BlogWebsite\Views\AdminArticles\Index.cshtml"
WriteAttributeValue("", 4965, item.Id, 4965, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">&nbsp;</label>\r\n");
#nullable restore
#line 97 "C:\Users\Hieu Hieu\Documents\Zalo Received Files\BlogWebsite\BlogWebsite\BlogWebsite\Views\AdminArticles\Index.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        </div>\r\n                                    </td>\r\n");
#nullable restore
#line 100 "C:\Users\Hieu Hieu\Documents\Zalo Received Files\BlogWebsite\BlogWebsite\BlogWebsite\Views\AdminArticles\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td>\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "593acc209efa533bc2a60ce78887f593cc4de82d28240", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 102 "C:\Users\Hieu Hieu\Documents\Zalo Received Files\BlogWebsite\BlogWebsite\BlogWebsite\Views\AdminArticles\Index.cshtml"
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
            WriteLiteral(" |\r\n                                    <a");
            BeginWriteAttribute("onclick", " onclick=\"", 5333, "\"", 5374, 3);
            WriteAttributeValue("", 5343, "deleteArticleFunction(", 5343, 22, true);
#nullable restore
#line 103 "C:\Users\Hieu Hieu\Documents\Zalo Received Files\BlogWebsite\BlogWebsite\BlogWebsite\Views\AdminArticles\Index.cshtml"
WriteAttributeValue("", 5365, item.Id, 5365, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5373, ")", 5373, 1, true);
            EndWriteAttribute();
            WriteLiteral(" href=\"#\" data-toggle=\"modal\" data-target=\"#deleteModal\">Delete</a>\r\n                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 106 "C:\Users\Hieu Hieu\Documents\Zalo Received Files\BlogWebsite\BlogWebsite\BlogWebsite\Views\AdminArticles\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n        <div class=\"row d-flex justify-content-center\">\r\n            ");
#nullable restore
#line 115 "C:\Users\Hieu Hieu\Documents\Zalo Received Files\BlogWebsite\BlogWebsite\BlogWebsite\Views\AdminArticles\Index.cshtml"
       Write(Html.Partial("PaginationAdminPartial"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </div>

    </div>

</div>
<script>
    function removeNullEmptyInputs() {
        var inputs = document.getElementsByTagName('input');
        for (var i = 0; i < inputs.length; i++) {
            if (inputs[i].value == """") {
                inputs[i].remove();
            }
        }
        var selects = document.querySelectorAll('select');
        for (var i = 0; i < selects.length; i++) {
            if (selects[i].value == """") {
                selects[i].remove();
            }
        }
    }

    function deleteArticleFunction(id) {
        $('#deleteModal .btn-primary').attr('href', '/Admin/DeleteArticle/' + id);
    }

    function changeStatus(id) {
        $.ajax({
            url: '/Admin/ActiveArticle/' + id,
            type: 'POST',
            processData: false,
            contentType: false,
            success: function (data) {
                $.toast({
                title: 'Thành công',
                content: data,
                type: ");
            WriteLiteral(@"'success',
                delay: 3000,
                dismissible: true
            })
            },
            error: function (xhr, status, error) {
                $.toast({
                    title: 'Thất bại',
                    content: 'Thay đổi trạng thái bài viết thất bại',
                    type: 'error',
                    delay: 3000,
                    dismissible: true
                });
                $(""#"" + id).prop(""checked"", function (i, value) {
                    return !value;
                });
            }
        });
    }


</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IPagedList<BlogWebsite.Models.Article>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591