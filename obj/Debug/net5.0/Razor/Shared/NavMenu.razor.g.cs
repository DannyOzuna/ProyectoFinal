#pragma checksum "E:\Sexto cuatrimeste\Programacion 3\Final\ProyectoFinal\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b109760bc86fd92c2bb02f222dd7578c6c9162b1"
// <auto-generated/>
#pragma warning disable 1591
namespace ProyectoFinal.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "E:\Sexto cuatrimeste\Programacion 3\Final\ProyectoFinal\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Sexto cuatrimeste\Programacion 3\Final\ProyectoFinal\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Sexto cuatrimeste\Programacion 3\Final\ProyectoFinal\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\Sexto cuatrimeste\Programacion 3\Final\ProyectoFinal\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\Sexto cuatrimeste\Programacion 3\Final\ProyectoFinal\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\Sexto cuatrimeste\Programacion 3\Final\ProyectoFinal\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\Sexto cuatrimeste\Programacion 3\Final\ProyectoFinal\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\Sexto cuatrimeste\Programacion 3\Final\ProyectoFinal\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\Sexto cuatrimeste\Programacion 3\Final\ProyectoFinal\_Imports.razor"
using ProyectoFinal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\Sexto cuatrimeste\Programacion 3\Final\ProyectoFinal\_Imports.razor"
using ProyectoFinal.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "E:\Sexto cuatrimeste\Programacion 3\Final\ProyectoFinal\_Imports.razor"
using ProyectoFinal.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "E:\Sexto cuatrimeste\Programacion 3\Final\ProyectoFinal\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "E:\Sexto cuatrimeste\Programacion 3\Final\ProyectoFinal\_Imports.razor"
using ProyectoFinal.Theme;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "E:\Sexto cuatrimeste\Programacion 3\Final\ProyectoFinal\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "E:\Sexto cuatrimeste\Programacion 3\Final\ProyectoFinal\_Imports.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "E:\Sexto cuatrimeste\Programacion 3\Final\ProyectoFinal\_Imports.razor"
using ProyectoFinal.Services;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<MudBlazor.MudNavMenu>(0);
            __builder.AddAttribute(1, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudNavLink>(2);
                __builder2.AddAttribute(3, "Href", "");
                __builder2.AddAttribute(4, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 3 "E:\Sexto cuatrimeste\Programacion 3\Final\ProyectoFinal\Shared\NavMenu.razor"
                               NavLinkMatch.All

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(5, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 3 "E:\Sexto cuatrimeste\Programacion 3\Final\ProyectoFinal\Shared\NavMenu.razor"
                                                        Icons.Material.Filled.Home

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(6, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(7, "Inicio");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(8, "\r\n    ");
                __builder2.OpenComponent<MudBlazor.MudNavLink>(9);
                __builder2.AddAttribute(10, "Href", "/registrarvehiculo");
                __builder2.AddAttribute(11, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 4 "E:\Sexto cuatrimeste\Programacion 3\Final\ProyectoFinal\Shared\NavMenu.razor"
                                                 NavLinkMatch.Prefix

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(12, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 4 "E:\Sexto cuatrimeste\Programacion 3\Final\ProyectoFinal\Shared\NavMenu.razor"
                                                                             Icons.Material.Filled.DirectionsCar

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(13, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(14, "Gestión de Vehículos");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(15, "\r\n    ");
                __builder2.OpenComponent<MudBlazor.MudNavLink>(16);
                __builder2.AddAttribute(17, "Href", "/vistavehiculos");
                __builder2.AddAttribute(18, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 5 "E:\Sexto cuatrimeste\Programacion 3\Final\ProyectoFinal\Shared\NavMenu.razor"
                                              NavLinkMatch.Prefix

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(19, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 5 "E:\Sexto cuatrimeste\Programacion 3\Final\ProyectoFinal\Shared\NavMenu.razor"
                                                                          Icons.Material.Filled.RemoveRedEye

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(20, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(21, "Vista de Vehículos");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(22, "\r\n    ");
                __builder2.OpenComponent<MudBlazor.MudNavLink>(23);
                __builder2.AddAttribute(24, "Href", "/registrarcliente");
                __builder2.AddAttribute(25, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 6 "E:\Sexto cuatrimeste\Programacion 3\Final\ProyectoFinal\Shared\NavMenu.razor"
                                                NavLinkMatch.Prefix

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(26, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 6 "E:\Sexto cuatrimeste\Programacion 3\Final\ProyectoFinal\Shared\NavMenu.razor"
                                                                            Icons.Material.Filled.Person

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(27, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(28, "Gestión de Clientes");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(29, "\r\n    ");
                __builder2.OpenComponent<MudBlazor.MudNavLink>(30);
                __builder2.AddAttribute(31, "Href", "/vistaclientes");
                __builder2.AddAttribute(32, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 7 "E:\Sexto cuatrimeste\Programacion 3\Final\ProyectoFinal\Shared\NavMenu.razor"
                                             NavLinkMatch.Prefix

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(33, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 7 "E:\Sexto cuatrimeste\Programacion 3\Final\ProyectoFinal\Shared\NavMenu.razor"
                                                                         Icons.Material.Filled.FormatListBulleted

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(34, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(35, "Lista de Clientes");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(36, "\r\n    ");
                __builder2.OpenComponent<MudBlazor.MudNavLink>(37);
                __builder2.AddAttribute(38, "Href", "/reserva");
                __builder2.AddAttribute(39, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 8 "E:\Sexto cuatrimeste\Programacion 3\Final\ProyectoFinal\Shared\NavMenu.razor"
                                       NavLinkMatch.Prefix

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(40, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 8 "E:\Sexto cuatrimeste\Programacion 3\Final\ProyectoFinal\Shared\NavMenu.razor"
                                                                   Icons.Material.Filled.CarRental

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(41, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(42, "Gestión de Reservas");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(43, "\r\n    ");
                __builder2.OpenComponent<MudBlazor.MudNavLink>(44);
                __builder2.AddAttribute(45, "Href", "/mapa");
                __builder2.AddAttribute(46, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 9 "E:\Sexto cuatrimeste\Programacion 3\Final\ProyectoFinal\Shared\NavMenu.razor"
                                    NavLinkMatch.Prefix

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(47, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 9 "E:\Sexto cuatrimeste\Programacion 3\Final\ProyectoFinal\Shared\NavMenu.razor"
                                                                Icons.Material.Filled.CarRental

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(48, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(49, "Mapa");
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
