#pragma checksum "/home/kazuma/dotnet/code/PracticalApps/NorthwindMvc/Views/Home/ProductsThatCostMoreThan.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cb72a8db33e206bf9522e64d48bfe32566a90d7e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ProductsThatCostMoreThan), @"mvc.1.0.view", @"/Views/Home/ProductsThatCostMoreThan.cshtml")]
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
#line 1 "/home/kazuma/dotnet/code/PracticalApps/NorthwindMvc/Views/_ViewImports.cshtml"
using NorthwindMvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/kazuma/dotnet/code/PracticalApps/NorthwindMvc/Views/_ViewImports.cshtml"
using NorthwindMvc.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb72a8db33e206bf9522e64d48bfe32566a90d7e", @"/Views/Home/ProductsThatCostMoreThan.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c10324db967624bce2cebb2dbfaf1321bdbfb158", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ProductsThatCostMoreThan : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Packt.Shared.Product>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/home/kazuma/dotnet/code/PracticalApps/NorthwindMvc/Views/Home/ProductsThatCostMoreThan.cshtml"
  
    ViewData["Title"] = "Products That Cost More Than " + ViewData["MaxPrice"];

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2>Products That Cost More Than ");
#nullable restore
#line 5 "/home/kazuma/dotnet/code/PracticalApps/NorthwindMvc/Views/Home/ProductsThatCostMoreThan.cshtml"
                            Write(ViewData["MaxPrice"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\n<table class=\"table\">\n    <tr>\n        <th>Category name</th>\n        <th>Supplier\'s Company Name</th>\n        <th>Product Name</th>\n        <th>Unit Price</th>\n        <th>Units in Stock</th>\n    </tr>\n");
#nullable restore
#line 14 "/home/kazuma/dotnet/code/PracticalApps/NorthwindMvc/Views/Home/ProductsThatCostMoreThan.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\n            <td>\n                ");
#nullable restore
#line 18 "/home/kazuma/dotnet/code/PracticalApps/NorthwindMvc/Views/Home/ProductsThatCostMoreThan.cshtml"
           Write(Html.DisplayFor(modelItem => item.Category.CategoryName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 21 "/home/kazuma/dotnet/code/PracticalApps/NorthwindMvc/Views/Home/ProductsThatCostMoreThan.cshtml"
           Write(Html.DisplayFor(modelItem => item.Supplier.CompanyName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 24 "/home/kazuma/dotnet/code/PracticalApps/NorthwindMvc/Views/Home/ProductsThatCostMoreThan.cshtml"
           Write(Html.DisplayFor(modelItem => item.ProductName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 27 "/home/kazuma/dotnet/code/PracticalApps/NorthwindMvc/Views/Home/ProductsThatCostMoreThan.cshtml"
           Write(Html.DisplayFor(modelItem => item.UnitPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 30 "/home/kazuma/dotnet/code/PracticalApps/NorthwindMvc/Views/Home/ProductsThatCostMoreThan.cshtml"
           Write(Html.DisplayFor(modelItem => item.UnitsInStock));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n        </tr>\n");
#nullable restore
#line 33 "/home/kazuma/dotnet/code/PracticalApps/NorthwindMvc/Views/Home/ProductsThatCostMoreThan.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Packt.Shared.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
