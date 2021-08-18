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
#line 1 "C:\Users\DELL\Source\Repos\ProyectoFinal\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\DELL\Source\Repos\ProyectoFinal\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\DELL\Source\Repos\ProyectoFinal\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\DELL\Source\Repos\ProyectoFinal\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\DELL\Source\Repos\ProyectoFinal\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\DELL\Source\Repos\ProyectoFinal\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\DELL\Source\Repos\ProyectoFinal\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\DELL\Source\Repos\ProyectoFinal\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\DELL\Source\Repos\ProyectoFinal\_Imports.razor"
using ProyectoFinal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\DELL\Source\Repos\ProyectoFinal\_Imports.razor"
using ProyectoFinal.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\DELL\Source\Repos\ProyectoFinal\_Imports.razor"
using ProyectoFinal.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\DELL\Source\Repos\ProyectoFinal\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\DELL\Source\Repos\ProyectoFinal\_Imports.razor"
using ProyectoFinal.Theme;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\DELL\Source\Repos\ProyectoFinal\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\DELL\Source\Repos\ProyectoFinal\_Imports.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\DELL\Source\Repos\ProyectoFinal\_Imports.razor"
using ProyectoFinal.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/registrarvehiculo")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/registrarvehiculo/editarvehiculo/{id:int}")]
    public partial class GestionVehiculos : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 100 "C:\Users\DELL\Source\Repos\ProyectoFinal\Pages\GestionVehiculos.razor"
      
    [Parameter]
    public int id {get; set;}

    IFileListEntry file;

    async Task HandleFileSelected(IFileListEntry[] files){
        file = files.FirstOrDefault();

        if(file != null){
            await cargarArchivo.Cargar(file);
        }
    }

    public bool loading {get; set;} = false;

    VehiculosDb oVehiculos = new VehiculosDb();

   protected async override Task OnInitializedAsync()
    {
        var datos = http.GetFromJsonAsync<Localicacion>("http://ip-api.com/json/");
        var ubicacion = datos.Result;
        if(id != 0){
            oVehiculos = await Vehiculos.GetVehiculos(id);
        }else{
            oVehiculos.latitud = ubicacion.lat.ToString();
            oVehiculos.longitud = ubicacion.lon.ToString();
        }
    }

    private async Task GuardarDatos(){
        loading = true;
        oVehiculos.estado = 1;
        oVehiculos.matricula = oVehiculos.matricula.ToUpper();


        if(file != null){
            oVehiculos.foto = @file.Name;
        }

        var crear = await Vehiculos.AddVehiculos(oVehiculos);

        if(crear == null){
            var update = await Vehiculos.UpdateVehiculo(oVehiculos.id, oVehiculos);
            
            if(update == null){
                var rs = js.InvokeAsync<object>("msjAlert", "Registro Existente!", "error");
                loading = false;
                
            }else{
                var rs = js.InvokeAsync<object>("msjAlert", "Modificación Exitosa!", "success");
                NavigationManager.NavigateTo("/vistavehiculos");
            }

        }else{
            var rs = js.InvokeAsync<object>("msjAlert", "Registrado Exitoso!", "success");
            NavigationManager.NavigateTo("/vistavehiculos");
        }
    }

    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICargarArchivo cargarArchivo { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IVehiculos Vehiculos { get; set; }
    }
}
#pragma warning restore 1591
