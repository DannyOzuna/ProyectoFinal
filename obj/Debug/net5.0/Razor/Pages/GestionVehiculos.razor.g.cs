#pragma checksum "C:\Users\danny\Desktop\ProyectoFinal\Pages\GestionVehiculos.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7f1352cb5b92c6d55524bd15778430bb5ab6c8a9"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/registrarvehiculo")]
    public partial class GestionVehiculos : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div class=\"row justify-content-center\"><div class=\"col-md-8 text-center\"><h1 class=\"alert alert-info\">Gestión de vehículos</h1></div></div>\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "row justify-content-center mt-md-2");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "card col-10 shadow p-3 mb-5 bg-body rounded");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(5);
            __builder.AddAttribute(6, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 20 "C:\Users\danny\Desktop\ProyectoFinal\Pages\GestionVehiculos.razor"
                       oVehiculos

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(8, "div");
                __builder2.AddAttribute(9, "class", "card-body");
                __builder2.OpenComponent<MudBlazor.MudGrid>(10);
                __builder2.AddAttribute(11, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudItem>(12);
                    __builder3.AddAttribute(13, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 23 "C:\Users\danny\Desktop\ProyectoFinal\Pages\GestionVehiculos.razor"
                             12

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(14, "sm", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 23 "C:\Users\danny\Desktop\ProyectoFinal\Pages\GestionVehiculos.razor"
                                     6

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(15, "md", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 23 "C:\Users\danny\Desktop\ProyectoFinal\Pages\GestionVehiculos.razor"
                                            4

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(16, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __Blazor.ProyectoFinal.Pages.GestionVehiculos.TypeInference.CreateMudTextField_0(__builder4, 17, 18, "Marca", 19, 
#nullable restore
#line 24 "C:\Users\danny\Desktop\ProyectoFinal\Pages\GestionVehiculos.razor"
                                                                              Variant.Outlined

#line default
#line hidden
#nullable disable
                        , 20, 
#nullable restore
#line 24 "C:\Users\danny\Desktop\ProyectoFinal\Pages\GestionVehiculos.razor"
                                                                                                           Adornment.End

#line default
#line hidden
#nullable disable
                        , 21, 
#nullable restore
#line 24 "C:\Users\danny\Desktop\ProyectoFinal\Pages\GestionVehiculos.razor"
                                                                                                                                          Icons.Filled.CarRental

#line default
#line hidden
#nullable disable
                        , 22, 
#nullable restore
#line 24 "C:\Users\danny\Desktop\ProyectoFinal\Pages\GestionVehiculos.razor"
                                                                                                                                                                                  Color.Info

#line default
#line hidden
#nullable disable
                        , 23, 
#nullable restore
#line 24 "C:\Users\danny\Desktop\ProyectoFinal\Pages\GestionVehiculos.razor"
                                               Weight

#line default
#line hidden
#nullable disable
                        , 24, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Weight = __value, Weight)));
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(25, "\r\n                ");
                    __builder3.OpenComponent<MudBlazor.MudItem>(26);
                    __builder3.AddAttribute(27, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 26 "C:\Users\danny\Desktop\ProyectoFinal\Pages\GestionVehiculos.razor"
                             12

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(28, "sm", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 26 "C:\Users\danny\Desktop\ProyectoFinal\Pages\GestionVehiculos.razor"
                                     6

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(29, "md", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 26 "C:\Users\danny\Desktop\ProyectoFinal\Pages\GestionVehiculos.razor"
                                            4

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(30, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __Blazor.ProyectoFinal.Pages.GestionVehiculos.TypeInference.CreateMudTextField_1(__builder4, 31, 32, "Modelo", 33, 
#nullable restore
#line 27 "C:\Users\danny\Desktop\ProyectoFinal\Pages\GestionVehiculos.razor"
                                                                               Variant.Outlined

#line default
#line hidden
#nullable disable
                        , 34, 
#nullable restore
#line 27 "C:\Users\danny\Desktop\ProyectoFinal\Pages\GestionVehiculos.razor"
                                                                                                            Adornment.End

#line default
#line hidden
#nullable disable
                        , 35, 
#nullable restore
#line 27 "C:\Users\danny\Desktop\ProyectoFinal\Pages\GestionVehiculos.razor"
                                                                                                                                           Icons.Filled.CarRental

#line default
#line hidden
#nullable disable
                        , 36, 
#nullable restore
#line 27 "C:\Users\danny\Desktop\ProyectoFinal\Pages\GestionVehiculos.razor"
                                                                                                                                                                                   Color.Info

#line default
#line hidden
#nullable disable
                        , 37, 
#nullable restore
#line 27 "C:\Users\danny\Desktop\ProyectoFinal\Pages\GestionVehiculos.razor"
                                               Weight

#line default
#line hidden
#nullable disable
                        , 38, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Weight = __value, Weight)));
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(39, "\r\n                ");
                    __builder3.OpenComponent<MudBlazor.MudItem>(40);
                    __builder3.AddAttribute(41, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 29 "C:\Users\danny\Desktop\ProyectoFinal\Pages\GestionVehiculos.razor"
                             12

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(42, "sm", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 29 "C:\Users\danny\Desktop\ProyectoFinal\Pages\GestionVehiculos.razor"
                                     6

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(43, "md", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 29 "C:\Users\danny\Desktop\ProyectoFinal\Pages\GestionVehiculos.razor"
                                            4

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(44, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<MudBlazor.MudSelect<string>>(45);
                        __builder4.AddAttribute(46, "Label", "Año");
                        __builder4.AddAttribute(47, "Variant", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Variant>(
#nullable restore
#line 30 "C:\Users\danny\Desktop\ProyectoFinal\Pages\GestionVehiculos.razor"
                                                                                    Variant.Outlined

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(48, "OffsetY", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 30 "C:\Users\danny\Desktop\ProyectoFinal\Pages\GestionVehiculos.razor"
                                                                                                               true

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(49, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<string>(
#nullable restore
#line 30 "C:\Users\danny\Desktop\ProyectoFinal\Pages\GestionVehiculos.razor"
                                                       Search

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(50, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<string>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<string>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Search = __value, Search))));
                        __builder4.AddAttribute(51, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
#nullable restore
#line 31 "C:\Users\danny\Desktop\ProyectoFinal\Pages\GestionVehiculos.razor"
                         for(int i=2021; i >= 1900; i--){

#line default
#line hidden
#nullable disable
                            __Blazor.ProyectoFinal.Pages.GestionVehiculos.TypeInference.CreateMudSelectItem_2(__builder5, 52, 53, 
#nullable restore
#line 32 "C:\Users\danny\Desktop\ProyectoFinal\Pages\GestionVehiculos.razor"
                                                    i.ToString()

#line default
#line hidden
#nullable disable
                            );
#nullable restore
#line 33 "C:\Users\danny\Desktop\ProyectoFinal\Pages\GestionVehiculos.razor"
                        }

#line default
#line hidden
#nullable disable
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(54, "\r\n                ");
                    __builder3.OpenComponent<MudBlazor.MudItem>(55);
                    __builder3.AddAttribute(56, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 36 "C:\Users\danny\Desktop\ProyectoFinal\Pages\GestionVehiculos.razor"
                             12

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(57, "sm", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 36 "C:\Users\danny\Desktop\ProyectoFinal\Pages\GestionVehiculos.razor"
                                     6

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(58, "md", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 36 "C:\Users\danny\Desktop\ProyectoFinal\Pages\GestionVehiculos.razor"
                                            4

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(59, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __Blazor.ProyectoFinal.Pages.GestionVehiculos.TypeInference.CreateMudTextField_3(__builder4, 60, 61, "Amount", 62, 
#nullable restore
#line 37 "C:\Users\danny\Desktop\ProyectoFinal\Pages\GestionVehiculos.razor"
                                                                               Variant.Outlined

#line default
#line hidden
#nullable disable
                        , 63, 
#nullable restore
#line 37 "C:\Users\danny\Desktop\ProyectoFinal\Pages\GestionVehiculos.razor"
                                                                                                            Adornment.Start

#line default
#line hidden
#nullable disable
                        , 64, 
#nullable restore
#line 37 "C:\Users\danny\Desktop\ProyectoFinal\Pages\GestionVehiculos.razor"
                                                                                                                                             Icons.Material.Filled.AttachMoney

#line default
#line hidden
#nullable disable
                        , 65, 
#nullable restore
#line 37 "C:\Users\danny\Desktop\ProyectoFinal\Pages\GestionVehiculos.razor"
                                                                                                                                                                                                Color.Warning

#line default
#line hidden
#nullable disable
                        , 66, 
#nullable restore
#line 37 "C:\Users\danny\Desktop\ProyectoFinal\Pages\GestionVehiculos.razor"
                                               Amount

#line default
#line hidden
#nullable disable
                        , 67, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Amount = __value, Amount)));
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(68, "\r\n                ");
                    __builder3.OpenComponent<MudBlazor.MudItem>(69);
                    __builder3.AddAttribute(70, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 39 "C:\Users\danny\Desktop\ProyectoFinal\Pages\GestionVehiculos.razor"
                             12

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(71, "sm", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 39 "C:\Users\danny\Desktop\ProyectoFinal\Pages\GestionVehiculos.razor"
                                     6

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(72, "md", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 39 "C:\Users\danny\Desktop\ProyectoFinal\Pages\GestionVehiculos.razor"
                                            4

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(73, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __Blazor.ProyectoFinal.Pages.GestionVehiculos.TypeInference.CreateMudTextField_4(__builder4, 74, 75, "Weight", 76, 
#nullable restore
#line 40 "C:\Users\danny\Desktop\ProyectoFinal\Pages\GestionVehiculos.razor"
                                                                               Variant.Outlined

#line default
#line hidden
#nullable disable
                        , 77, 
#nullable restore
#line 40 "C:\Users\danny\Desktop\ProyectoFinal\Pages\GestionVehiculos.razor"
                                                                                                            Adornment.End

#line default
#line hidden
#nullable disable
                        , 78, "Kg", 79, 
#nullable restore
#line 40 "C:\Users\danny\Desktop\ProyectoFinal\Pages\GestionVehiculos.razor"
                                                                                                                                                              Color.Info

#line default
#line hidden
#nullable disable
                        , 80, 
#nullable restore
#line 40 "C:\Users\danny\Desktop\ProyectoFinal\Pages\GestionVehiculos.razor"
                                               Weight

#line default
#line hidden
#nullable disable
                        , 81, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Weight = __value, Weight)));
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(82, "\r\n          ");
                __builder2.AddMarkupContent(83, "<div class=\"card-footer\"><div class=\"row justify-content-center\"><button type=\"submit\" class=\"btn btn-outline-primary col-8 bn-lg\">Guardar</button></div></div>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 54 "C:\Users\danny\Desktop\ProyectoFinal\Pages\GestionVehiculos.razor"
      
    
    VehiculosDb oVehiculos = new VehiculosDb();
    public double? Amount { get; set; }
    public int? Weight { get; set; }
    public string Search { get; set;}

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.ProyectoFinal.Pages.GestionVehiculos
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateMudTextField_0<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::MudBlazor.Variant __arg1, int __seq2, global::MudBlazor.Adornment __arg2, int __seq3, global::System.String __arg3, int __seq4, global::MudBlazor.Color __arg4, int __seq5, T __arg5, int __seq6, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg6)
        {
        __builder.OpenComponent<global::MudBlazor.MudTextField<T>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "Variant", __arg1);
        __builder.AddAttribute(__seq2, "Adornment", __arg2);
        __builder.AddAttribute(__seq3, "AdornmentIcon", __arg3);
        __builder.AddAttribute(__seq4, "AdornmentColor", __arg4);
        __builder.AddAttribute(__seq5, "Value", __arg5);
        __builder.AddAttribute(__seq6, "ValueChanged", __arg6);
        __builder.CloseComponent();
        }
        public static void CreateMudTextField_1<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::MudBlazor.Variant __arg1, int __seq2, global::MudBlazor.Adornment __arg2, int __seq3, global::System.String __arg3, int __seq4, global::MudBlazor.Color __arg4, int __seq5, T __arg5, int __seq6, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg6)
        {
        __builder.OpenComponent<global::MudBlazor.MudTextField<T>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "Variant", __arg1);
        __builder.AddAttribute(__seq2, "Adornment", __arg2);
        __builder.AddAttribute(__seq3, "AdornmentIcon", __arg3);
        __builder.AddAttribute(__seq4, "AdornmentColor", __arg4);
        __builder.AddAttribute(__seq5, "Value", __arg5);
        __builder.AddAttribute(__seq6, "ValueChanged", __arg6);
        __builder.CloseComponent();
        }
        public static void CreateMudSelectItem_2<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, T __arg0)
        {
        __builder.OpenComponent<global::MudBlazor.MudSelectItem<T>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateMudTextField_3<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::MudBlazor.Variant __arg1, int __seq2, global::MudBlazor.Adornment __arg2, int __seq3, global::System.String __arg3, int __seq4, global::MudBlazor.Color __arg4, int __seq5, T __arg5, int __seq6, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg6)
        {
        __builder.OpenComponent<global::MudBlazor.MudTextField<T>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "Variant", __arg1);
        __builder.AddAttribute(__seq2, "Adornment", __arg2);
        __builder.AddAttribute(__seq3, "AdornmentIcon", __arg3);
        __builder.AddAttribute(__seq4, "AdornmentColor", __arg4);
        __builder.AddAttribute(__seq5, "Value", __arg5);
        __builder.AddAttribute(__seq6, "ValueChanged", __arg6);
        __builder.CloseComponent();
        }
        public static void CreateMudTextField_4<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::MudBlazor.Variant __arg1, int __seq2, global::MudBlazor.Adornment __arg2, int __seq3, global::System.String __arg3, int __seq4, global::MudBlazor.Color __arg4, int __seq5, T __arg5, int __seq6, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg6)
        {
        __builder.OpenComponent<global::MudBlazor.MudTextField<T>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "Variant", __arg1);
        __builder.AddAttribute(__seq2, "Adornment", __arg2);
        __builder.AddAttribute(__seq3, "AdornmentText", __arg3);
        __builder.AddAttribute(__seq4, "AdornmentColor", __arg4);
        __builder.AddAttribute(__seq5, "Value", __arg5);
        __builder.AddAttribute(__seq6, "ValueChanged", __arg6);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
