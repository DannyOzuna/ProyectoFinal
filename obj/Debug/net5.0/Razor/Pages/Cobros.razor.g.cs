#pragma checksum "C:\Users\Ernest Sanchez\source\repos\ProyectoFinal\Pages\Cobros.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f66f4994904740f088ea990aadbf43409e7ed1e0"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/Cobros")]
    public partial class Cobros : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div class=\"row justify-content-center\"><div class=\"col-md-8 text-center\"><h1 class=\"alert alert-info\">Lista de Para Cobros</h1></div></div>\r\n\r\n\r\n\r\n");
            __Blazor.ProyectoFinal.Pages.Cobros.TypeInference.CreateMudTable_0(__builder, 1, 2, 
#nullable restore
#line 16 "C:\Users\Ernest Sanchez\source\repos\ProyectoFinal\Pages\Cobros.razor"
                  lsReservas

#line default
#line hidden
#nullable disable
            , 3, 
#nullable restore
#line 16 "C:\Users\Ernest Sanchez\source\repos\ProyectoFinal\Pages\Cobros.razor"
                                     true

#line default
#line hidden
#nullable disable
            , 4, 
#nullable restore
#line 16 "C:\Users\Ernest Sanchez\source\repos\ProyectoFinal\Pages\Cobros.razor"
                                                       Breakpoint.Sm

#line default
#line hidden
#nullable disable
            , 5, (__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudTh>(6);
                __builder2.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(8, "Id");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(9, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudTh>(10);
                __builder2.AddAttribute(11, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(12, "Vehiculo");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(13, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudTh>(14);
                __builder2.AddAttribute(15, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(16, "Cliente");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(17, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudTh>(18);
                __builder2.AddAttribute(19, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(20, "Fecha de Alquiler");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(21, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudTh>(22);
                __builder2.AddAttribute(23, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(24, "Fecha de Entrega");
                }
                ));
                __builder2.CloseComponent();
            }
            , 25, (context) => (__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudTd>(26);
                __builder2.AddAttribute(27, "DataLabel", "Id");
                __builder2.AddAttribute(28, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(29, 
#nullable restore
#line 25 "C:\Users\Ernest Sanchez\source\repos\ProyectoFinal\Pages\Cobros.razor"
                               context.id

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(30, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudTd>(31);
                __builder2.AddAttribute(32, "DataLabel", "Cliente");
                __builder2.AddAttribute(33, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(34, 
#nullable restore
#line 26 "C:\Users\Ernest Sanchez\source\repos\ProyectoFinal\Pages\Cobros.razor"
                                    context.id_vehiculo

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(35, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudTd>(36);
                __builder2.AddAttribute(37, "DataLabel", "Cédula");
                __builder2.AddAttribute(38, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(39, 
#nullable restore
#line 27 "C:\Users\Ernest Sanchez\source\repos\ProyectoFinal\Pages\Cobros.razor"
                                   context.id_cliente

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(40, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudTd>(41);
                __builder2.AddAttribute(42, "DataLabel", "Tipo Sangre");
                __builder2.AddAttribute(43, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(44, 
#nullable restore
#line 28 "C:\Users\Ernest Sanchez\source\repos\ProyectoFinal\Pages\Cobros.razor"
                                        context.fecha_inicia

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(45, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudTd>(46);
                __builder2.AddAttribute(47, "DataLabel", "Nacionalidad");
                __builder2.AddAttribute(48, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(49, 
#nullable restore
#line 29 "C:\Users\Ernest Sanchez\source\repos\ProyectoFinal\Pages\Cobros.razor"
                                         context.fecha_fin

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(50, "\r\n\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudTd>(51);
                __builder2.AddAttribute(52, "DataLabel", "Acción");
                __builder2.AddAttribute(53, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenElement(54, "button");
                    __builder3.AddAttribute(55, "class", "btn btn-success");
                    __builder3.AddAttribute(56, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 32 "C:\Users\Ernest Sanchez\source\repos\ProyectoFinal\Pages\Cobros.razor"
                                                      (()=>Cobrar(context.id))

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(57, "data-bs-toggle", "modal");
                    __builder3.AddAttribute(58, "data-bs-target", "#divview");
                    __builder3.AddMarkupContent(59, "<i class=\"oi oi-eye\"></i>");
                    __builder3.CloseElement();
                }
                ));
                __builder2.CloseComponent();
            }
            );
        }
        #pragma warning restore 1998
#nullable restore
#line 41 "C:\Users\Ernest Sanchez\source\repos\ProyectoFinal\Pages\Cobros.razor"
       

    List<ReservasDb> lsReservas = new List<ReservasDb>();
    ReservasDb objReservas = new ReservasDb();

    protected async override Task OnInitializedAsync()
    {
        lsReservas = await reservas.GetReservesActivos();
    }




    public async Task Cobrar(int id)
    {
        var actualizar = await reservas.Actualizar(objReservas, id);
        if (actualizar == null)
        {
            await js.InvokeAsync<object>("msjAlert", "Cobrado Correctamente", "success");
            NavigationManager.NavigateTo("/Cobros");

        }

        //var msj = await js.InvokeAsync<object>("msjAlert", "No se puede Cobrar!   ", "error");
        await js.InvokeAsync<object>("msjAlert", "Cobrado Correctamente", "success");
        NavigationManager.NavigateTo("/Obtener");

    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IReservas reservas { get; set; }
    }
}
namespace __Blazor.ProyectoFinal.Pages.Cobros
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateMudTable_0<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<T> __arg0, int __seq1, global::System.Boolean __arg1, int __seq2, global::MudBlazor.Breakpoint __arg2, int __seq3, global::Microsoft.AspNetCore.Components.RenderFragment __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment<T> __arg4)
        {
        __builder.OpenComponent<global::MudBlazor.MudTable<T>>(seq);
        __builder.AddAttribute(__seq0, "Items", __arg0);
        __builder.AddAttribute(__seq1, "Hover", __arg1);
        __builder.AddAttribute(__seq2, "Breakpoint", __arg2);
        __builder.AddAttribute(__seq3, "HeaderContent", __arg3);
        __builder.AddAttribute(__seq4, "RowTemplate", __arg4);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
