// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace ProyectoFinal.Shared
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
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 42 "C:\Users\Ernest Work\Source\Repos\ProyectoFinal\Shared\MainLayout.razor"
       
    MudTheme currentTheme = new MudTheme();
    Personalizacion oPersonalizacion = new Personalizacion();
    bool _drawerOpen = true;

    void DrawerToggle()
    {
        _drawerOpen = !_drawerOpen;
    }

    protected override void OnInitialized()
    {
        currentTheme = oPersonalizacion;
    }

    private List<BreadcrumbItem> _items = new List<BreadcrumbItem>
    {
        new BreadcrumbItem("Inicio", href: "/"),
    };

    void DarkMode()
    {
        if (currentTheme == oPersonalizacion)
        {
            currentTheme = darkTheme;
        }
        else
        {
            currentTheme = oPersonalizacion;
        }
    }

    MudTheme darkTheme = new MudTheme()
    {
        Palette = new Palette()
        {
            Black = "#27272f",
            Background = "#32333d",
            Primary = Colors.Blue.Darken1,
            BackgroundGrey = "#27272f",
            Surface = "#000000",
            DrawerBackground = "#27272f",
            DrawerText = "rgba(255,255,255, 0.80)",
            DrawerIcon = "rgba(255,255,255, 0.80)",
            AppbarBackground = "#27272f",
            AppbarText = "rgba(255,255,255, 0.70)",
            TextPrimary = "rgba(255,255,255, 1)",
            TextSecondary = "rgba(255,255,255, 0.70)",
            ActionDefault = "#adadb1",
            ActionDisabled = "rgba(255,255,255, 0.70)",
            ActionDisabledBackground = "rgba(255,255,255, 0.70)"
        },

        LayoutProperties = new LayoutProperties()
        {
            DefaultBorderRadius = "15px"
        },

        Typography = new Typography()
        {
            Default = new Default()
            {
                FontFamily = new[] { "Segoe UI", "Helvetica", "Arial", "sans-serif" },
                FontSize = ".875rem",
                FontWeight = 400,
                LineHeight = 1.43,
                LetterSpacing = ".01071em"
            },
            H1 = new H1()
            {
                FontFamily = new[] { "Segoe UI", "Helvetica", "Arial", "sans-serif" },
                FontSize = "6rem",
                FontWeight = 300,
                LineHeight = 1.167,
                LetterSpacing = "-.01562em"
            },
            H2 = new H2()
            {
                FontFamily = new[] { "Segoe UI", "Helvetica", "Arial", "sans-serif" },
                FontSize = "3.75rem",
                FontWeight = 300,
                LineHeight = 1.2,
                LetterSpacing = "-.00833em"
            },
            H3 = new H3()
            {
                FontFamily = new[] { "Segoe UI", "Helvetica", "Arial", "sans-serif" },
                FontSize = "3rem",
                FontWeight = 400,
                LineHeight = 1.167,
                LetterSpacing = "0"
            },
            H4 = new H4()
            {
                FontFamily = new[] { "Segoe UI", "Helvetica", "Arial", "sans-serif" },
                FontSize = "2.125rem",
                FontWeight = 400,
                LineHeight = 1.235,
                LetterSpacing = ".00735em"
            },
            H5 = new H5()
            {
                FontFamily = new[] { "Segoe UI", "Helvetica", "Arial", "sans-serif" },
                FontSize = "1.5rem",
                FontWeight = 400,
                LineHeight = 1.334,
                LetterSpacing = "0"
            },
            H6 = new H6()
            {
                FontFamily = new[] { "Segoe UI", "Helvetica", "Arial", "sans-serif" },
                FontSize = "1.25rem",
                FontWeight = 400,
                LineHeight = 1.6,
                LetterSpacing = ".0075em"
            },
            Button = new Button()
            {
                FontFamily = new[] { "Segoe UI", "Helvetica", "Arial", "sans-serif" },
                FontSize = ".875rem",
                FontWeight = 500,
                LineHeight = 1.75,
                LetterSpacing = ".02857em"
            },
            Body1 = new Body1()
            {
                FontFamily = new[] { "Segoe UI", "Helvetica", "Arial", "sans-serif" },
                FontSize = "1rem",
                FontWeight = 400,
                LineHeight = 1.5,
                LetterSpacing = ".00938em"
            },
            Body2 = new Body2()
            {
                FontFamily = new[] { "Segoe UI", "Helvetica", "Arial", "sans-serif" },
                FontSize = ".875rem",
                FontWeight = 400,
                LineHeight = 1.43,
                LetterSpacing = ".01071em"
            },
            Caption = new Caption()
            {
                FontFamily = new[] { "Segoe UI", "Helvetica", "Arial", "sans-serif" },
                FontSize = ".75rem",
                FontWeight = 400,
                LineHeight = 1.66,
                LetterSpacing = ".03333em"
            },
            Subtitle2 = new Subtitle2()
            {
                FontFamily = new[] { "Segoe UI", "Helvetica", "Arial", "sans-serif" },
                FontSize = ".875rem",
                FontWeight = 500,
                LineHeight = 1.57,
                LetterSpacing = ".00714em"
            }
        },
        Shadows = new Shadow(),
        ZIndex = new ZIndex(),
    };

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
