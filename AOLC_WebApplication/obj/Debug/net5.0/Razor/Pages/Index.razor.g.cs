#pragma checksum "C:\Users\KhutsoMabatamelaAOLC\Desktop\deltasLephalala\AOLC_WebApplication\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b9e46fdfeb755c77979ed48af8583b7d5484888f"
// <auto-generated/>
#pragma warning disable 1591
namespace AOLC_WebApplication.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\KhutsoMabatamelaAOLC\Desktop\deltasLephalala\AOLC_WebApplication\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\KhutsoMabatamelaAOLC\Desktop\deltasLephalala\AOLC_WebApplication\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\KhutsoMabatamelaAOLC\Desktop\deltasLephalala\AOLC_WebApplication\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\KhutsoMabatamelaAOLC\Desktop\deltasLephalala\AOLC_WebApplication\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\KhutsoMabatamelaAOLC\Desktop\deltasLephalala\AOLC_WebApplication\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\KhutsoMabatamelaAOLC\Desktop\deltasLephalala\AOLC_WebApplication\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\KhutsoMabatamelaAOLC\Desktop\deltasLephalala\AOLC_WebApplication\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\KhutsoMabatamelaAOLC\Desktop\deltasLephalala\AOLC_WebApplication\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\KhutsoMabatamelaAOLC\Desktop\deltasLephalala\AOLC_WebApplication\_Imports.razor"
using AOLC_WebApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\KhutsoMabatamelaAOLC\Desktop\deltasLephalala\AOLC_WebApplication\_Imports.razor"
using AOLC_WebApplication.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\KhutsoMabatamelaAOLC\Desktop\deltasLephalala\AOLC_WebApplication\Pages\Index.razor"
using AOLC_WebApplication.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container");
            __builder.AddAttribute(2, "mt-5");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "row");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "col-md-3");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "card text-center");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "myDiv text-black");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "row");
            __builder.AddMarkupContent(13, "<div class=\"col\"><i class=\"fa fa-list fa-4x\"></i></div>\r\n                        ");
            __builder.OpenElement(14, "h3");
            __builder.AddAttribute(15, "class", "display-3");
            __builder.AddContent(16, 
#nullable restore
#line 20 "C:\Users\KhutsoMabatamelaAOLC\Desktop\deltasLephalala\AOLC_WebApplication\Pages\Index.razor"
                                               countClient

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n                        ");
            __builder.AddMarkupContent(18, "<div class=\"col\"><img src=\"/images/clients.jpg\" width=\"100\" height=\"100\">\r\n                            <br>\r\n                            <a href=\"AolcUser\" class=\"text-primary\">View Admins <i class=\"fas fa-arrow-circle-right\"></i></a></div>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n\r\n        ");
            __builder.AddMarkupContent(20, @"<div class=""col-md-3""><div class=""card text-center""><div class=""myDiv text-white""><div class=""row""><div class=""col""><i class=""fa fa-list fa-4x""></i></div>
                        <div class=""col""><img src=""/images/clients.jpg"" width=""100"" height=""100"">
                            <br>
                            <a href=""AolcUser"" class=""text-primary"">View Staff <i class=""fas fa-arrow-circle-right""></i></a></div></div></div></div></div>

        ");
            __builder.AddMarkupContent(21, @"<div class=""col-md-3""><div class=""card text-center""><div class=""myDiv text-white""><div class=""row""><div class=""col""><i class=""fa fa-list fa-4x""></i></div>
                        <div class=""col""><img src=""/images/Ticket.png"" width=""100"" height=""100"">
                            <br>
                            <a href=""AolcUser"" class=""text-primary"">View Tickets <i class=""fas fa-arrow-circle-right""></i></a></div></div></div></div></div>

        ");
            __builder.AddMarkupContent(22, @"<div class=""col-md-3""><div class=""card text-center""><div class=""myDiv text-white""><div class=""row""><div class=""col""><i class=""fa fa-list fa-4x""></i></div>
                        <div class=""col""><div class="" display""><img src=""/images/Ticket.png"" width=""100"" height=""100"">
                                <br>
                                <a href=""AolcUser"" class=""text-primary"">View Sales <i class=""fas fa-arrow-circle-right""></i></a></div></div></div></div></div></div>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n<br>\r\n<br>\r\n\r\n");
            __builder.AddMarkupContent(24, @"<div class=""col-md-3""><div class=""card text-center""><table><tr><th>Ticket</th></tr>
            <tr><td>Open Ticket</td>
                <td><progress id=""file"" value=""32"" max=""100""> 32% </progress></td></tr>
            <tr><td>Closed Ticket</td>
                <td><progress id=""file"" value=""12"" max=""100""> 32% </progress></td></tr></table></div></div>");
        }
        #pragma warning restore 1998
#nullable restore
#line 132 "C:\Users\KhutsoMabatamelaAOLC\Desktop\deltasLephalala\AOLC_WebApplication\Pages\Index.razor"
       List<AolcUser> EmpObj;
    int countClient;
    protected override async Task OnInitializedAsync()
    {
        EmpObj = await Task.Run(() => AolcUserService.GetAllUsersAsync());


        foreach (var employee in EmpObj)
        {
            countClient += 1;
            //Console.WriteLine("Amount is {0} and type is {1}", mo.amount, money.type);
        }
    } 

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AolcUserService AolcUserService { get; set; }
    }
}
#pragma warning restore 1591
