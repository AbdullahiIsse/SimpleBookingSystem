#pragma checksum "C:\Users\abdul\RiderProjects\SimpleBookingSystem\SimpleBookingSystemBlazor\Pages\Success.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b995dbce081a2b6a9bf9a05da656f773db9e2ce9"
// <auto-generated/>
#pragma warning disable 1591
namespace SimpleBookingSystemBlazor.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\abdul\RiderProjects\SimpleBookingSystem\SimpleBookingSystemBlazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\abdul\RiderProjects\SimpleBookingSystem\SimpleBookingSystemBlazor\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\abdul\RiderProjects\SimpleBookingSystem\SimpleBookingSystemBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\abdul\RiderProjects\SimpleBookingSystem\SimpleBookingSystemBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\abdul\RiderProjects\SimpleBookingSystem\SimpleBookingSystemBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\abdul\RiderProjects\SimpleBookingSystem\SimpleBookingSystemBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\abdul\RiderProjects\SimpleBookingSystem\SimpleBookingSystemBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\abdul\RiderProjects\SimpleBookingSystem\SimpleBookingSystemBlazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\abdul\RiderProjects\SimpleBookingSystem\SimpleBookingSystemBlazor\_Imports.razor"
using SimpleBookingSystemBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\abdul\RiderProjects\SimpleBookingSystem\SimpleBookingSystemBlazor\_Imports.razor"
using SimpleBookingSystemBlazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\abdul\RiderProjects\SimpleBookingSystem\SimpleBookingSystemBlazor\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\abdul\RiderProjects\SimpleBookingSystem\SimpleBookingSystemBlazor\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\abdul\RiderProjects\SimpleBookingSystem\SimpleBookingSystemBlazor\Pages\Success.razor"
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Success")]
    public partial class Success : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "h3");
            __builder.AddContent(1, " You have Succesfully booked the resource with the id = ");
            __builder.AddContent(2, 
#nullable restore
#line 5 "C:\Users\abdul\RiderProjects\SimpleBookingSystem\SimpleBookingSystemBlazor\Pages\Success.razor"
                                                             id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 7 "C:\Users\abdul\RiderProjects\SimpleBookingSystem\SimpleBookingSystemBlazor\Pages\Success.razor"
       

    private long id;

    protected override async Task OnInitializedAsync()
    {
        var protectedBrowserStorageResultId = await ProtectedSessionStore.GetAsync<long>("id");
        id = protectedBrowserStorageResultId.Value;
        Console.WriteLine($"EMAIL SENT TO admin@admin.com FOR CREATED BOOKING WITH ID {id}");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ProtectedSessionStorage ProtectedSessionStore { get; set; }
    }
}
#pragma warning restore 1591