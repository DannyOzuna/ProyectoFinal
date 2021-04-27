#pragma checksum "/Users/dannyozuna/Documents/ProyectoFinal/Pages/Login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c3a2f57c49827844f62fd87efc0d2bd956a5b943"
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
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(LoginLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<MudBlazor.MudText>(0);
            __builder.AddAttribute(1, "Typo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 10 "/Users/dannyozuna/Documents/ProyectoFinal/Pages/Login.razor"
               Typo.h4

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "GutterBottom", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 10 "/Users/dannyozuna/Documents/ProyectoFinal/Pages/Login.razor"
                                      true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(4, "Iniciar Sección");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(5, "\n\n");
            __Blazor.ProyectoFinal.Pages.Login.TypeInference.CreateMudTextField_0(__builder, 6, 7, "E-mail", 8, 
#nullable restore
#line 12 "/Users/dannyozuna/Documents/ProyectoFinal/Pages/Login.razor"
                                                           Variant.Outlined

#line default
#line hidden
#nullable disable
            , 9, "my-6", 10, 
#nullable restore
#line 12 "/Users/dannyozuna/Documents/ProyectoFinal/Pages/Login.razor"
                             user

#line default
#line hidden
#nullable disable
            , 11, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => user = __value, user)));
            __builder.AddMarkupContent(12, "\n\n");
            __Blazor.ProyectoFinal.Pages.Login.TypeInference.CreateMudTextField_1(__builder, 13, 14, "Password", 15, 
#nullable restore
#line 14 "/Users/dannyozuna/Documents/ProyectoFinal/Pages/Login.razor"
                                                                Variant.Outlined

#line default
#line hidden
#nullable disable
            , 16, 
#nullable restore
#line 14 "/Users/dannyozuna/Documents/ProyectoFinal/Pages/Login.razor"
                                                                                              PasswordInput

#line default
#line hidden
#nullable disable
            , 17, 
#nullable restore
#line 14 "/Users/dannyozuna/Documents/ProyectoFinal/Pages/Login.razor"
                                                                                                                        Adornment.End

#line default
#line hidden
#nullable disable
            , 18, 
#nullable restore
#line 14 "/Users/dannyozuna/Documents/ProyectoFinal/Pages/Login.razor"
                                                                                                                                                       PasswordInputIcon

#line default
#line hidden
#nullable disable
            , 19, Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 14 "/Users/dannyozuna/Documents/ProyectoFinal/Pages/Login.razor"
                                                                                                                                                                                            TogglePasswordVisibility

#line default
#line hidden
#nullable disable
            ), 20, 
#nullable restore
#line 14 "/Users/dannyozuna/Documents/ProyectoFinal/Pages/Login.razor"
                            Password

#line default
#line hidden
#nullable disable
            , 21, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Password = __value, Password)));
            __builder.AddMarkupContent(22, "\n\n\n");
            __builder.OpenComponent<MudBlazor.MudButton>(23);
            __builder.AddAttribute(24, "Variant", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Variant>(
#nullable restore
#line 17 "/Users/dannyozuna/Documents/ProyectoFinal/Pages/Login.razor"
                    Variant.Filled

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(25, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 17 "/Users/dannyozuna/Documents/ProyectoFinal/Pages/Login.razor"
                                           Color.Primary

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(26, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 17 "/Users/dannyozuna/Documents/ProyectoFinal/Pages/Login.razor"
                                                                    BuscarDatos

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(27, "Size", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Size>(
#nullable restore
#line 17 "/Users/dannyozuna/Documents/ProyectoFinal/Pages/Login.razor"
                                                                                       Size.Large

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(28, "FullWidth", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 17 "/Users/dannyozuna/Documents/ProyectoFinal/Pages/Login.razor"
                                                                                                              true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(29, "Class", "mt-5");
            __builder.AddAttribute(30, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(31, "Sign In");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 20 "/Users/dannyozuna/Documents/ProyectoFinal/Pages/Login.razor"
       

    UsuariosDb oUsuario = new UsuariosDb();

    string user { get; set; } = "";
    string Password { get; set; } = "";

    bool PasswordVisibility;
    InputType PasswordInput = InputType.Password;
    string PasswordInputIcon = Icons.Material.Filled.VisibilityOff;

    void TogglePasswordVisibility()
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "/Users/dannyozuna/Documents/ProyectoFinal/Pages/Login.razor"
         if (PasswordVisibility)
        {
            PasswordVisibility = false;
            PasswordInputIcon = Icons.Material.Filled.VisibilityOff;
            PasswordInput = InputType.Password;
        }
        else
        {
            PasswordVisibility = true;
            PasswordInputIcon = Icons.Material.Filled.Visibility;
            PasswordInput = InputType.Text;
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "/Users/dannyozuna/Documents/ProyectoFinal/Pages/Login.razor"
         

    }


    public void BuscarDatos()
    {
        oUsuario.user_ = user;
        oUsuario.pass = Password;

        var validar = usuario.SearchUsuario(oUsuario);
        if (!validar)
        {
            var msj = Js.InvokeAsync<object>("msjAlert", "Usuario Incorrecto", "error");
        }

        else
        {
            var msj = Js.InvokeAsync<object>("msjAlert", "Sección Iniciada", "success");
            NavigationManager.NavigateTo("/Index");
        }

    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime Js { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUsuario usuario { get; set; }
    }
}
namespace __Blazor.ProyectoFinal.Pages.Login
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateMudTextField_0<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::MudBlazor.Variant __arg1, int __seq2, global::System.String __arg2, int __seq3, T __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg4)
        {
        __builder.OpenComponent<global::MudBlazor.MudTextField<T>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "Variant", __arg1);
        __builder.AddAttribute(__seq2, "Class", __arg2);
        __builder.AddAttribute(__seq3, "Value", __arg3);
        __builder.AddAttribute(__seq4, "ValueChanged", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateMudTextField_1<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::MudBlazor.Variant __arg1, int __seq2, global::MudBlazor.InputType __arg2, int __seq3, global::MudBlazor.Adornment __arg3, int __seq4, global::System.String __arg4, int __seq5, global::Microsoft.AspNetCore.Components.EventCallback<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs> __arg5, int __seq6, T __arg6, int __seq7, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg7)
        {
        __builder.OpenComponent<global::MudBlazor.MudTextField<T>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "Variant", __arg1);
        __builder.AddAttribute(__seq2, "InputType", __arg2);
        __builder.AddAttribute(__seq3, "Adornment", __arg3);
        __builder.AddAttribute(__seq4, "AdornmentIcon", __arg4);
        __builder.AddAttribute(__seq5, "OnAdornmentClick", __arg5);
        __builder.AddAttribute(__seq6, "Value", __arg6);
        __builder.AddAttribute(__seq7, "ValueChanged", __arg7);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
