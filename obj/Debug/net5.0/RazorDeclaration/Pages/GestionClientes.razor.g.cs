// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#nullable restore
#line 15 "/Users/dannyozuna/Documents/ProyectoFinal/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/registrarcliente")]
    public partial class GestionClientes : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 104 "/Users/dannyozuna/Documents/ProyectoFinal/Pages/GestionClientes.razor"
      

    
    ClientesDb oCliente = new ClientesDb();
    DatosCedula oCedula = null;

    public bool cargarDatos {get; set;} = false;
    public bool loading {get; set;} = false;
    public string cedula {get; set;}

    private async Task buscarDatos(int buscar){
        if(buscar == 1){
            if(cedula != null){
                loading = true;
                var Url = "https://api.adamix.net/apec/cedula/" + cedula;
                oCedula = await Http.GetFromJsonAsync<DatosCedula>(Url);

                if(oCedula.ok){
                    cargarDatos = true;
                    oCliente.nombre = oCedula.Nombres;
                    oCliente.apellido = oCedula.Apellido1 + " " + oCedula.Apellido1;
                    oCliente.cedula = oCedula.Cedula;

                }else{
                    var msj =  await Js.InvokeAsync<object>("msjAlert", "Cédula no Encotrada", "error");
                    cargarDatos = true;
                }
                loading = false;
            }else{
                var msj =  await Js.InvokeAsync<object>("msjAlert", "Campo Cédula Vacío", "error");
            }
        }else{
           cargarDatos = true; 
        }
        
    } 

    private void GuardarDatos(){
        cargarDatos = false;
        loading = true;

        oCliente.foto_persona = "url";
        oCliente.foto_licencia = "url";
        oCliente.estado = 1;

        var crear = clientes.AddCliente(oCliente);
        var msj = Js.InvokeAsync<object>("msjAlert", "Registro Existo", "success");
        NavigationManager.NavigateTo("/");

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IClientes clientes { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime Js { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
