#pragma checksum "C:\Users\abdul\RiderProjects\SimpleBookingSystem\SimpleBookingSystemBlazor\Pages\Booking.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5fa4e182fba249f3f0852d3e7f8b2a79b72c2c51"
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
            __builder.OpenElement(0, "h3");
            __builder.AddContent(1, "Booking ");
            __builder.AddContent(2, 
#nullable restore
#line 10 "C:\Users\abdul\RiderProjects\SimpleBookingSystem\SimpleBookingSystemBlazor\Pages\Booking.razor"
             Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(3, "\r\n\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(4);
            __builder.AddAttribute(5, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 13 "C:\Users\abdul\RiderProjects\SimpleBookingSystem\SimpleBookingSystemBlazor\Pages\Booking.razor"
                  _booking

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 13 "C:\Users\abdul\RiderProjects\SimpleBookingSystem\SimpleBookingSystemBlazor\Pages\Booking.razor"
                                            book

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(8);
                __builder2.CloseComponent();
                __builder2.AddContent(9, " ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(10);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(11, "\r\n\r\n    ");
                __builder2.OpenElement(12, "div");
                __builder2.AddAttribute(13, "class", "form-group");
                __builder2.OpenComponent<Radzen.Blazor.RadzenCard>(14);
                __builder2.AddAttribute(15, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(16, "<h4 class=\"mb-2\">Datefrom</h4>\r\n            ");
                    __Blazor.SimpleBookingSystemBlazor.Pages.Booking.TypeInference.CreateRadzenDatePicker_0(__builder3, 17, 18, 
#nullable restore
#line 22 "C:\Users\abdul\RiderProjects\SimpleBookingSystem\SimpleBookingSystemBlazor\Pages\Booking.razor"
                                                                        true

#line default
#line hidden
#nullable disable
                    , 19, 
#nullable restore
#line 22 "C:\Users\abdul\RiderProjects\SimpleBookingSystem\SimpleBookingSystemBlazor\Pages\Booking.razor"
                                                                                           true

#line default
#line hidden
#nullable disable
                    , 20, "1.5", 21, "5", 22, "10", 23, Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.DateTime?>(this, 
#nullable restore
#line 22 "C:\Users\abdul\RiderProjects\SimpleBookingSystem\SimpleBookingSystemBlazor\Pages\Booking.razor"
                                                                                                                                                           args => OnChange(args, "DatePicker with time", "MM/dd/yyyy HH:mm")

#line default
#line hidden
#nullable disable
                    ), 24, "MM/dd/yyyy HH:mm", 25, "w-100", 26, 
#nullable restore
#line 22 "C:\Users\abdul\RiderProjects\SimpleBookingSystem\SimpleBookingSystemBlazor\Pages\Booking.razor"
                                           _booking.DateFrom

#line default
#line hidden
#nullable disable
                    , 27, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _booking.DateFrom = __value, _booking.DateFrom)), 28, () => _booking.DateFrom);
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(29, "\r\n\r\n    ");
                __builder2.OpenElement(30, "div");
                __builder2.AddAttribute(31, "class", "form-group");
                __builder2.OpenComponent<Radzen.Blazor.RadzenCard>(32);
                __builder2.AddAttribute(33, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(34, "<h4 class=\"mb-2\">DateTo</h4>\r\n                    ");
                    __Blazor.SimpleBookingSystemBlazor.Pages.Booking.TypeInference.CreateRadzenDatePicker_1(__builder3, 35, 36, 
#nullable restore
#line 31 "C:\Users\abdul\RiderProjects\SimpleBookingSystem\SimpleBookingSystemBlazor\Pages\Booking.razor"
                                                                              true

#line default
#line hidden
#nullable disable
                    , 37, 
#nullable restore
#line 31 "C:\Users\abdul\RiderProjects\SimpleBookingSystem\SimpleBookingSystemBlazor\Pages\Booking.razor"
                                                                                                 true

#line default
#line hidden
#nullable disable
                    , 38, "1.5", 39, "5", 40, "10", 41, Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.DateTime?>(this, 
#nullable restore
#line 31 "C:\Users\abdul\RiderProjects\SimpleBookingSystem\SimpleBookingSystemBlazor\Pages\Booking.razor"
                                                                                                                                                                 args => OnChange(args, "DatePicker with time", "MM/dd/yyyy HH:mm")

#line default
#line hidden
#nullable disable
                    ), 42, "MM/dd/yyyy HH:mm", 43, "w-100", 44, 
#nullable restore
#line 31 "C:\Users\abdul\RiderProjects\SimpleBookingSystem\SimpleBookingSystemBlazor\Pages\Booking.razor"
                                                   _booking.DateTo

#line default
#line hidden
#nullable disable
                    , 45, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _booking.DateTo = __value, _booking.DateTo)), 46, () => _booking.DateTo);
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(47, "\r\n\r\n    ");
                __builder2.OpenElement(48, "div");
                __builder2.AddAttribute(49, "class", "form-group");
                __builder2.AddMarkupContent(50, " Quantity:<br> ");
                __Blazor.SimpleBookingSystemBlazor.Pages.Booking.TypeInference.CreateInputNumber_2(__builder2, 51, 52, "1", 53, 
#nullable restore
#line 36 "C:\Users\abdul\RiderProjects\SimpleBookingSystem\SimpleBookingSystemBlazor\Pages\Booking.razor"
                                                                              _booking.BookedQuantity

#line default
#line hidden
#nullable disable
                , 54, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _booking.BookedQuantity = __value, _booking.BookedQuantity)), 55, () => _booking.BookedQuantity);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(56, "\r\n\r\n\r\n    ");
                __builder2.OpenElement(57, "p");
                __builder2.AddAttribute(58, "class", "actions");
                __builder2.OpenElement(59, "button");
                __builder2.AddAttribute(60, "class", "btn btn-outline-dark");
                __builder2.AddAttribute(61, "type", "submit");
                __builder2.AddAttribute(62, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 40 "C:\Users\abdul\RiderProjects\SimpleBookingSystem\SimpleBookingSystemBlazor\Pages\Booking.razor"
                                                                     book

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(63, "Book");
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(64, "\r\n\r\n\r\n");
            __builder.OpenElement(65, "div");
            __builder.AddAttribute(66, "style", "color:red");
            __builder.AddContent(67, 
#nullable restore
#line 47 "C:\Users\abdul\RiderProjects\SimpleBookingSystem\SimpleBookingSystemBlazor\Pages\Booking.razor"
                        errorMessage

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
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
namespace __Blazor.SimpleBookingSystemBlazor.Pages.Booking
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateRadzenDatePicker_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Boolean __arg0, int __seq1, global::System.Boolean __arg1, int __seq2, global::System.String __arg2, int __seq3, global::System.String __arg3, int __seq4, global::System.String __arg4, int __seq5, global::Microsoft.AspNetCore.Components.EventCallback<global::System.DateTime?> __arg5, int __seq6, global::System.String __arg6, int __seq7, System.Object __arg7, int __seq8, global::System.Object __arg8, int __seq9, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg9, int __seq10, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg10)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenDatePicker<TValue>>(seq);
        __builder.AddAttribute(__seq0, "ShowTime", __arg0);
        __builder.AddAttribute(__seq1, "ShowSeconds", __arg1);
        __builder.AddAttribute(__seq2, "HoursStep", __arg2);
        __builder.AddAttribute(__seq3, "MinutesStep", __arg3);
        __builder.AddAttribute(__seq4, "SecondsStep", __arg4);
        __builder.AddAttribute(__seq5, "Change", __arg5);
        __builder.AddAttribute(__seq6, "DateFormat", __arg6);
        __builder.AddAttribute(__seq7, "Class", __arg7);
        __builder.AddAttribute(__seq8, "Value", __arg8);
        __builder.AddAttribute(__seq9, "ValueChanged", __arg9);
        __builder.AddAttribute(__seq10, "ValueExpression", __arg10);
        __builder.CloseComponent();
        }
        public static void CreateRadzenDatePicker_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Boolean __arg0, int __seq1, global::System.Boolean __arg1, int __seq2, global::System.String __arg2, int __seq3, global::System.String __arg3, int __seq4, global::System.String __arg4, int __seq5, global::Microsoft.AspNetCore.Components.EventCallback<global::System.DateTime?> __arg5, int __seq6, global::System.String __arg6, int __seq7, System.Object __arg7, int __seq8, global::System.Object __arg8, int __seq9, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg9, int __seq10, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg10)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenDatePicker<TValue>>(seq);
        __builder.AddAttribute(__seq0, "ShowTime", __arg0);
        __builder.AddAttribute(__seq1, "ShowSeconds", __arg1);
        __builder.AddAttribute(__seq2, "HoursStep", __arg2);
        __builder.AddAttribute(__seq3, "MinutesStep", __arg3);
        __builder.AddAttribute(__seq4, "SecondsStep", __arg4);
        __builder.AddAttribute(__seq5, "Change", __arg5);
        __builder.AddAttribute(__seq6, "DateFormat", __arg6);
        __builder.AddAttribute(__seq7, "Class", __arg7);
        __builder.AddAttribute(__seq8, "Value", __arg8);
        __builder.AddAttribute(__seq9, "ValueChanged", __arg9);
        __builder.AddAttribute(__seq10, "ValueExpression", __arg10);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "min", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
