#pragma checksum "C:\Users\Ernest Sanchez\source\repos\ProyectoFinal\Pages\ObtenerDatos.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "869194f9ac86c1a301a1106a5bb7b59bb5dbba76"
// <auto-generated/>
#pragma warning disable 1591
namespace ProyectoFinal.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Ernest Sanchez\source\repos\ProyectoFinal\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ernest Sanchez\source\repos\ProyectoFinal\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Ernest Sanchez\source\repos\ProyectoFinal\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Ernest Sanchez\source\repos\ProyectoFinal\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Ernest Sanchez\source\repos\ProyectoFinal\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Ernest Sanchez\source\repos\ProyectoFinal\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Ernest Sanchez\source\repos\ProyectoFinal\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Ernest Sanchez\source\repos\ProyectoFinal\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Ernest Sanchez\source\repos\ProyectoFinal\_Imports.razor"
using ProyectoFinal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Ernest Sanchez\source\repos\ProyectoFinal\_Imports.razor"
using ProyectoFinal.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Ernest Sanchez\source\repos\ProyectoFinal\_Imports.razor"
using ProyectoFinal.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Ernest Sanchez\source\repos\ProyectoFinal\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Ernest Sanchez\source\repos\ProyectoFinal\_Imports.razor"
using ProyectoFinal.Theme;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Ernest Sanchez\source\repos\ProyectoFinal\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Ernest Sanchez\source\repos\ProyectoFinal\_Imports.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Ernest Sanchez\source\repos\ProyectoFinal\_Imports.razor"
using ProyectoFinal.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/ObtenerDatos")]
    public partial class ObtenerDatos : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "row justify-content-center mt-md-2");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "col-12 col-sm-4 col-md-8");
            __builder.OpenComponent<MudBlazor.MudCard>(4);
            __builder.AddAttribute(5, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudCardContent>(6);
                __builder2.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudGrid>(8);
                    __builder3.AddAttribute(9, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<MudBlazor.MudItem>(10);
                        __builder4.AddAttribute(11, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 8 "C:\Users\Ernest Sanchez\source\repos\ProyectoFinal\Pages\ObtenerDatos.razor"
                                 12

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(12, "md", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 8 "C:\Users\Ernest Sanchez\source\repos\ProyectoFinal\Pages\ObtenerDatos.razor"
                                         6

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(13, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __Blazor.ProyectoFinal.Pages.ObtenerDatos.TypeInference.CreateMudTextField_0(__builder5, 14, 15, "First Name", 16, 
#nullable restore
#line 9 "C:\Users\Ernest Sanchez\source\repos\ProyectoFinal\Pages\ObtenerDatos.razor"
                                                                                          Variant.Outlined

#line default
#line hidden
#nullable disable
                            , 17, 
#nullable restore
#line 9 "C:\Users\Ernest Sanchez\source\repos\ProyectoFinal\Pages\ObtenerDatos.razor"
                                                   FirstName

#line default
#line hidden
#nullable disable
                            , 18, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => FirstName = __value, FirstName)));
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 17 "C:\Users\Ernest Sanchez\source\repos\ProyectoFinal\Pages\ObtenerDatos.razor"
      
    public string FirstName {get; set;}

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.ProyectoFinal.Pages.ObtenerDatos
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateMudTextField_0<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::MudBlazor.Variant __arg1, int __seq2, T __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg3)
        {
        __builder.OpenComponent<global::MudBlazor.MudTextField<T>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "Variant", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
