// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 4 "C:\Users\abdul\RiderProjects\SimpleBookingSystem\SimpleBookingSystemBlazor\Pages\Booking.razor"
using SimpleBookingSystemBlazor.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\abdul\RiderProjects\SimpleBookingSystem\SimpleBookingSystemBlazor\Pages\Booking.razor"
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Booking/{Id:int}")]
    public partial class Booking : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 50 "C:\Users\abdul\RiderProjects\SimpleBookingSystem\SimpleBookingSystemBlazor\Pages\Booking.razor"
       

    [Parameter]
    public int Id { get; set; }

    private string errorMessage;

    private Model.Booking _booking = new Model.Booking();

    protected override async Task OnInitializedAsync()
    {
        errorMessage = "";
    }


    private async Task book()
    {
        try
        {
            if (Datevalidation())
            {
                await _bookingData.Book(_booking, Id);
                await ProtectedSessionStore.SetAsync("id", Id);
                NavigationManager.NavigateTo("/Success");
            }
        }
        catch (Exception e)
        {
            errorMessage = e.Message;
        }
    }

    public bool Datevalidation()
    {
        if (_booking.DateFrom > _booking.DateTo)
        {
            errorMessage = "Your bookingStartDate can not me later than bookingEndDate";
            return false;
        }

        return true;
    }
    
    void OnChange(DateTime? value, string name, string format)
    {
        Console.WriteLine($"{name} value changed to {value?.ToString(format)}");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ProtectedSessionStorage ProtectedSessionStore { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IBookingData _bookingData { get; set; }
    }
}
#pragma warning restore 1591
