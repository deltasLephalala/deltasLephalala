#pragma checksum "C:\Users\DeltasLephalalaAOLCD\Documents\GitHub\deltasLephalala\AOLC_WebApplication\Pages\UsersCreate.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7c9e5bac6fad37d1e1f745d56b2c4adf8b140da6"
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
#line 1 "C:\Users\DeltasLephalalaAOLCD\Documents\GitHub\deltasLephalala\AOLC_WebApplication\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\DeltasLephalalaAOLCD\Documents\GitHub\deltasLephalala\AOLC_WebApplication\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\DeltasLephalalaAOLCD\Documents\GitHub\deltasLephalala\AOLC_WebApplication\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\DeltasLephalalaAOLCD\Documents\GitHub\deltasLephalala\AOLC_WebApplication\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\DeltasLephalalaAOLCD\Documents\GitHub\deltasLephalala\AOLC_WebApplication\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\DeltasLephalalaAOLCD\Documents\GitHub\deltasLephalala\AOLC_WebApplication\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\DeltasLephalalaAOLCD\Documents\GitHub\deltasLephalala\AOLC_WebApplication\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\DeltasLephalalaAOLCD\Documents\GitHub\deltasLephalala\AOLC_WebApplication\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\DeltasLephalalaAOLCD\Documents\GitHub\deltasLephalala\AOLC_WebApplication\_Imports.razor"
using AOLC_WebApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\DeltasLephalalaAOLCD\Documents\GitHub\deltasLephalala\AOLC_WebApplication\_Imports.razor"
using AOLC_WebApplication.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\DeltasLephalalaAOLCD\Documents\GitHub\deltasLephalala\AOLC_WebApplication\Pages\UsersCreate.razor"
using AOLC_WebApplication.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/UsersCreate")]
    public partial class UsersCreate : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h2>Add User</h2>\r\n<hr>\r\n\r\n");
            __builder.OpenElement(1, "form");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "row");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "col-md-8");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "form-group");
            __builder.AddMarkupContent(8, "<label for=\"FirstName\" class=\"control-label\">FirstName</label>\r\n                ");
            __builder.OpenElement(9, "input");
            __builder.AddAttribute(10, "form", "FirstName");
            __builder.AddAttribute(11, "class", "form-control");
            __builder.AddAttribute(12, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 14 "C:\Users\DeltasLephalalaAOLCD\Documents\GitHub\deltasLephalala\AOLC_WebApplication\Pages\UsersCreate.razor"
                                                                     obj.FirstName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => obj.FirstName = __value, obj.FirstName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n            ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "form-group");
            __builder.AddMarkupContent(17, "<label for=\"LastName\" class=\"control-label\">LastName</label>\r\n                ");
            __builder.OpenElement(18, "input");
            __builder.AddAttribute(19, "form", "LastName");
            __builder.AddAttribute(20, "class", "form-control");
            __builder.AddAttribute(21, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 18 "C:\Users\DeltasLephalalaAOLCD\Documents\GitHub\deltasLephalala\AOLC_WebApplication\Pages\UsersCreate.razor"
                                                                    obj.LastName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(22, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => obj.LastName = __value, obj.LastName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n            ");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", "form-group");
            __builder.AddMarkupContent(26, "<label for=\"Designation\" class=\"control-label\">Designation</label>\r\n                ");
            __builder.OpenElement(27, "input");
            __builder.AddAttribute(28, "form", "Designation");
            __builder.AddAttribute(29, "class", "form-control");
            __builder.AddAttribute(30, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 30 "C:\Users\DeltasLephalalaAOLCD\Documents\GitHub\deltasLephalala\AOLC_WebApplication\Pages\UsersCreate.razor"
                                                                       obj.Designation

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(31, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => obj.Designation = __value, obj.Designation));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n            ");
            __builder.OpenElement(33, "div");
            __builder.AddAttribute(34, "class", "form-group");
            __builder.AddMarkupContent(35, "<label for=\"City\" class=\"control-label\">City</label>\r\n                ");
            __builder.OpenElement(36, "input");
            __builder.AddAttribute(37, "form", "City");
            __builder.AddAttribute(38, "class", "form-control");
            __builder.AddAttribute(39, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 34 "C:\Users\DeltasLephalalaAOLCD\Documents\GitHub\deltasLephalala\AOLC_WebApplication\Pages\UsersCreate.razor"
                                                                obj.City

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(40, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => obj.City = __value, obj.City));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n\r\n    ");
            __builder.OpenElement(42, "div");
            __builder.AddAttribute(43, "class", "row");
            __builder.OpenElement(44, "div");
            __builder.AddAttribute(45, "class", "col-md-4");
            __builder.OpenElement(46, "div");
            __builder.AddAttribute(47, "class", "form-group");
            __builder.OpenElement(48, "input");
            __builder.AddAttribute(49, "type", "button");
            __builder.AddAttribute(50, "class", "btn btn-primary");
            __builder.AddAttribute(51, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 43 "C:\Users\DeltasLephalalaAOLCD\Documents\GitHub\deltasLephalala\AOLC_WebApplication\Pages\UsersCreate.razor"
                                                                        CreateUser

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(52, "value", "Save");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n                ");
            __builder.OpenElement(54, "input");
            __builder.AddAttribute(55, "type", "button");
            __builder.AddAttribute(56, "class", "btn btn-primary");
            __builder.AddAttribute(57, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 44 "C:\Users\DeltasLephalalaAOLCD\Documents\GitHub\deltasLephalala\AOLC_WebApplication\Pages\UsersCreate.razor"
                                                                        Cancel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(58, "value", "Cancel");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 50 "C:\Users\DeltasLephalalaAOLCD\Documents\GitHub\deltasLephalala\AOLC_WebApplication\Pages\UsersCreate.razor"
       
    AolcUser obj = new AolcUser();
    protected async void CreateUser()
    {
        await aolcUserService.CreateUserAsync(obj);
        NavigationManager.NavigateTo("AolcUsers");
    }
    void Cancel()
    {
        NavigationManager.NavigateTo("AolcUsers");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AolcUserService aolcUserService { get; set; }
    }
}
#pragma warning restore 1591
