#pragma checksum "/Users/dannyozuna/Documents/ProyectoFinal/Pages/VistaVehiculos.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4b9cd07e126a0e80f5ab1095243082be8a6eb8d7"
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
#line 1 "/Users/dannyozuna/Documents/ProyectoFinal/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/dannyozuna/Documents/ProyectoFinal/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/dannyozuna/Documents/ProyectoFinal/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/dannyozuna/Documents/ProyectoFinal/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/dannyozuna/Documents/ProyectoFinal/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/dannyozuna/Documents/ProyectoFinal/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/dannyozuna/Documents/ProyectoFinal/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/dannyozuna/Documents/ProyectoFinal/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/dannyozuna/Documents/ProyectoFinal/_Imports.razor"
using ProyectoFinal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/dannyozuna/Documents/ProyectoFinal/_Imports.razor"
using ProyectoFinal.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/Users/dannyozuna/Documents/ProyectoFinal/_Imports.razor"
using ProyectoFinal.Data.Repositorio;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "/Users/dannyozuna/Documents/ProyectoFinal/_Imports.razor"
using ProyectoFinal.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "/Users/dannyozuna/Documents/ProyectoFinal/_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "/Users/dannyozuna/Documents/ProyectoFinal/_Imports.razor"
using ProyectoFinal.Theme;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/vistavehiculos")]
    public partial class VistaVehiculos : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div class=\"row justify-content-center\"><div class=\"col-md-8 text-center\"><h1 class=\"alert alert-info\">Vista de Vehículos</h1></div></div>\n\n\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "row");
#nullable restore
#line 13 "/Users/dannyozuna/Documents/ProyectoFinal/Pages/VistaVehiculos.razor"
   if(lsVehiculos != null){
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "/Users/dannyozuna/Documents/ProyectoFinal/Pages/VistaVehiculos.razor"
     foreach (var item in lsVehiculos)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "col-12 col-sm-2 col-md-3");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "card shadow p-3 mb-5 bg-body rounded");
            __builder.AddAttribute(7, "style", "width: 18rem;");
            __builder.AddMarkupContent(8, "<img src=\"https://www.motor.com.co/files/article_multimedia/uploads/2018/07/19/5b50eafc9e808.jpeg\" class=\"card-img-top\" alt=\"...\">\n          ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "card-body");
            __builder.OpenElement(11, "h3");
            __builder.AddAttribute(12, "class", "card-title text-center");
            __builder.AddContent(13, 
#nullable restore
#line 20 "/Users/dannyozuna/Documents/ProyectoFinal/Pages/VistaVehiculos.razor"
                                                item.marca

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(14, " ");
            __builder.AddContent(15, 
#nullable restore
#line 20 "/Users/dannyozuna/Documents/ProyectoFinal/Pages/VistaVehiculos.razor"
                                                            item.modelo

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\n            ");
            __builder.OpenElement(17, "p");
            __builder.AddAttribute(18, "class", "card-text");
            __builder.OpenElement(19, "table");
            __builder.AddAttribute(20, "class", "table tablePer");
            __builder.OpenElement(21, "tbody");
            __builder.OpenElement(22, "tr");
            __builder.AddMarkupContent(23, "<th>Año:</th>\n                    ");
            __builder.OpenElement(24, "td");
            __builder.AddContent(25, 
#nullable restore
#line 26 "/Users/dannyozuna/Documents/ProyectoFinal/Pages/VistaVehiculos.razor"
                         item.anio

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\n                  ");
            __builder.OpenElement(27, "tr");
            __builder.AddMarkupContent(28, "<th>Matricula:</th>\n                    ");
            __builder.OpenElement(29, "td");
            __builder.AddContent(30, 
#nullable restore
#line 30 "/Users/dannyozuna/Documents/ProyectoFinal/Pages/VistaVehiculos.razor"
                         item.matricula

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\n              ");
            __builder.OpenElement(32, "h5");
            __builder.AddAttribute(33, "class", "text-center");
            __builder.AddAttribute(34, "style", "font-weight: bold;");
            __builder.AddContent(35, "DOP $");
            __builder.AddContent(36, 
#nullable restore
#line 34 "/Users/dannyozuna/Documents/ProyectoFinal/Pages/VistaVehiculos.razor"
                                                                       item.precio

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\n              ");
            __builder.OpenElement(38, "div");
            __builder.AddAttribute(39, "class", "text-center");
            __builder.AddMarkupContent(40, "<a href=\"#\" class=\"btn btn-success\"><i class=\"oi oi-eye\"></i></a>\n                ");
            __builder.OpenElement(41, "a");
            __builder.AddAttribute(42, "href", "/registrarvehiculo/editarvehiculo/" + (
#nullable restore
#line 38 "/Users/dannyozuna/Documents/ProyectoFinal/Pages/VistaVehiculos.razor"
                                                            item.id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(43, "class", "btn btn-primary");
            __builder.AddMarkupContent(44, "<i class=\"oi oi-pencil\"></i>");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\n                ");
            __builder.OpenElement(46, "button");
            __builder.AddAttribute(47, "class", "btn btn-danger");
            __builder.AddAttribute(48, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 39 "/Users/dannyozuna/Documents/ProyectoFinal/Pages/VistaVehiculos.razor"
                                                         (() => Delete(item.id))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(49, "<i class=\"oi oi-trash\"></i>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 44 "/Users/dannyozuna/Documents/ProyectoFinal/Pages/VistaVehiculos.razor"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "/Users/dannyozuna/Documents/ProyectoFinal/Pages/VistaVehiculos.razor"
     
  }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\n\n\n");
            __builder.AddMarkupContent(51, "<button type=\"button\" class=\"btn btn-primary\" data-bs-toggle=\"modal\" data-bs-target=\"#exampleModal\">\n  Launch demo modal\n</button>\n\n\n");
            __builder.AddMarkupContent(52, @"<div class=""modal fade"" id=""exampleModal"" tabindex=""-1"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true""><div class=""modal-dialog modal-dialog-centered modal-dialog-scrollable""><div class=""modal-content""><div class=""modal-header""><h5 class=""modal-title"" id=""exampleModalLabel"">Modal title</h5>
        <button type=""button"" class=""btn-close"" data-bs-dismiss=""modal"" aria-label=""Close""></button></div>
      <div class=""modal-body"">
        ...
      </div>
      <div class=""modal-footer""><button type=""button"" class=""btn btn-secondary"" data-bs-dismiss=""modal"">Close</button>
        <button type=""button"" class=""btn btn-primary"">Save changes</button></div></div></div></div>");
        }
        #pragma warning restore 1998
#nullable restore
#line 72 "/Users/dannyozuna/Documents/ProyectoFinal/Pages/VistaVehiculos.razor"
      

  List<VehiculosDb> lsVehiculos = new List<VehiculosDb>();

  protected async override Task OnInitializedAsync()
  {
      lsVehiculos = await Vehiculos.GetVehiculos();
  }

  public async Task Delete(int id){
    var confimacion = await js.InvokeAsync<bool>("msjConfim", "Confimar", "Seguro de borrar el Vehículo?", "question");
    if(confimacion){
      await Vehiculos.DeleteVehiculo(id);
      await js.InvokeAsync<object>("msjAlert", "Eliminación Exitosa", "success");
      lsVehiculos = await Vehiculos.GetVehiculos();
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
