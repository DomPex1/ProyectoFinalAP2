#pragma checksum "C:\Users\14012\Desktop\ProyectoFinalPA2\StudioEF\Pages\Consultas\C_Articulos.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a52272300a79721d369a38b16cad8f28e7d8cd3e"
// <auto-generated/>
#pragma warning disable 1591
namespace FEG.Pages.Consultas
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\14012\Desktop\ProyectoFinalPA2\StudioEF\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\14012\Desktop\ProyectoFinalPA2\StudioEF\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\14012\Desktop\ProyectoFinalPA2\StudioEF\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\14012\Desktop\ProyectoFinalPA2\StudioEF\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\14012\Desktop\ProyectoFinalPA2\StudioEF\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\14012\Desktop\ProyectoFinalPA2\StudioEF\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\14012\Desktop\ProyectoFinalPA2\StudioEF\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\14012\Desktop\ProyectoFinalPA2\StudioEF\_Imports.razor"
using FEG;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\14012\Desktop\ProyectoFinalPA2\StudioEF\_Imports.razor"
using FEG.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\14012\Desktop\ProyectoFinalPA2\StudioEF\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\14012\Desktop\ProyectoFinalPA2\StudioEF\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\14012\Desktop\ProyectoFinalPA2\StudioEF\Pages\Consultas\C_Articulos.razor"
using BLL;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\14012\Desktop\ProyectoFinalPA2\StudioEF\Pages\Consultas\C_Articulos.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\14012\Desktop\ProyectoFinalPA2\StudioEF\Pages\Consultas\C_Articulos.razor"
using Reportes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\14012\Desktop\ProyectoFinalPA2\StudioEF\Pages\Consultas\C_Articulos.razor"
using Paginacion;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/C_Articulos")]
    public partial class C_Articulos : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(2, "\n        ");
                __builder2.AddMarkupContent(3, "<p class=\"h4 text-center\">Usted no esta autorizado para acceder a esta pagina</p>\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(4, "\n\n");
#nullable restore
#line 17 "C:\Users\14012\Desktop\ProyectoFinalPA2\StudioEF\Pages\Consultas\C_Articulos.razor"
 if (AuthenticationStateProvider.GetAuthenticationStateAsync().Result.User.Identity.IsAuthenticated)
{


#line default
#line hidden
#nullable disable
            __builder.AddContent(5, "    ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "card-img");
            __builder.AddMarkupContent(8, "\n        ");
            __builder.AddMarkupContent(9, "<div class=\"card-header bg-dark\">\n            <h1>Consulta de Articulos</h1>\n        </div>\n\n        ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "card-body");
            __builder.AddMarkupContent(12, "\n            ");
            __builder.OpenElement(13, "form");
            __builder.AddMarkupContent(14, "\n                ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "form-row");
            __builder.AddMarkupContent(17, "\n                    \n                    ");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "form-group");
            __builder.AddMarkupContent(20, "\n                        ");
            __builder.AddMarkupContent(21, "<label>Filtro</label>\n                        ");
            __builder.OpenElement(22, "select");
            __builder.AddAttribute(23, "class", "form-control");
            __builder.AddAttribute(24, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 31 "C:\Users\14012\Desktop\ProyectoFinalPA2\StudioEF\Pages\Consultas\C_Articulos.razor"
                                                            Filtro

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(25, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Filtro = __value, Filtro));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(26, "\n                            ");
            __builder.OpenElement(27, "option");
            __builder.AddAttribute(28, "value", "0");
            __builder.AddContent(29, "Todo");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\n                            ");
            __builder.OpenElement(31, "option");
            __builder.AddAttribute(32, "value", "1");
            __builder.AddContent(33, "Articulo Id");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\n                            ");
            __builder.OpenElement(35, "option");
            __builder.AddAttribute(36, "value", "2");
            __builder.AddContent(37, "Usuario Id");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\n                            ");
            __builder.OpenElement(39, "option");
            __builder.AddAttribute(40, "value", "3");
            __builder.AddMarkupContent(41, "Descripción");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\n                            ");
            __builder.OpenElement(43, "option");
            __builder.AddAttribute(44, "value", "4");
            __builder.AddContent(45, "Categoria Id");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\n                            ");
            __builder.OpenElement(47, "option");
            __builder.AddAttribute(48, "value", "5");
            __builder.AddContent(49, "Stock");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\n                            ");
            __builder.OpenElement(51, "option");
            __builder.AddAttribute(52, "value", "6");
            __builder.AddContent(53, "Precio");
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\n                            ");
            __builder.OpenElement(55, "option");
            __builder.AddAttribute(56, "value", "7");
            __builder.AddContent(57, "Costo");
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\n                    &nbsp;\n                    ");
            __builder.OpenElement(61, "div");
            __builder.AddAttribute(62, "class", "form-group");
            __builder.AddMarkupContent(63, "\n                        ");
            __builder.AddMarkupContent(64, "<label>Criterio</label>\n                        ");
            __builder.OpenElement(65, "div");
            __builder.AddAttribute(66, "class", "input-group");
            __builder.AddMarkupContent(67, "\n                            ");
            __builder.OpenElement(68, "input");
            __builder.AddAttribute(69, "type", "text");
            __builder.AddAttribute(70, "class", "form-control");
            __builder.AddAttribute(71, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 46 "C:\Users\14012\Desktop\ProyectoFinalPA2\StudioEF\Pages\Consultas\C_Articulos.razor"
                                                      Criterio

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(72, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Criterio = __value, Criterio));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\n                            ");
            __builder.OpenElement(74, "div");
            __builder.AddAttribute(75, "class", "input-group-append");
            __builder.AddMarkupContent(76, "\n                                ");
            __builder.OpenElement(77, "button");
            __builder.AddAttribute(78, "type", "button");
            __builder.AddAttribute(79, "class", "btn btn-primary input-group-text");
            __builder.AddAttribute(80, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 48 "C:\Users\14012\Desktop\ProyectoFinalPA2\StudioEF\Pages\Consultas\C_Articulos.razor"
                                                                                                           u => Consultar(0)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(81, "<i class=\"oi oi-list-rich\"></i> Consultar");
            __builder.CloseElement();
            __builder.AddMarkupContent(82, "\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(83, "\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(84, "\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(85, "\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(86, "\n\n                ");
            __builder.OpenElement(87, "div");
            __builder.AddAttribute(88, "class", "table-responsive text-nowrap");
            __builder.AddAttribute(89, "style", "position: relative; height:200px; overflow: auto; display: block;");
            __builder.AddMarkupContent(90, "\n                    ");
            __builder.OpenElement(91, "table");
            __builder.AddAttribute(92, "class", "table table-striped");
            __builder.AddMarkupContent(93, "\n                        ");
            __builder.AddMarkupContent(94, @"<thead class=""thead-light"">
                            <tr>
                                <th>Articulo Id</th>
                                <th>Usuario Id</th>
                                <th>Descripción</th>
                                <th>Categoria Id</th>
                                <th>Stock</th>
                                <th>Precio</th>
                                <th>Costo</th>
 

                            </tr>
                        </thead>
                        ");
            __builder.OpenElement(95, "tbody");
            __builder.AddAttribute(96, "class", "bg-white");
            __builder.AddMarkupContent(97, "\n");
#nullable restore
#line 70 "C:\Users\14012\Desktop\ProyectoFinalPA2\StudioEF\Pages\Consultas\C_Articulos.razor"
                             foreach (var item in AuxListaArticulos)
                            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(98, "                                ");
            __builder.OpenElement(99, "tr");
            __builder.AddMarkupContent(100, "\n                                    ");
            __builder.OpenElement(101, "td");
            __builder.AddContent(102, 
#nullable restore
#line 73 "C:\Users\14012\Desktop\ProyectoFinalPA2\StudioEF\Pages\Consultas\C_Articulos.razor"
                                         item.ArticuloId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(103, "\n                                    ");
            __builder.OpenElement(104, "td");
            __builder.AddContent(105, 
#nullable restore
#line 74 "C:\Users\14012\Desktop\ProyectoFinalPA2\StudioEF\Pages\Consultas\C_Articulos.razor"
                                         item.UsuarioId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(106, "\n                                    ");
            __builder.OpenElement(107, "td");
            __builder.AddContent(108, 
#nullable restore
#line 75 "C:\Users\14012\Desktop\ProyectoFinalPA2\StudioEF\Pages\Consultas\C_Articulos.razor"
                                         item.Descripcion

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(109, "\n                                    ");
            __builder.OpenElement(110, "td");
            __builder.AddContent(111, 
#nullable restore
#line 76 "C:\Users\14012\Desktop\ProyectoFinalPA2\StudioEF\Pages\Consultas\C_Articulos.razor"
                                         item.CategoriaId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(112, "\n                                    ");
            __builder.OpenElement(113, "td");
            __builder.AddContent(114, 
#nullable restore
#line 77 "C:\Users\14012\Desktop\ProyectoFinalPA2\StudioEF\Pages\Consultas\C_Articulos.razor"
                                         item.Stock

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(115, "\n                                    ");
            __builder.OpenElement(116, "td");
            __builder.AddContent(117, 
#nullable restore
#line 78 "C:\Users\14012\Desktop\ProyectoFinalPA2\StudioEF\Pages\Consultas\C_Articulos.razor"
                                         item.Precio

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(118, "\n                                    ");
            __builder.OpenElement(119, "td");
            __builder.AddContent(120, 
#nullable restore
#line 79 "C:\Users\14012\Desktop\ProyectoFinalPA2\StudioEF\Pages\Consultas\C_Articulos.razor"
                                         item.Costo

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(121, "\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(122, "\n");
#nullable restore
#line 81 "C:\Users\14012\Desktop\ProyectoFinalPA2\StudioEF\Pages\Consultas\C_Articulos.razor"
                            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(123, "                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(124, "\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(125, "\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(126, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(127, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(128, "\n\n        ");
            __builder.OpenElement(129, "div");
            __builder.AddAttribute(130, "class", "form-group text-center");
            __builder.AddAttribute(131, "display:", true);
            __builder.AddAttribute(132, "inline-block", true);
            __builder.AddMarkupContent(133, "\n            ");
            __builder.OpenElement(134, "nav");
            __builder.AddAttribute(135, "aria-label", "Page navigation example");
            __builder.AddMarkupContent(136, "\n                ");
            __builder.OpenElement(137, "ul");
            __builder.AddAttribute(138, "class", "pagination justify-content-center");
            __builder.AddMarkupContent(139, "\n                    ");
            __builder.OpenElement(140, "li");
            __builder.AddAttribute(141, "class", "page-item");
            __builder.AddMarkupContent(142, "\n                        ");
            __builder.OpenElement(143, "button");
            __builder.AddAttribute(144, "class", "page-link btn btn-primary");
            __builder.AddAttribute(145, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 93 "C:\Users\14012\Desktop\ProyectoFinalPA2\StudioEF\Pages\Consultas\C_Articulos.razor"
                                            e => NavegateTo("Anterior")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(146, "tabindex", "-1");
            __builder.AddMarkupContent(147, "\n                            Anterior\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(148, "\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(149, "\n\n");
#nullable restore
#line 98 "C:\Users\14012\Desktop\ProyectoFinalPA2\StudioEF\Pages\Consultas\C_Articulos.razor"
                     for (int i = 0; i < TotalPaginas; i++)
                    {
                        var NumeroPagina = i;

#line default
#line hidden
#nullable disable
            __builder.AddContent(150, "                        ");
            __builder.OpenElement(151, "li");
            __builder.AddAttribute(152, "class", "page-item");
            __builder.AddMarkupContent(153, "\n                            ");
            __builder.OpenElement(154, "button");
            __builder.AddAttribute(155, "class", 
#nullable restore
#line 102 "C:\Users\14012\Desktop\ProyectoFinalPA2\StudioEF\Pages\Consultas\C_Articulos.razor"
                                             pagina.paginas == NumeroPagina ? "page-link btn btn-dark" : "page-link btn btn-danger"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(156, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 103 "C:\Users\14012\Desktop\ProyectoFinalPA2\StudioEF\Pages\Consultas\C_Articulos.razor"
                                                u => Consultar(NumeroPagina)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(157, "\n                                ");
            __builder.AddContent(158, 
#nullable restore
#line 104 "C:\Users\14012\Desktop\ProyectoFinalPA2\StudioEF\Pages\Consultas\C_Articulos.razor"
                                  i + 1

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(159, "\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(160, "\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(161, "\n");
#nullable restore
#line 107 "C:\Users\14012\Desktop\ProyectoFinalPA2\StudioEF\Pages\Consultas\C_Articulos.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(162, "\n                    ");
            __builder.OpenElement(163, "li");
            __builder.AddAttribute(164, "class", "page-item");
            __builder.AddMarkupContent(165, "\n                        ");
            __builder.OpenElement(166, "button");
            __builder.AddAttribute(167, "type", "button");
            __builder.AddAttribute(168, "class", "page-link btn btn-primary");
            __builder.AddAttribute(169, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 110 "C:\Users\14012\Desktop\ProyectoFinalPA2\StudioEF\Pages\Consultas\C_Articulos.razor"
                                                                                            e => NavegateTo("Siguiente")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(170, "tabindex", "-1");
            __builder.AddContent(171, "Siguiente");
            __builder.CloseElement();
            __builder.AddMarkupContent(172, "\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(173, "\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(174, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(175, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(176, "\n\n        ");
            __builder.OpenElement(177, "div");
            __builder.AddAttribute(178, "class", "card-footer bg-dark");
            __builder.AddMarkupContent(179, "\n            ");
            __builder.OpenElement(180, "div");
            __builder.AddAttribute(181, "class", "form-group text-center");
            __builder.AddMarkupContent(182, "\n                ");
            __builder.OpenElement(183, "button");
            __builder.AddAttribute(184, "class", "btn btn-lg btn-primary oi oi-file");
            __builder.AddAttribute(185, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 118 "C:\Users\14012\Desktop\ProyectoFinalPA2\StudioEF\Pages\Consultas\C_Articulos.razor"
                                                                            GenerarReporte

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(186, " Generar Reporte");
            __builder.CloseElement();
            __builder.AddMarkupContent(187, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(188, "\n\n            ");
            __builder.OpenElement(189, "form");
            __builder.AddMarkupContent(190, "\n");
#nullable restore
#line 122 "C:\Users\14012\Desktop\ProyectoFinalPA2\StudioEF\Pages\Consultas\C_Articulos.razor"
                 if (Data is { })
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(191, "                    ");
            __builder.OpenElement(192, "object");
            __builder.AddAttribute(193, "data", 
#nullable restore
#line 124 "C:\Users\14012\Desktop\ProyectoFinalPA2\StudioEF\Pages\Consultas\C_Articulos.razor"
                                   pdfContent

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(194, "width", "1000");
            __builder.AddAttribute(195, "height", "500");
            __builder.CloseElement();
            __builder.AddMarkupContent(196, "\n");
#nullable restore
#line 125 "C:\Users\14012\Desktop\ProyectoFinalPA2\StudioEF\Pages\Consultas\C_Articulos.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(197, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(198, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(199, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(200, "\n");
#nullable restore
#line 129 "C:\Users\14012\Desktop\ProyectoFinalPA2\StudioEF\Pages\Consultas\C_Articulos.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 131 "C:\Users\14012\Desktop\ProyectoFinalPA2\StudioEF\Pages\Consultas\C_Articulos.razor"
       
    public List<Articulos> ListaArticulos { get; set; }
    public List<Articulos> AuxListaArticulos { get; set; }

    Paginas pagina = new Paginas();

    public string Criterio { get; set; }

    private int TotalRegistros { get; set; }
    private int TotalPaginas { get; set; }
    public string Filtro { get; set; }

    byte[] Data;
    string pdfContent = "";

    protected override void OnInitialized()
    {
        Nuevo();
    }

    private void Nuevo()
    {
        ListaArticulos = new List<Articulos>();
        AuxListaArticulos = new List<Articulos>();
        Filtro = "0";
        Criterio = string.Empty;
    }

    public void Consultar(int pag)
    {
        switch (Filtro)
        {
            case "0": //Todo
                ListaArticulos = ArticulosBLL.GetList(c => true);
                break;
            case "1": //ClienteId
                if (Criterio.Trim().Length > 0)
                {
                    try
                    {
                        int id = Convert.ToInt32(Criterio);
                        ListaArticulos = ArticulosBLL.GetList(a => a.ArticuloId == id);
                    }
                    catch (FormatException)
                    {
                        toast.ShowWarning("Ingrese un numero");
                    }
                }
                else
                {
                    ListaArticulos = ArticulosBLL.GetList(a => true).OrderBy(a => a.ArticuloId).ToList();
                }
                break;
            case "2": //UsuarioId
                if (Criterio.Trim().Length > 0)
                {
                    try
                    {
                        int usuarioId = Convert.ToInt32(Criterio);
                        ListaArticulos = ArticulosBLL.GetList(a => a.UsuarioId == usuarioId);
                    }
                    catch (FormatException)
                    {
                        toast.ShowWarning("Ingrese un numero");
                    }
                }
                else
                {
                    ListaArticulos = ArticulosBLL.GetList(a => true).OrderBy(a => a.UsuarioId).ToList();
                }
                break;

            case "3": //Descripcion
                if (Criterio.Trim().Length > 0)
                    ListaArticulos = ArticulosBLL.GetList(a => a.Descripcion.Contains(Criterio));
                else
                    ListaArticulos = ArticulosBLL.GetList(a => true).OrderBy(a => a.Descripcion).ToList();
                break;
            case "4": //Apellidos
                try
                {
                    int categoriaId = Convert.ToInt32(Criterio);
                    ListaArticulos = ArticulosBLL.GetList(a => a.CategoriaId == categoriaId);
                }
                catch (FormatException)
                {
                    toast.ShowWarning("Ingrese un numero");
                }
                break;
            case "5": //Cedula
                try
                {
                    int stock = Convert.ToInt32(Criterio);
                    ListaArticulos = ArticulosBLL.GetList(a => a.Stock == stock);
                }
                catch (FormatException)
                {
                    toast.ShowWarning("Ingrese un numero");
                }
                break;
            case "6": //Telefono
                try
                {
                    decimal precio = Convert.ToDecimal(Criterio);
                    ListaArticulos = ArticulosBLL.GetList(a => a.Precio == precio);
                }
                catch (FormatException)
                {
                    toast.ShowWarning("Ingrese un numero");
                }
                break;
            case "7": //Celular
                try
                {
                    decimal costo = Convert.ToDecimal(Criterio);
                    ListaArticulos = ArticulosBLL.GetList(a => a.Costo == costo);
                }
                catch (FormatException)
                {
                    toast.ShowWarning("Ingrese un numero");
                }
                break;

        }

        TotalPaginas = (int)Math.Ceiling(ListaArticulos.Count() / (decimal)pagina.cantidaditems);
        ActualizarLista(pag);

        Filtro = "0";

    }

    private void ActualizarLista(int NumeroPagina)
    {
        AuxListaArticulos = ListaArticulos.Skip(NumeroPagina * pagina.cantidaditems).Take(pagina.cantidaditems).ToList();
        pagina.paginas = NumeroPagina;
    }

    private void NavegateTo(string direccion)
    {
        if (direccion == "Anterior" && pagina.paginas != 0)
            pagina.paginas -= 1;
        if (direccion == "Siguiente" && pagina.paginas != TotalPaginas)
            pagina.paginas += 1;

        ActualizarLista(pagina.paginas);
    }

    private void GenerarReporte()
    {
        ReporteArticulo articulo = new ReporteArticulo();

        Data = articulo.Reporte(AuxListaArticulos);

        pdfContent = "data:application/pdf;base64,";
        pdfContent += System.Convert.ToBase64String(Data);
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService toast { get; set; }
    }
}
#pragma warning restore 1591