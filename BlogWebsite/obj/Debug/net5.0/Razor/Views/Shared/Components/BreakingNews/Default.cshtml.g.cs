#pragma checksum "C:\Users\Hieu Hieu\Documents\Zalo Received Files\BlogWebsite\BlogWebsite\BlogWebsite\Views\Shared\Components\BreakingNews\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bc49f71a3853dfaf7c635871996ccf95e97513da"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_BreakingNews_Default), @"mvc.1.0.view", @"/Views/Shared/Components/BreakingNews/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc49f71a3853dfaf7c635871996ccf95e97513da", @"/Views/Shared/Components/BreakingNews/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5c62f4659e58e4f161da2f4232506b072bf24a9a", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_BreakingNews_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Article>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Hieu Hieu\Documents\Zalo Received Files\BlogWebsite\BlogWebsite\BlogWebsite\Views\Shared\Components\BreakingNews\Default.cshtml"
 if (Model.Count() >= 3)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"container-fluid paddding mb-5\">\r\n        <div class=\"row mx-0\">\r\n            <div class=\"col-md-8 col-12 paddding animate-box\" data-animate-effect=\"fadeIn\">\r\n                <div class=\"fh5co_suceefh5co_height\">\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 304, "\"", 442, 1);
#nullable restore
#line 9 "C:\Users\Hieu Hieu\Documents\Zalo Received Files\BlogWebsite\BlogWebsite\BlogWebsite\Views\Shared\Components\BreakingNews\Default.cshtml"
WriteAttributeValue("", 311, Url.Action("DetailsArticle", "Home", new {slug = @Model.ElementAt(0).ArticleTitle.Replace(" ","-"), id = @Model.ElementAt(0).Id }), 311, 131, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <img");
            BeginWriteAttribute("src", " src=\"", 474, "\"", 512, 1);
#nullable restore
#line 10 "C:\Users\Hieu Hieu\Documents\Zalo Received Files\BlogWebsite\BlogWebsite\BlogWebsite\Views\Shared\Components\BreakingNews\Default.cshtml"
WriteAttributeValue("", 480, Model.ElementAt(0).ArticleThumb, 480, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"img\" />\r\n                        <div class=\"fh5co_suceefh5co_height_position_absolute\"></div>\r\n                        <div class=\"fh5co_suceefh5co_height_position_absolute_font\">\r\n                            <div");
            BeginWriteAttribute("class", " class=\"", 733, "\"", 741, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 779, "\"", 917, 1);
#nullable restore
#line 14 "C:\Users\Hieu Hieu\Documents\Zalo Received Files\BlogWebsite\BlogWebsite\BlogWebsite\Views\Shared\Components\BreakingNews\Default.cshtml"
WriteAttributeValue("", 786, Url.Action("DetailsArticle", "Home", new {slug = @Model.ElementAt(0).ArticleTitle.Replace(" ","-"), id = @Model.ElementAt(0).Id }), 786, 131, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"color_fff\">\r\n                                    <i class=\"fa fa-clock-o\"></i>&nbsp;&nbsp; ");
#nullable restore
#line 15 "C:\Users\Hieu Hieu\Documents\Zalo Received Files\BlogWebsite\BlogWebsite\BlogWebsite\Views\Shared\Components\BreakingNews\Default.cshtml"
                                                                         Write(Model.ElementAt(0).ArticleDate.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </a>\r\n                            </div>\r\n                            <div");
            BeginWriteAttribute("class", " class=\"", 1179, "\"", 1187, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 1225, "\"", 1363, 1);
#nullable restore
#line 19 "C:\Users\Hieu Hieu\Documents\Zalo Received Files\BlogWebsite\BlogWebsite\BlogWebsite\Views\Shared\Components\BreakingNews\Default.cshtml"
WriteAttributeValue("", 1232, Url.Action("DetailsArticle", "Home", new {slug = @Model.ElementAt(0).ArticleTitle.Replace(" ","-"), id = @Model.ElementAt(0).Id }), 1232, 131, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"fh5co_good_font\">\r\n                                    ");
#nullable restore
#line 20 "C:\Users\Hieu Hieu\Documents\Zalo Received Files\BlogWebsite\BlogWebsite\BlogWebsite\Views\Shared\Components\BreakingNews\Default.cshtml"
                               Write(Model.ElementAt(0).ArticleTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </a>
                            </div>
                        </div>
                    </a>
                </div>
            </div>
            <div class=""col-md-4"">
                <div class=""row"">
                    <div class=""col-md-12 col-6 paddding animate-box"" data-animate-effect=""fadeIn"">
                        <div class=""fh5co_suceefh5co_height_2"">
                            <a");
            BeginWriteAttribute("href", " href=\"", 1904, "\"", 2042, 1);
#nullable restore
#line 31 "C:\Users\Hieu Hieu\Documents\Zalo Received Files\BlogWebsite\BlogWebsite\BlogWebsite\Views\Shared\Components\BreakingNews\Default.cshtml"
WriteAttributeValue("", 1911, Url.Action("DetailsArticle", "Home", new {slug = @Model.ElementAt(1).ArticleTitle.Replace(" ","-"), id = @Model.ElementAt(1).Id }), 1911, 131, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <img");
            BeginWriteAttribute("src", " src=\"", 2082, "\"", 2120, 1);
#nullable restore
#line 32 "C:\Users\Hieu Hieu\Documents\Zalo Received Files\BlogWebsite\BlogWebsite\BlogWebsite\Views\Shared\Components\BreakingNews\Default.cshtml"
WriteAttributeValue("", 2088, Model.ElementAt(1).ArticleThumb, 2088, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"img\" />\r\n                                <div class=\"fh5co_suceefh5co_height_position_absolute\"></div>\r\n                                <div class=\"fh5co_suceefh5co_height_position_absolute_font_2\">\r\n                                    <div");
            BeginWriteAttribute("class", " class=\"", 2367, "\"", 2375, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 2421, "\"", 2559, 1);
#nullable restore
#line 36 "C:\Users\Hieu Hieu\Documents\Zalo Received Files\BlogWebsite\BlogWebsite\BlogWebsite\Views\Shared\Components\BreakingNews\Default.cshtml"
WriteAttributeValue("", 2428, Url.Action("DetailsArticle", "Home", new {slug = @Model.ElementAt(1).ArticleTitle.Replace(" ","-"), id = @Model.ElementAt(1).Id }), 2428, 131, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"color_fff\">\r\n                                            <i class=\"fa fa-clock-o\"></i>&nbsp;&nbsp; ");
#nullable restore
#line 37 "C:\Users\Hieu Hieu\Documents\Zalo Received Files\BlogWebsite\BlogWebsite\BlogWebsite\Views\Shared\Components\BreakingNews\Default.cshtml"
                                                                                 Write(Model.ElementAt(1).ArticleDate.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </a>\r\n                                    </div>\r\n                                    <div");
            BeginWriteAttribute("class", " class=\"", 2853, "\"", 2861, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 2907, "\"", 3045, 1);
#nullable restore
#line 41 "C:\Users\Hieu Hieu\Documents\Zalo Received Files\BlogWebsite\BlogWebsite\BlogWebsite\Views\Shared\Components\BreakingNews\Default.cshtml"
WriteAttributeValue("", 2914, Url.Action("DetailsArticle", "Home", new {slug = @Model.ElementAt(1).ArticleTitle.Replace(" ","-"), id = @Model.ElementAt(1).Id }), 2914, 131, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"fh5co_good_font\">\r\n                                            ");
#nullable restore
#line 42 "C:\Users\Hieu Hieu\Documents\Zalo Received Files\BlogWebsite\BlogWebsite\BlogWebsite\Views\Shared\Components\BreakingNews\Default.cshtml"
                                       Write(Model.ElementAt(1).ArticleTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                        </a>
                                    </div>
                                </div>
                            </a>
                        </div>
                    </div>
                    <div class=""col-md-12 col-6 paddding animate-box"" data-animate-effect=""fadeIn"">
                        <div class=""fh5co_suceefh5co_height_2"">
                            <a");
            BeginWriteAttribute("href", " href=\"", 3571, "\"", 3709, 1);
#nullable restore
#line 51 "C:\Users\Hieu Hieu\Documents\Zalo Received Files\BlogWebsite\BlogWebsite\BlogWebsite\Views\Shared\Components\BreakingNews\Default.cshtml"
WriteAttributeValue("", 3578, Url.Action("DetailsArticle", "Home", new {slug = @Model.ElementAt(2).ArticleTitle.Replace(" ","-"), id = @Model.ElementAt(2).Id }), 3578, 131, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <img");
            BeginWriteAttribute("src", " src=\"", 3749, "\"", 3787, 1);
#nullable restore
#line 52 "C:\Users\Hieu Hieu\Documents\Zalo Received Files\BlogWebsite\BlogWebsite\BlogWebsite\Views\Shared\Components\BreakingNews\Default.cshtml"
WriteAttributeValue("", 3755, Model.ElementAt(2).ArticleThumb, 3755, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"img\" />\r\n                                <div class=\"fh5co_suceefh5co_height_position_absolute\"></div>\r\n                                <div class=\"fh5co_suceefh5co_height_position_absolute_font_2\">\r\n                                    <div");
            BeginWriteAttribute("class", " class=\"", 4034, "\"", 4042, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 4088, "\"", 4226, 1);
#nullable restore
#line 56 "C:\Users\Hieu Hieu\Documents\Zalo Received Files\BlogWebsite\BlogWebsite\BlogWebsite\Views\Shared\Components\BreakingNews\Default.cshtml"
WriteAttributeValue("", 4095, Url.Action("DetailsArticle", "Home", new {slug = @Model.ElementAt(2).ArticleTitle.Replace(" ","-"), id = @Model.ElementAt(2).Id }), 4095, 131, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"color_fff\">\r\n                                            <i class=\"fa fa-clock-o\"></i>&nbsp;&nbsp; ");
#nullable restore
#line 57 "C:\Users\Hieu Hieu\Documents\Zalo Received Files\BlogWebsite\BlogWebsite\BlogWebsite\Views\Shared\Components\BreakingNews\Default.cshtml"
                                                                                 Write(Model.ElementAt(2).ArticleDate.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </a>\r\n                                    </div>\r\n                                    <div");
            BeginWriteAttribute("class", " class=\"", 4520, "\"", 4528, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 4574, "\"", 4712, 1);
#nullable restore
#line 61 "C:\Users\Hieu Hieu\Documents\Zalo Received Files\BlogWebsite\BlogWebsite\BlogWebsite\Views\Shared\Components\BreakingNews\Default.cshtml"
WriteAttributeValue("", 4581, Url.Action("DetailsArticle", "Home", new {slug = @Model.ElementAt(2).ArticleTitle.Replace(" ","-"), id = @Model.ElementAt(2).Id }), 4581, 131, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"fh5co_good_font\">\r\n                                            ");
#nullable restore
#line 62 "C:\Users\Hieu Hieu\Documents\Zalo Received Files\BlogWebsite\BlogWebsite\BlogWebsite\Views\Shared\Components\BreakingNews\Default.cshtml"
                                       Write(Model.ElementAt(2).ArticleTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                        </a>
                                    </div>
                                </div>
                            </a>
                        </div>
                    </div>

                </div>
            </div>
        </div>
    </div>
");
#nullable restore
#line 74 "C:\Users\Hieu Hieu\Documents\Zalo Received Files\BlogWebsite\BlogWebsite\BlogWebsite\Views\Shared\Components\BreakingNews\Default.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Article>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
