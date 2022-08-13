#pragma checksum "C:\Users\HP\Desktop\complete-ecommerce-aspnet-mvc-application-master\eTickets\Views\Orders\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d0da31e75f5c1670541d1ca8baa1fa80fffb4372"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Orders_Index), @"mvc.1.0.view", @"/Views/Orders/Index.cshtml")]
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
#line 1 "C:\Users\HP\Desktop\complete-ecommerce-aspnet-mvc-application-master\eTickets\Views\_ViewImports.cshtml"
using eTickets;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HP\Desktop\complete-ecommerce-aspnet-mvc-application-master\eTickets\Views\_ViewImports.cshtml"
using eTickets.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\HP\Desktop\complete-ecommerce-aspnet-mvc-application-master\eTickets\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d0da31e75f5c1670541d1ca8baa1fa80fffb4372", @"/Views/Orders/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c243f9d56e095733f8a8c9af2259bc8a8cfadd9", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Orders_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Order>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\HP\Desktop\complete-ecommerce-aspnet-mvc-application-master\eTickets\Views\Orders\Index.cshtml"
   
    ViewData["Title"] = "All orders";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-md-8 offset-2"">
        <p>
            <h4>List of all your orders</h4>
        </p>

        <table class=""table"">
            <thead>
                <tr>
                    <th>Order ID</th>
                    <th>Items</th>
                    <th>Total</th>
");
#nullable restore
#line 19 "C:\Users\HP\Desktop\complete-ecommerce-aspnet-mvc-application-master\eTickets\Views\Orders\Index.cshtml"
                     if (User.Identity.IsAuthenticated && User.IsInRole("Admin"))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <th>User</th>\n");
#nullable restore
#line 22 "C:\Users\HP\Desktop\complete-ecommerce-aspnet-mvc-application-master\eTickets\Views\Orders\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tr>\n            </thead>\n            <tbody>\n");
#nullable restore
#line 26 "C:\Users\HP\Desktop\complete-ecommerce-aspnet-mvc-application-master\eTickets\Views\Orders\Index.cshtml"
                 foreach (var order in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\n                    <td class=\"align-middle\">");
#nullable restore
#line 29 "C:\Users\HP\Desktop\complete-ecommerce-aspnet-mvc-application-master\eTickets\Views\Orders\Index.cshtml"
                                        Write(order.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td class=\"align-middle\">\n                        <ul style=\"list-style-type:none\">\n");
#nullable restore
#line 32 "C:\Users\HP\Desktop\complete-ecommerce-aspnet-mvc-application-master\eTickets\Views\Orders\Index.cshtml"
                             foreach (var item in order.OrderItems)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li>\n                                    <div class=\"alert alert-info\" role=\"alert\">\n                                        <span class=\"badge bg-success\">");
#nullable restore
#line 36 "C:\Users\HP\Desktop\complete-ecommerce-aspnet-mvc-application-master\eTickets\Views\Orders\Index.cshtml"
                                                                  Write(item.Amount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> [");
#nullable restore
#line 36 "C:\Users\HP\Desktop\complete-ecommerce-aspnet-mvc-application-master\eTickets\Views\Orders\Index.cshtml"
                                                                                       Write(item.Price.ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("] - ");
#nullable restore
#line 36 "C:\Users\HP\Desktop\complete-ecommerce-aspnet-mvc-application-master\eTickets\Views\Orders\Index.cshtml"
                                                                                                                    Write(item.Movie.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                    </div>\n                                </li>\n");
#nullable restore
#line 39 "C:\Users\HP\Desktop\complete-ecommerce-aspnet-mvc-application-master\eTickets\Views\Orders\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </ul>\n                    </td>\n                    <td class=\"align-middle\">\n                        ");
#nullable restore
#line 43 "C:\Users\HP\Desktop\complete-ecommerce-aspnet-mvc-application-master\eTickets\Views\Orders\Index.cshtml"
                   Write(order.OrderItems.Select(m => m.Movie.Price * m.Amount).Sum().ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </td>\n");
#nullable restore
#line 45 "C:\Users\HP\Desktop\complete-ecommerce-aspnet-mvc-application-master\eTickets\Views\Orders\Index.cshtml"
                     if (User.Identity.IsAuthenticated && User.IsInRole("Admin"))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td class=\"align-middle\"> ");
#nullable restore
#line 47 "C:\Users\HP\Desktop\complete-ecommerce-aspnet-mvc-application-master\eTickets\Views\Orders\Index.cshtml"
                                             Write(order.User.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\n");
#nullable restore
#line 48 "C:\Users\HP\Desktop\complete-ecommerce-aspnet-mvc-application-master\eTickets\Views\Orders\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tr>\n");
#nullable restore
#line 50 "C:\Users\HP\Desktop\complete-ecommerce-aspnet-mvc-application-master\eTickets\Views\Orders\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\n        </table>\n\n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Order>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
