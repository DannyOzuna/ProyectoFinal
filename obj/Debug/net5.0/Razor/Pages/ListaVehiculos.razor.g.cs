#pragma checksum "C:\Users\Ernest Work\Source\Repos\ProyectoFinal\Pages\ListaVehiculos.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "919b1aa0d45aed510b6b80a10465ff35b1600eb8"
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
#line 1 "C:\Users\Ernest Work\Source\Repos\ProyectoFinal\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ernest Work\Source\Repos\ProyectoFinal\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Ernest Work\Source\Repos\ProyectoFinal\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Ernest Work\Source\Repos\ProyectoFinal\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Ernest Work\Source\Repos\ProyectoFinal\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Ernest Work\Source\Repos\ProyectoFinal\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Ernest Work\Source\Repos\ProyectoFinal\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Ernest Work\Source\Repos\ProyectoFinal\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Ernest Work\Source\Repos\ProyectoFinal\_Imports.razor"
using ProyectoFinal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Ernest Work\Source\Repos\ProyectoFinal\_Imports.razor"
using ProyectoFinal.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Ernest Work\Source\Repos\ProyectoFinal\_Imports.razor"
using ProyectoFinal.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Ernest Work\Source\Repos\ProyectoFinal\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Ernest Work\Source\Repos\ProyectoFinal\_Imports.razor"
using ProyectoFinal.Theme;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Ernest Work\Source\Repos\ProyectoFinal\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Ernest Work\Source\Repos\ProyectoFinal\_Imports.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Ernest Work\Source\Repos\ProyectoFinal\_Imports.razor"
using ProyectoFinal.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/listaVehiculos")]
    public partial class ListaVehiculos : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "row justify-content-center");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "col-md-8 text-center");
            __builder.AddMarkupContent(4, "<h1 class=\"alert alert-info\">Lista de Vehículos</h1>");
