#pragma checksum "C:\Users\danny\Desktop\ProyectoFinal\Pages\GestionReserva.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "71c57262269cf4beb9aa58fdb6a1e8f83df21baf"
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
using ProyectoFinal.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\danny\Desktop\ProyectoFinal\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\danny\Desktop\ProyectoFinal\_Imports.razor"
using ProyectoFinal.Theme;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\danny\Desktop\ProyectoFinal\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\danny\Desktop\ProyectoFinal\_Imports.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\danny\Desktop\ProyectoFinal\_Imports.razor"
using ProyectoFinal.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/reserva")]
    public partial class GestionReserva : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "row justify-content-center");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "col-md-8 text-center");
            __builder.AddMarkupContent(4, "<h1 class=\"alert alert-info\">Gestión de Reserva</h1>");
#nullable restore
#line 11 "C:\Users\danny\Desktop\ProyectoFinal\Pages\GestionReserva.razor"
         if(loading == true){

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(5, "<div class=\"spinner-border text-primary\" style=\"width: 7rem; height: 7rem; margin-top:10rem;\" role=\"status\"><span class=\"visually-hidden\"></span></div>");
#nullable restore
#line 15 "C:\Users\danny\Desktop\ProyectoFinal\Pages\GestionReserva.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 19 "C:\Users\danny\Desktop\ProyectoFinal\Pages\GestionReserva.razor"
 if(loading == false){

#line default
#line hidden
#nullable disable
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "row justify-content-center mt-md-2");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "col-7");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(10);
            __builder.AddAttribute(11, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 22 "C:\Users\danny\Desktop\ProyectoFinal\Pages\GestionReserva.razor"
                             oReserva

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 22 "C:\Users\danny\Desktop\ProyectoFinal\Pages\GestionReserva.razor"
                                                      (() => Guardar())

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(13, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(14);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(15, "\r\n                ");
                __builder2.OpenComponent<MudBlazor.MudCard>(16);
                __builder2.AddAttribute(17, "Elevation", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 24 "C:\Users\danny\Desktop\ProyectoFinal\Pages\GestionReserva.razor"
                                    25

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(18, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudCardContent>(19);
                    __builder3.AddAttribute(20, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<MudBlazor.MudGrid>(21);
                        __builder4.AddAttribute(22, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<MudBlazor.MudItem>(23);
                            __builder5.AddAttribute(24, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 27 "C:\Users\danny\Desktop\ProyectoFinal\Pages\GestionReserva.razor"
                                         12

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(25, "sm", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 27 "C:\Users\danny\Desktop\ProyectoFinal\Pages\GestionReserva.razor"
                                                 6

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(26, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __Blazor.ProyectoFinal.Pages.GestionReserva.TypeInference.CreateMudSelect_0(__builder6, 27, 28, "Cliente", 29, 
#nullable restore
#line 28 "C:\Users\danny\Desktop\ProyectoFinal\Pages\GestionReserva.razor"
                                                                                                      Variant.Outlined

#line default
#line hidden
#nullable disable
                                , 30, 
#nullable restore
#line 28 "C:\Users\danny\Desktop\ProyectoFinal\Pages\GestionReserva.razor"
                                                        oReserva.id_cliente

#line default
#line hidden
#nullable disable
                                , 31, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => oReserva.id_cliente = __value, oReserva.id_cliente)), 32, (__builder7) => {
                                    __Blazor.ProyectoFinal.Pages.GestionReserva.TypeInference.CreateMudSelectItem_1(__builder7, 33, 34, 
#nullable restore
#line 29 "C:\Users\danny\Desktop\ProyectoFinal\Pages\GestionReserva.razor"
                                                          0

#line default
#line hidden
#nullable disable
                                    , 35, (__builder8) => {
                                        __builder8.AddContent(36, "Seleccione...");
                                    }
                                    );
#nullable restore
#line 30 "C:\Users\danny\Desktop\ProyectoFinal\Pages\GestionReserva.razor"
                                     if(lsClientes != null){
                                        foreach(var item in lsClientes){

#line default
#line hidden
#nullable disable
                                    __Blazor.ProyectoFinal.Pages.GestionReserva.TypeInference.CreateMudSelectItem_2(__builder7, 37, 38, 
#nullable restore
#line 32 "C:\Users\danny\Desktop\ProyectoFinal\Pages\GestionReserva.razor"
                                                                    item.id

#line default
#line hidden
#nullable disable
                                    , 39, (__builder8) => {
                                        __builder8.AddContent(40, 
#nullable restore
#line 32 "C:\Users\danny\Desktop\ProyectoFinal\Pages\GestionReserva.razor"
                                                                               item.nombre

#line default
#line hidden
#nullable disable
                                        );
                                        __builder8.AddContent(41, " ");
                                        __builder8.AddContent(42, 
#nullable restore
#line 32 "C:\Users\danny\Desktop\ProyectoFinal\Pages\GestionReserva.razor"
                                                                                            item.apellido

#line default
#line hidden
#nullable disable
                                        );
                                    }
                                    );
#nullable restore
#line 33 "C:\Users\danny\Desktop\ProyectoFinal\Pages\GestionReserva.razor"
                                        }
                                    }

#line default
#line hidden
#nullable disable
                                }
                                );
                                __builder6.AddMarkupContent(43, "\r\n                                ");
                                __Blazor.ProyectoFinal.Pages.GestionReserva.TypeInference.CreateValidationMessage_3(__builder6, 44, 45, 
#nullable restore
#line 36 "C:\Users\danny\Desktop\ProyectoFinal\Pages\GestionReserva.razor"
                                                        () => oReserva.id_cliente

#line default
#line hidden
#nullable disable
                                );
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(46, "\r\n                            ");
                            __builder5.OpenComponent<MudBlazor.MudItem>(47);
                            __builder5.AddAttribute(48, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 38 "C:\Users\danny\Desktop\ProyectoFinal\Pages\GestionReserva.razor"
                                         12

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(49, "sm", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 38 "C:\Users\danny\Desktop\ProyectoFinal\Pages\GestionReserva.razor"
                                                 6

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(50, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __Blazor.ProyectoFinal.Pages.GestionReserva.TypeInference.CreateMudSelect_4(__builder6, 51, 52, "Vehículos", 53, 
#nullable restore
#line 39 "C:\Users\danny\Desktop\ProyectoFinal\Pages\GestionReserva.razor"
                                                                                                         Variant.Outlined

#line default
#line hidden
#nullable disable
                                , 54, 
#nullable restore
#line 39 "C:\Users\danny\Desktop\ProyectoFinal\Pages\GestionReserva.razor"
                                                        oReserva.id_vehiculo

#line default
#line hidden
#nullable disable
                                , 55, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => oReserva.id_vehiculo = __value, oReserva.id_vehiculo)), 56, (__builder7) => {
                                    __Blazor.ProyectoFinal.Pages.GestionReserva.TypeInference.CreateMudSelectItem_5(__builder7, 57, 58, 
#nullable restore
#line 40 "C:\Users\danny\Desktop\ProyectoFinal\Pages\GestionReserva.razor"
                                                          0

#line default
#line hidden
#nullable disable
                                    , 59, (__builder8) => {
                                        __builder8.AddContent(60, "Seleccione...");
                                    }
                                    );
#nullable restore
#line 41 "C:\Users\danny\Desktop\ProyectoFinal\Pages\GestionReserva.razor"
                                     if(lsVehiculos != null){
                                        foreach(var item in lsVehiculos){

#line default
#line hidden
#nullable disable
                                    __Blazor.ProyectoFinal.Pages.GestionReserva.TypeInference.CreateMudSelectItem_6(__builder7, 61, 62, 
#nullable restore
#line 43 "C:\Users\danny\Desktop\ProyectoFinal\Pages\GestionReserva.razor"
                                                                    item.id

#line default
#line hidden
#nullable disable
                                    , 63, (__builder8) => {
                                        __builder8.AddContent(64, 
#nullable restore
#line 43 "C:\Users\danny\Desktop\ProyectoFinal\Pages\GestionReserva.razor"
                                                                               item.marca

#line default
#line hidden
#nullable disable
                                        );
                                        __builder8.AddContent(65, " ");
                                        __builder8.AddContent(66, 
#nullable restore
#line 43 "C:\Users\danny\Desktop\ProyectoFinal\Pages\GestionReserva.razor"
                                                                                           item.modelo

#line default
#line hidden
#nullable disable
                                        );
                                    }
                                    );
#nullable restore
#line 44 "C:\Users\danny\Desktop\ProyectoFinal\Pages\GestionReserva.razor"
                                        }
                                    }

#line default
#line hidden
#nullable disable
                                }
                                );
                                __builder6.AddMarkupContent(67, "\r\n                                ");
                                __Blazor.ProyectoFinal.Pages.GestionReserva.TypeInference.CreateValidationMessage_7(__builder6, 68, 69, 
#nullable restore
#line 47 "C:\Users\danny\Desktop\ProyectoFinal\Pages\GestionReserva.razor"
                                                        () => oReserva.id_vehiculo

#line default
#line hidden
#nullable disable
                                );
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(70, "\r\n                            ");
                            __builder5.OpenComponent<MudBlazor.MudItem>(71);
                            __builder5.AddAttribute(72, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 49 "C:\Users\danny\Desktop\ProyectoFinal\Pages\GestionReserva.razor"
                                         12

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(73, "sm", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 49 "C:\Users\danny\Desktop\ProyectoFinal\Pages\GestionReserva.razor"
                                                 6

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(74, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.OpenComponent<MudBlazor.MudDatePicker>(75);
                                __builder6.AddAttribute(76, "PickerVariant", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.PickerVariant>(
#nullable restore
#line 50 "C:\Users\danny\Desktop\ProyectoFinal\Pages\GestionReserva.razor"
                                                              PickerVariant.Dialog

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(77, "Label", "Fecha de Inicio");
                                __builder6.AddAttribute(78, "DateFormat", "dd/MM/yyyy");
                                __builder6.AddAttribute(79, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 50 "C:\Users\danny\Desktop\ProyectoFinal\Pages\GestionReserva.razor"
                                                                                                                                                                              Color.Success

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(80, "Rounded", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 50 "C:\Users\danny\Desktop\ProyectoFinal\Pages\GestionReserva.razor"
                                                                                                                                                                                                      true

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(81, "Date", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.DateTime?>(
#nullable restore
#line 50 "C:\Users\danny\Desktop\ProyectoFinal\Pages\GestionReserva.razor"
                                                                                                                        oReserva.fecha_inicia

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(82, "DateChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.DateTime?>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.DateTime?>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => oReserva.fecha_inicia = __value, oReserva.fecha_inicia))));
                                __builder6.CloseComponent();
                                __builder6.AddMarkupContent(83, "\r\n                                ");
                                __Blazor.ProyectoFinal.Pages.GestionReserva.TypeInference.CreateValidationMessage_8(__builder6, 84, 85, 
#nullable restore
#line 51 "C:\Users\danny\Desktop\ProyectoFinal\Pages\GestionReserva.razor"
                                                        () => oReserva.fecha_inicia

#line default
#line hidden
#nullable disable
                                );
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(86, "\r\n                            ");
                            __builder5.OpenComponent<MudBlazor.MudItem>(87);
                            __builder5.AddAttribute(88, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 53 "C:\Users\danny\Desktop\ProyectoFinal\Pages\GestionReserva.razor"
                                         12

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(89, "sm", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 53 "C:\Users\danny\Desktop\ProyectoFinal\Pages\GestionReserva.razor"
                                                 6

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(90, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.OpenComponent<MudBlazor.MudDatePicker>(91);
                                __builder6.AddAttribute(92, "MinDate", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.DateTime?>(
#nullable restore
#line 54 "C:\Users\danny\Desktop\ProyectoFinal\Pages\GestionReserva.razor"
                                                        DateTime.Now

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(93, "PickerVariant", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.PickerVariant>(
#nullable restore
#line 54 "C:\Users\danny\Desktop\ProyectoFinal\Pages\GestionReserva.razor"
                                                                                     PickerVariant.Dialog

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(94, "Label", "Fecha Final");
                                __builder6.AddAttribute(95, "DateFormat", "dd/MM/yyyy");
                                __builder6.AddAttribute(96, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 54 "C:\Users\danny\Desktop\ProyectoFinal\Pages\GestionReserva.razor"
                                                                                                                                                                                              Color.Success

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(97, "Rounded", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 54 "C:\Users\danny\Desktop\ProyectoFinal\Pages\GestionReserva.razor"
                                                                                                                                                                                                                      true

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(98, "Date", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.DateTime?>(
#nullable restore
#line 54 "C:\Users\danny\Desktop\ProyectoFinal\Pages\GestionReserva.razor"
                                                                                                                                           oReserva.fecha_fin

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(99, "DateChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.DateTime?>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.DateTime?>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => oReserva.fecha_fin = __value, oReserva.fecha_fin))));
                                __builder6.CloseComponent();
                                __builder6.AddMarkupContent(100, "\r\n                                ");
                                __Blazor.ProyectoFinal.Pages.GestionReserva.TypeInference.CreateValidationMessage_9(__builder6, 101, 102, 
#nullable restore
#line 55 "C:\Users\danny\Desktop\ProyectoFinal\Pages\GestionReserva.razor"
                                                        () => oReserva.fecha_fin

#line default
#line hidden
#nullable disable
                                );
                            }
                            ));
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(103, "\r\n                        ");
                    __builder3.AddMarkupContent(104, "<div class=\"row justify-content-center\"><button type=\"submit\" class=\"btn btn-outline-primary col-8 bn-lg mb-4\">Guardar</button></div>");
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 66 "C:\Users\danny\Desktop\ProyectoFinal\Pages\GestionReserva.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 69 "C:\Users\danny\Desktop\ProyectoFinal\Pages\GestionReserva.razor"
      

    ReservasDb oReserva = new ReservasDb();
    List<ClientesDb> lsClientes = new List<ClientesDb>();
    List<VehiculosDb> lsVehiculos = new List<VehiculosDb>();
    public bool loading {get; set;} = false;

    private bool error = false;

    protected override async Task OnInitializedAsync()
    {
        oReserva.fecha_inicia = DateTime.Now;
        oReserva.fecha_fin = DateTime.Now;
        lsClientes = await clientes.GetSelectCliente();
        lsVehiculos =  await vehiculos.GetVehiculos();
    }
    
    private async Task Guardar(){
        loading = true;
        oReserva.estado = 1;

        if(oReserva.id_cliente == 0 || oReserva.id_vehiculo == 0){
            error =  true;
        }

        if(error == false){

            var validarRegistro = await vehiculos.GetSelect(DateTime.Parse(oReserva.fecha_inicia.Value.ToString("MM/dd/yyyy")), oReserva.id_vehiculo);
            var vehiculo = await vehiculos.GetVehiculos(oReserva.id_vehiculo);

            //Para calcular los dias trascurrido
            TimeSpan? diasTrascurrido = oReserva.fecha_fin - oReserva.fecha_inicia;
            var dia = int.Parse(diasTrascurrido.Value.ToString("dd"));

            //Para hacer el calculo del monto
            oReserva.monto = vehiculo.precio * dia;

            if(validarRegistro == null){
                var crear = await reservas.AddReserves(oReserva);
                var rs = js.InvokeAsync<object>("msjAlert", "Registrado Exitoso!", "success");
                NavigationManager.NavigateTo("/listaReservas");
            }else{
                var rs = js.InvokeAsync<object>("msjAlert", "Vehículo No Disponible!", "error");
            }


        }else{
            var rs = js.InvokeAsync<object>("msjAlert", "Campos Vacío!", "error");
            error = false;
            loading = false;
        }


    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IVehiculos vehiculos { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IClientes clientes { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IReservas reservas { get; set; }
    }
}
namespace __Blazor.ProyectoFinal.Pages.GestionReserva
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateMudSelect_0<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::MudBlazor.Variant __arg1, int __seq2, T __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::MudBlazor.MudSelect<T>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "Variant", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateMudSelectItem_1<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, T __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment __arg1)
        {
        __builder.OpenComponent<global::MudBlazor.MudSelectItem<T>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ChildContent", __arg1);
        __builder.CloseComponent();
        }
        public static void CreateMudSelectItem_2<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, T __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment __arg1)
        {
        __builder.OpenComponent<global::MudBlazor.MudSelectItem<T>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ChildContent", __arg1);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateMudSelect_4<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::MudBlazor.Variant __arg1, int __seq2, T __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::MudBlazor.MudSelect<T>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "Variant", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateMudSelectItem_5<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, T __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment __arg1)
        {
        __builder.OpenComponent<global::MudBlazor.MudSelectItem<T>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ChildContent", __arg1);
        __builder.CloseComponent();
        }
        public static void CreateMudSelectItem_6<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, T __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment __arg1)
        {
        __builder.OpenComponent<global::MudBlazor.MudSelectItem<T>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ChildContent", __arg1);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_7<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_8<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_9<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591