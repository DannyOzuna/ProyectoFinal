#pragma checksum "C:\Users\danny\Desktop\ProyectoFinal\Pages\VistaVehiculos.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c45d25102ea00ce06b8a918e82cb9785f3cde2cf"
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
#line 1 "C:\Users\danny\Desktop\ProyectoFinal\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\danny\Desktop\ProyectoFinal\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\danny\Desktop\ProyectoFinal\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\danny\Desktop\ProyectoFinal\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\danny\Desktop\ProyectoFinal\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\danny\Desktop\ProyectoFinal\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\danny\Desktop\ProyectoFinal\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\danny\Desktop\ProyectoFinal\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\danny\Desktop\ProyectoFinal\_Imports.razor"
using ProyectoFinal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\danny\Desktop\ProyectoFinal\_Imports.razor"
using ProyectoFinal.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\danny\Desktop\ProyectoFinal\_Imports.razor"
using ProyectoFinal.Data.Repositorio;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\danny\Desktop\ProyectoFinal\_Imports.razor"
using ProyectoFinal.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\danny\Desktop\ProyectoFinal\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\danny\Desktop\ProyectoFinal\_Imports.razor"
using ProyectoFinal.Theme;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\danny\Desktop\ProyectoFinal\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\danny\Desktop\ProyectoFinal\_Imports.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\danny\Desktop\ProyectoFinal\_Imports.razor"
using ProyectoFinal.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/vistavehiculos")]
    public partial class VistaVehiculos : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "row justify-content-center");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "col-md-8 text-center");
            __builder.AddMarkupContent(4, "<h1 class=\"alert alert-info\">Vista de Vehículos</h1>");