#nullable restore
#line 7 "C:\Users\Ernest Work\Source\Repos\ProyectoFinal\Pages\ListaVehiculos.razor"
         if (loading == true)
        {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(5, "<div class=\"spinner-border text-primary\" style=\"width: 7rem; height: 7rem; margin-top:10rem;\" role=\"status\"><span class=\"visually-hidden\"></span></div>");
#nullable restore
#line 11 "C:\Users\Ernest Work\Source\Repos\ProyectoFinal\Pages\ListaVehiculos.razor"
      }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n\r\n");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "justify-content-center mt-md-2");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "col-12");
            __builder.OpenComponent<MudBlazor.MudCard>(11);
            __builder.AddAttribute(12, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudCardHeader>(13);
                __builder2.AddAttribute(14, "CardHeaderContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudText>(15);
                    __builder3.AddAttribute(16, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(17, "Filtrar Registros");
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(18, "\r\n            ");
                __builder2.OpenComponent<MudBlazor.MudCardContent>(19);
                __builder2.AddAttribute(20, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudGrid>(21);
                    __builder3.AddAttribute(22, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<MudBlazor.MudItem>(23);
                        __builder4.AddAttribute(24, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 25 "C:\Users\Ernest Work\Source\Repos\ProyectoFinal\Pages\ListaVehiculos.razor"
                                 12

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(25, "sm", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 25 "C:\Users\Ernest Work\Source\Repos\ProyectoFinal\Pages\ListaVehiculos.razor"
                                         6

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(26, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<MudBlazor.MudDatePicker>(27);
                            __builder5.AddAttribute(28, "PickerVariant", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.PickerVariant>(
#nullable restore
#line 26 "C:\Users\Ernest Work\Source\Repos\ProyectoFinal\Pages\ListaVehiculos.razor"
                                                      PickerVariant.Dialog

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(29, "Label", "Fecha de Inicio");
                            __builder5.AddAttribute(30, "DateFormat", "dd/MM/yyyy");
                            __builder5.AddAttribute(31, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 26 "C:\Users\Ernest Work\Source\Repos\ProyectoFinal\Pages\ListaVehiculos.razor"
                                                                                                                                                            Color.Success

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(32, "Rounded", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 26 "C:\Users\Ernest Work\Source\Repos\ProyectoFinal\Pages\ListaVehiculos.razor"
                                                                                                                                                                                    true

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(33, "Date", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.DateTime?>(
#nullable restore
#line 26 "C:\Users\Ernest Work\Source\Repos\ProyectoFinal\Pages\ListaVehiculos.razor"
                                                                                                                fechaInicar

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(34, "DateChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.DateTime?>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.DateTime?>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => fechaInicar = __value, fechaInicar))));
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(35, "\r\n                    ");
                        __builder4.OpenComponent<MudBlazor.MudItem>(36);
                        __builder4.AddAttribute(37, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 28 "C:\Users\Ernest Work\Source\Repos\ProyectoFinal\Pages\ListaVehiculos.razor"
                                 12

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(38, "sm", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 28 "C:\Users\Ernest Work\Source\Repos\ProyectoFinal\Pages\ListaVehiculos.razor"
                                         6

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(39, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<MudBlazor.MudDatePicker>(40);
                            __builder5.AddAttribute(41, "MinDate", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.DateTime?>(
#nullable restore
#line 29 "C:\Users\Ernest Work\Source\Repos\ProyectoFinal\Pages\ListaVehiculos.razor"
                                                DateTime.Now

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(42, "PickerVariant", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.PickerVariant>(
#nullable restore
#line 29 "C:\Users\Ernest Work\Source\Repos\ProyectoFinal\Pages\ListaVehiculos.razor"
                                                                             PickerVariant.Dialog

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(43, "Label", "Fecha Final");
                            __builder5.AddAttribute(44, "DateFormat", "dd/MM/yyyy");
                            __builder5.AddAttribute(45, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 29 "C:\Users\Ernest Work\Source\Repos\ProyectoFinal\Pages\ListaVehiculos.razor"
                                                                                                                                                                              Color.Success

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(46, "Rounded", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 29 "C:\Users\Ernest Work\Source\Repos\ProyectoFinal\Pages\ListaVehiculos.razor"
                                                                                                                                                                                                      true

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(47, "Date", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.DateTime?>(
#nullable restore
#line 29 "C:\Users\Ernest Work\Source\Repos\ProyectoFinal\Pages\ListaVehiculos.razor"
                                                                                                                                   fechafinal

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(48, "DateChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.DateTime?>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.DateTime?>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => fechafinal = __value, fechafinal))));
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(49, "\r\n            ");
                __builder2.OpenComponent<MudBlazor.MudCardActions>(50);
                __builder2.AddAttribute(51, "Class", "pb-4 pl-4");
                __builder2.AddAttribute(52, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudButton>(53);
                    __builder3.AddAttribute(54, "Variant", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Variant>(
#nullable restore
#line 34 "C:\Users\Ernest Work\Source\Repos\ProyectoFinal\Pages\ListaVehiculos.razor"
                                    Variant.Filled

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(55, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 34 "C:\Users\Ernest Work\Source\Repos\ProyectoFinal\Pages\ListaVehiculos.razor"
                                                           Color.Primary

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(56, "Class", "ml-auto");
                    __builder3.AddAttribute(57, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 34 "C:\Users\Ernest Work\Source\Repos\ProyectoFinal\Pages\ListaVehiculos.razor"
                                                                                                      () => buscarDatos()

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(58, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(59, "Buscar");
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
            __builder.AddMarkupContent(60, "\r\n\r\n");
            __builder.OpenElement(61, "div");
            __builder.AddAttribute(62, "class", "row mt-3");
#nullable restore
#line 41 "C:\Users\Ernest Work\Source\Repos\ProyectoFinal\Pages\ListaVehiculos.razor"
     if (lsVehiculos != null)
    {

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "C:\Users\Ernest Work\Source\Repos\ProyectoFinal\Pages\ListaVehiculos.razor"
 foreach (var item in lsVehiculos)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(63, "div");
            __builder.AddAttribute(64, "class", "col-12 col-sm-3");
            __builder.OpenComponent<MudBlazor.MudCard>(65);
            __builder.AddAttribute(66, "Elevation", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 46 "C:\Users\Ernest Work\Source\Repos\ProyectoFinal\Pages\ListaVehiculos.razor"
                        25

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(67, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudCardContent>(68);
                __builder2.AddAttribute(69, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudGrid>(70);
                    __builder3.AddAttribute(71, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenElement(72, "img");
                        __builder4.AddAttribute(73, "src", 
#nullable restore
#line 49 "C:\Users\Ernest Work\Source\Repos\ProyectoFinal\Pages\ListaVehiculos.razor"
                           item.foto

#line default
#line hidden
#nullable disable
                        );
                        __builder4.AddAttribute(74, "class", "card-img-top");
                        __builder4.AddAttribute(75, "alt", "...");
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(76, "\r\n                ");
                        __builder4.OpenElement(77, "div");
                        __builder4.AddAttribute(78, "class", "card-body");
                        __builder4.OpenElement(79, "h3");
                        __builder4.AddAttribute(80, "class", "card-title text-center");
                        __builder4.AddContent(81, 
#nullable restore
#line 51 "C:\Users\Ernest Work\Source\Repos\ProyectoFinal\Pages\ListaVehiculos.razor"
                                                        item.marca

#line default
#line hidden
#nullable disable
                        );
                        __builder4.AddContent(82, " ");
                        __builder4.AddContent(83, 
#nullable restore
#line 51 "C:\Users\Ernest Work\Source\Repos\ProyectoFinal\Pages\ListaVehiculos.razor"
                                                                    item.modelo

#line default
#line hidden
#nullable disable
                        );
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(84, "\r\n                    ");
                        __builder4.OpenElement(85, "p");
                        __builder4.AddAttribute(86, "class", "card-text");
                        __builder4.OpenElement(87, "table");
                        __builder4.AddAttribute(88, "class", "table tablePer");
                        __builder4.OpenElement(89, "tbody");
                        __builder4.OpenElement(90, "tr");
                        __builder4.AddMarkupContent(91, "<th>Fecha de Inicio:</th>\r\n                                    ");
                        __builder4.OpenElement(92, "td");
                        __builder4.AddContent(93, 
#nullable restore
#line 57 "C:\Users\Ernest Work\Source\Repos\ProyectoFinal\Pages\ListaVehiculos.razor"
                                         item.fecha_inicia

#line default
#line hidden
#nullable disable
                        );
                        __builder4.CloseElement();
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(94, "\r\n                                ");
                        __builder4.OpenElement(95, "tr");
                        __builder4.AddMarkupContent(96, "<th>Fecha de Fin:</th>\r\n                                    ");
                        __builder4.OpenElement(97, "td");
                        __builder4.AddContent(98, 
#nullable restore
#line 61 "C:\Users\Ernest Work\Source\Repos\ProyectoFinal\Pages\ListaVehiculos.razor"
                                         item.fecha_fin

#line default
#line hidden
#nullable disable
                        );
                        __builder4.CloseElement();
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(99, "\r\n                                ");
                        __builder4.OpenElement(100, "tr");
                        __builder4.AddMarkupContent(101, "<th>Tipo</th>\r\n                                    ");
                        __builder4.OpenElement(102, "td");
                        __builder4.AddContent(103, 
#nullable restore
#line 65 "C:\Users\Ernest Work\Source\Repos\ProyectoFinal\Pages\ListaVehiculos.razor"
                                         item.tipo

#line default
#line hidden
#nullable disable
                        );
                        __builder4.CloseElement();
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(104, "\r\n                                ");
                        __builder4.OpenElement(105, "tr");
                        __builder4.AddMarkupContent(106, "<th>Marca</th>\r\n                                    ");
                        __builder4.OpenElement(107, "td");
                        __builder4.AddContent(108, 
#nullable restore
#line 69 "C:\Users\Ernest Work\Source\Repos\ProyectoFinal\Pages\ListaVehiculos.razor"
                                         item.marca

#line default
#line hidden
#nullable disable
                        );
                        __builder4.CloseElement();
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(109, "\r\n                                ");
                        __builder4.OpenElement(110, "tr");
                        __builder4.AddMarkupContent(111, "<th>Modelo</th>\r\n                                    ");
                        __builder4.OpenElement(112, "td");
                        __builder4.AddContent(113, 
#nullable restore
#line 73 "C:\Users\Ernest Work\Source\Repos\ProyectoFinal\Pages\ListaVehiculos.razor"
                                         item.modelo

#line default
#line hidden
#nullable disable
                        );
                        __builder4.CloseElement();
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(114, "\r\n                                ");
                        __builder4.OpenElement(115, "tr");
                        __builder4.AddMarkupContent(116, "<th>Color</th>\r\n                                    ");
                        __builder4.OpenElement(117, "td");
                        __builder4.AddContent(118, 
#nullable restore
#line 77 "C:\Users\Ernest Work\Source\Repos\ProyectoFinal\Pages\ListaVehiculos.razor"
                                         item.color

#line default
#line hidden
#nullable disable
                        );
                        __builder4.CloseElement();
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(119, "\r\n                                ");
                        __builder4.OpenElement(120, "tr");
                        __builder4.AddMarkupContent(121, "<th>Año</th>\r\n                                    ");
                        __builder4.OpenElement(122, "td");
                        __builder4.AddContent(123, 
#nullable restore
#line 81 "C:\Users\Ernest Work\Source\Repos\ProyectoFinal\Pages\ListaVehiculos.razor"
                                         item.anio

#line default
#line hidden
#nullable disable
                        );
                        __builder4.CloseElement();
                        __builder4.CloseElement();
                        __builder4.CloseElement();
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
#line 90 "C:\Users\Ernest Work\Source\Repos\ProyectoFinal\Pages\ListaVehiculos.razor"
      }

#line default
#line hidden
#nullable disable
#nullable restore
#line 90 "C:\Users\Ernest Work\Source\Repos\ProyectoFinal\Pages\ListaVehiculos.razor"
       }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 95 "C:\Users\Ernest Work\Source\Repos\ProyectoFinal\Pages\ListaVehiculos.razor"
       private bool loading { get; set; } = false;
            private DateTime? fechaInicar = DateTime.Now;
            private DateTime? fechafinal = DateTime.Now;
            List<JoinVehiculosReserva> lsVehiculos = new List<JoinVehiculosReserva>();

            private async Task buscarDatos()
            {
                lsVehiculos = await vehiculos.getRangoVehiculos(fechaInicar, fechafinal);
            } 

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IVehiculos vehiculos { get; set; }
    }
}
#pragma warning restore 1591
