#pragma checksum "/Users/dannyozuna/Documents/ProyectoFinal/Pages/Mapa.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4d3ee382be8fdf20121cb8281ce9724d95189d2c"
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
using ProyectoFinal.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "/Users/dannyozuna/Documents/ProyectoFinal/_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "/Users/dannyozuna/Documents/ProyectoFinal/_Imports.razor"
using ProyectoFinal.Theme;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "/Users/dannyozuna/Documents/ProyectoFinal/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "/Users/dannyozuna/Documents/ProyectoFinal/_Imports.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "/Users/dannyozuna/Documents/ProyectoFinal/_Imports.razor"
using ProyectoFinal.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/dannyozuna/Documents/ProyectoFinal/Pages/Mapa.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/mapa")]
    public partial class Mapa : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div class=\"row justify-content-center\"><div class=\"col-md-8 text-center\"><h1 class=\"alert alert-info\">Ubicación de los Vehículos</h1></div></div>\n\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "row justify-content-center mt-md-2");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "col-12 col-sm-8 col-md-10");
            __builder.OpenComponent<MudBlazor.MudCard>(5);
            __builder.AddAttribute(6, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudCardContent>(7);
                __builder2.AddAttribute(8, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(9, "<div id=\"Map\" style=\"height: 600px;\"></div>");
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
#line 24 "/Users/dannyozuna/Documents/ProyectoFinal/Pages/Mapa.razor"
      
   List<VehiculosDb> lsVehiculos = new List<VehiculosDb>();
   [JSInvokable]
   public async Task<string> Marcadores(){

 
    lsVehiculos = await Vehiculos.GetVehiculos();
    string json= JsonConvert.SerializeObject(lsVehiculos);
    
     return json;  
   }
   protected async Task mostrar(){

   await JsRuntine.InvokeVoidAsync("accessDOMElement", 
   DotNetObjectReference.Create(this));
  
  }
    
   protected override async Task OnAfterRenderAsync(bool firstRender){
    if(firstRender){
      try{
         await mostrar();
      }
      catch(Exception){
          throw;
      }

     }
   }
 

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IVehiculos Vehiculos { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntine { get; set; }
    }
}
#pragma warning restore 1591