#nullable restore
#line 8 "C:\Users\danny\Desktop\ProyectoFinal\Pages\VistaVehiculos.razor"
         if(loading == true){

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(5, "<div class=\"spinner-border text-primary\" style=\"width: 7rem; height: 7rem; margin-top:10rem;\" role=\"status\"><span class=\"visually-hidden\"></span></div>");
#nullable restore
#line 12 "C:\Users\danny\Desktop\ProyectoFinal\Pages\VistaVehiculos.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 16 "C:\Users\danny\Desktop\ProyectoFinal\Pages\VistaVehiculos.razor"
 if(loading == false){

#line default
#line hidden
#nullable disable
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "row");
#nullable restore
#line 18 "C:\Users\danny\Desktop\ProyectoFinal\Pages\VistaVehiculos.razor"
     if(lsVehiculos != null){
      

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\danny\Desktop\ProyectoFinal\Pages\VistaVehiculos.razor"
       foreach (var item in lsVehiculos)
      { 

#line default
#line hidden
#nullable disable
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "col-12 col-sm-2");
            __builder.OpenComponent<MudBlazor.MudCard>(10);
            __builder.AddAttribute(11, "Elevation", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 22 "C:\Users\danny\Desktop\ProyectoFinal\Pages\VistaVehiculos.razor"
                              25

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudCardContent>(13);
                __builder2.AddAttribute(14, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudGrid>(15);
                    __builder3.AddAttribute(16, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
#nullable restore
#line 25 "C:\Users\danny\Desktop\ProyectoFinal\Pages\VistaVehiculos.razor"
                 if(item.estado == 1){

#line default
#line hidden
#nullable disable
                        __builder4.OpenComponent<MudBlazor.MudChip>(17);
                        __builder4.AddAttribute(18, "Label", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 26 "C:\Users\danny\Desktop\ProyectoFinal\Pages\VistaVehiculos.razor"
                                  true

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(19, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 26 "C:\Users\danny\Desktop\ProyectoFinal\Pages\VistaVehiculos.razor"
                                               Color.Success

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(20, "Size", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Size>(
#nullable restore
#line 26 "C:\Users\danny\Desktop\ProyectoFinal\Pages\VistaVehiculos.razor"
                                                                    Size.Medium

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(21, "Class", "mr-auto mud-elevation-25");
                        __builder4.AddAttribute(22, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(23, "Disponible");
                        }
                        ));
                        __builder4.CloseComponent();
#nullable restore
#line 27 "C:\Users\danny\Desktop\ProyectoFinal\Pages\VistaVehiculos.razor"
                }else{

#line default
#line hidden
#nullable disable
                        __builder4.OpenComponent<MudBlazor.MudChip>(24);
                        __builder4.AddAttribute(25, "Label", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 28 "C:\Users\danny\Desktop\ProyectoFinal\Pages\VistaVehiculos.razor"
                                  true

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(26, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 28 "C:\Users\danny\Desktop\ProyectoFinal\Pages\VistaVehiculos.razor"
                                               Color.Error

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(27, "Size", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Size>(
#nullable restore
#line 28 "C:\Users\danny\Desktop\ProyectoFinal\Pages\VistaVehiculos.razor"
                                                                  Size.Medium

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(28, "Class", "mr-auto mud-elevation-25");
                        __builder4.AddAttribute(29, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(30, "No Disponible");
                        }
                        ));
                        __builder4.CloseComponent();
#nullable restore
#line 29 "C:\Users\danny\Desktop\ProyectoFinal\Pages\VistaVehiculos.razor"
                }

#line default
#line hidden
#nullable disable
                        __builder4.AddMarkupContent(31, "<img src=\"img/Honda2017.jpeg\" class=\"card-img-top\" alt=\"...\">\r\n                ");
                        __builder4.OpenElement(32, "div");
                        __builder4.AddAttribute(33, "class", "card-body");
                        __builder4.OpenElement(34, "h3");
                        __builder4.AddAttribute(35, "class", "card-title text-center");
                        __builder4.AddContent(36, 
#nullable restore
#line 32 "C:\Users\danny\Desktop\ProyectoFinal\Pages\VistaVehiculos.razor"
                                                      item.marca

#line default
#line hidden
#nullable disable
                        );
                        __builder4.AddContent(37, " ");
                        __builder4.AddContent(38, 
#nullable restore
#line 32 "C:\Users\danny\Desktop\ProyectoFinal\Pages\VistaVehiculos.razor"
                                                                  item.modelo

#line default
#line hidden
#nullable disable
                        );
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(39, "\r\n                  ");
                        __builder4.OpenElement(40, "p");
                        __builder4.AddAttribute(41, "class", "card-text");
                        __builder4.OpenElement(42, "table");
                        __builder4.AddAttribute(43, "class", "table tablePer");
                        __builder4.OpenElement(44, "tbody");
                        __builder4.OpenElement(45, "tr");
                        __builder4.AddMarkupContent(46, "<th>Año:</th>\r\n                          ");
                        __builder4.OpenElement(47, "td");
                        __builder4.AddContent(48, 
#nullable restore
#line 38 "C:\Users\danny\Desktop\ProyectoFinal\Pages\VistaVehiculos.razor"
                               item.anio

#line default
#line hidden
#nullable disable
                        );
                        __builder4.CloseElement();
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(49, "\r\n                        ");
                        __builder4.OpenElement(50, "tr");
                        __builder4.AddMarkupContent(51, "<th>Matricula:</th>\r\n                          ");
                        __builder4.OpenElement(52, "td");
                        __builder4.AddContent(53, 
#nullable restore
#line 42 "C:\Users\danny\Desktop\ProyectoFinal\Pages\VistaVehiculos.razor"
                               item.matricula

#line default
#line hidden
#nullable disable
                        );
                        __builder4.CloseElement();
                        __builder4.CloseElement();
                        __builder4.CloseElement();
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(54, "\r\n                    ");
                        __builder4.OpenElement(55, "h5");
                        __builder4.AddAttribute(56, "class", "text-center");
                        __builder4.AddAttribute(57, "style", "font-weight: bold;");
                        __builder4.AddContent(58, "DOP $");
                        __builder4.AddContent(59, 
#nullable restore
#line 46 "C:\Users\danny\Desktop\ProyectoFinal\Pages\VistaVehiculos.razor"
                                                                             item.precio

#line default
#line hidden
#nullable disable
                        );
                        __builder4.CloseElement();
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(60, "\r\n                    ");
                        __builder4.OpenElement(61, "div");
                        __builder4.AddAttribute(62, "class", "text-center");
                        __builder4.AddMarkupContent(63, "<button class=\"btn btn-success\" data-bs-toggle=\"modal\" data-bs-target=\"#divview\"><i class=\"oi oi-eye\"></i></button>\r\n                      ");
                        __builder4.OpenElement(64, "a");
                        __builder4.AddAttribute(65, "href", "/registrarvehiculo/editarvehiculo/" + (
#nullable restore
#line 50 "C:\Users\danny\Desktop\ProyectoFinal\Pages\VistaVehiculos.razor"
                                                                  item.id

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(66, "class", "btn btn-primary");
                        __builder4.AddMarkupContent(67, "<i class=\"oi oi-pencil\"></i>");
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(68, "\r\n                      ");
                        __builder4.OpenElement(69, "button");
                        __builder4.AddAttribute(70, "class", "btn btn-danger");
                        __builder4.AddAttribute(71, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 51 "C:\Users\danny\Desktop\ProyectoFinal\Pages\VistaVehiculos.razor"
                                                               (() => Delete(item.id))

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddMarkupContent(72, "<i class=\"oi oi-trash\"></i>");
                        __builder4.CloseElement();
                        __builder4.CloseElement();
                        __builder4.CloseElement();
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
#nullable restore
#line 58 "C:\Users\danny\Desktop\ProyectoFinal\Pages\VistaVehiculos.razor"
      }

#line default
#line hidden
#nullable disable
#nullable restore
#line 58 "C:\Users\danny\Desktop\ProyectoFinal\Pages\VistaVehiculos.razor"
       
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 61 "C:\Users\danny\Desktop\ProyectoFinal\Pages\VistaVehiculos.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(73, @"<div class=""modal fade"" id=""divview"" tabindex=""-1"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true""><div class=""modal-dialog modal-dialog-centered modal-dialog-scrollable""><div class=""modal-content""><div class=""modal-header""><h5 class=""modal-title"" id=""exampleModalLabel"">Detalle del Vehículos</h5>
        <button type=""button"" class=""btn-close"" data-bs-dismiss=""modal"" aria-label=""Close""></button></div>
      <div class=""modal-body"">
        ...
      </div>
      <div class=""modal-footer""><button type=""button"" class=""btn btn-secondary"" data-bs-dismiss=""modal"">Close</button></div></div></div></div>");
        }
        #pragma warning restore 1998
#nullable restore
#line 82 "C:\Users\danny\Desktop\ProyectoFinal\Pages\VistaVehiculos.razor"
      
  public bool loading {get; set;} = true;
  List<VehiculosDb> lsVehiculos = new List<VehiculosDb>();

  protected async override Task OnInitializedAsync()
  {
      lsVehiculos = await Vehiculos.GetVehiculos();
      loading = false;
  }

  public async Task Delete(int id){
    var confimacion = await js.InvokeAsync<bool>("msjConfim", "Confimar", "Seguro de borrar el Vehículo?", "question");
    if(confimacion){
      loading = true;
      await Vehiculos.DeleteVehiculo(id);
      await js.InvokeAsync<object>("msjAlert", "Eliminación Exitosa", "success");
      lsVehiculos = await Vehiculos.GetVehiculos();
      loading = false;
    }
  }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IVehiculos Vehiculos { get; set; }
    }
}
#pragma warning restore 1591
