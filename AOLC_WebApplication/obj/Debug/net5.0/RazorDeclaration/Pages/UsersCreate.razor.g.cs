// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
        }
        #pragma warning restore 1998
#nullable restore
#line 76 "C:\Users\DeltasLephalalaAOLCD\Documents\GitHub\deltasLephalala\AOLC_WebApplication\Pages\UsersCreate.razor"
       
    AolcUser obj = new AolcUser();
    protected async void CreateUser()
    {
        await aolcUserService.CreateUserAsync(obj);
        NavigationManager.NavigateTo("AolcUser");
    }
    void Cancel()
    {
        NavigationManager.NavigateTo("AolcUser");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AolcUserService aolcUserService { get; set; }
    }
}
#pragma warning restore 1591
