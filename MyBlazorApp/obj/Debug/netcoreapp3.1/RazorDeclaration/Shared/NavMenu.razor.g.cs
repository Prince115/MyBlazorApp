#pragma checksum "C:\Prince\MyBlazorApp\MyBlazorApp\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8632bf1766568ffd3ff675916c9ad14228e3eba6"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace MyBlazorApp.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Prince\MyBlazorApp\MyBlazorApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Prince\MyBlazorApp\MyBlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Prince\MyBlazorApp\MyBlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Prince\MyBlazorApp\MyBlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Prince\MyBlazorApp\MyBlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Prince\MyBlazorApp\MyBlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Prince\MyBlazorApp\MyBlazorApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Prince\MyBlazorApp\MyBlazorApp\_Imports.razor"
using MyBlazorApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Prince\MyBlazorApp\MyBlazorApp\_Imports.razor"
using MyBlazorApp.Shared;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 28 "C:\Prince\MyBlazorApp\MyBlazorApp\Shared\NavMenu.razor"
       
    private bool collapseNavMenu = true;

    private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
