#pragma checksum "C:\Users\14012\Desktop\ProyectoFinalPA2\StudioEF\Pages\Consultas\C_Fotografos.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "15f04e384076f5c6a9263dc955058ae6a5566760"
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
#line 3 "C:\Users\14012\Desktop\ProyectoFinalPA2\StudioEF\Pages\Consultas\C_Fotografos.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\14012\Desktop\ProyectoFinalPA2\StudioEF\Pages\Consultas\C_Fotografos.razor"
using BLL;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\14012\Desktop\ProyectoFinalPA2\StudioEF\Pages\Consultas\C_Fotografos.razor"
using Reportes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\14012\Desktop\ProyectoFinalPA2\StudioEF\Pages\Consultas\C_Fotografos.razor"
using Paginacion;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/C_Fotografos")]
    public partial class C_Fotografos : Microsoft.AspNetCore.Components.ComponentBase
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
#line 17 "C:\Users\14012\Desktop\ProyectoFinalPA2\StudioEF\Pages\Consultas\C_Fotografos.razor"
 if (AuthenticationStateProvider.GetAuthenticationStateAsync().Result.User.Identity.IsAuthenticated)
{


#line default
#line hidden
#nullable disable
            __builder.AddContent(5, "    ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "card-img");
            __builder.AddMarkupContent(8, "\n        ");
            __builder.AddMarkupContent(9, "<div class=\"card-header bg-dark\">\n            <h1>Consulta de Fotografos</h1>\n        </div>\n\n        ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "card-body");
            __builder.AddMarkupContent(12, "\n            ");
            __builder.OpenElement(13, "form");
            __builder.AddMarkupContent(14, "\n                ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "form-row");
            __builder.AddMarkupContent(17, "\n\n                    ");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "form-group");
            __builder.AddMarkupContent(20, "\n                        ");
            __builder.AddMarkupContent(21, "<label>Filtro</label>\n                        ");
            __builder.OpenElement(22, "select");
            __builder.AddAttribute(23, "class", "form-control");
            __builder.AddAttribute(24, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 31 "C:\Users\14012\Desktop\ProyectoFinalPA2\StudioEF\Pages\Consultas\C_Fotografos.razor"
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
            __builder.AddContent(33, "Fotografo Id");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\n                            ");
            __builder.OpenElement(35, "option");
            __builder.AddAttribute(36, "value", "2");
            __builder.AddContent(37, "Usuario Id");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\n                            ");
            __builder.OpenElement(39, "option");
            __builder.AddAttribute(40, "value", "3");
            __builder.AddContent(41, "Nombres");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\n                            ");
            __builder.OpenElement(43, "option");
            __builder.AddAttribute(44, "value", "4");
            __builder.AddContent(45, "Apellidos");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\n                            ");
            __builder.OpenElement(47, "option");
            __builder.AddAttribute(48, "value", "5");
            __builder.AddMarkupContent(49, "Cedúla");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\n                            ");
            __builder.OpenElement(51, "option");
            __builder.AddAttribute(52, "value", "6");
            __builder.AddMarkupContent(53, "Dirección");
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\n                            ");
            __builder.OpenElement(55, "option");
            __builder.AddAttribute(56, "value", "7");
            __builder.AddMarkupContent(57, "Teléfono");
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\n                            ");
            __builder.OpenElement(59, "option");
            __builder.AddAttribute(60, "value", "8");
            __builder.AddContent(61, "Celular");
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\n                            ");
            __builder.OpenElement(63, "option");
            __builder.AddAttribute(64, "value", "9");
            __builder.AddContent(65, "Sexo");
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\n                            ");
            __builder.OpenElement(67, "option");
            __builder.AddAttribute(68, "value", "10");
            __builder.AddContent(69, "Sueldo");
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\n\n\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(72, "\n                    &nbsp;\n                    ");
            __builder.OpenElement(73, "div");
            __builder.AddAttribute(74, "class", "form-group");
            __builder.AddMarkupContent(75, "\n                        ");
            __builder.AddMarkupContent(76, "<label>Criterio</label>\n                        ");
            __builder.OpenElement(77, "div");
            __builder.AddAttribute(78, "class", "input-group");
            __builder.AddMarkupContent(79, "\n                            ");
            __builder.OpenElement(80, "input");
            __builder.AddAttribute(81, "type", "text");
            __builder.AddAttribute(82, "class", "form-control");
            __builder.AddAttribute(83, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 51 "C:\Users\14012\Desktop\ProyectoFinalPA2\StudioEF\Pages\Consultas\C_Fotografos.razor"
                                                      Criterio

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(84, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Criterio = __value, Criterio));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(85, "\n                            ");
            __builder.OpenElement(86, "div");
            __builder.AddAttribute(87, "class", "input-group-append");
            __builder.AddMarkupContent(88, "\n                                ");
            __builder.OpenElement(89, "button");
            __builder.AddAttribute(90, "type", "button");
            __builder.AddAttribute(91, "class", "btn btn-primary input-group-text");
            __builder.AddAttribute(92, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 53 "C:\Users\14012\Desktop\ProyectoFinalPA2\StudioEF\Pages\Consultas\C_Fotografos.razor"
                                                                                                           u => Consultar(0)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(93, "<i class=\"oi oi-list-rich\"></i> Consultar");
            __builder.CloseElement();
            __builder.AddMarkupContent(94, "\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(95, "\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(96, "\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(97, "\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(98, "\n\n                ");
            __builder.OpenElement(99, "div");
            __builder.AddAttribute(100, "class", "table-responsive text-nowrap");
            __builder.AddAttribute(101, "style", "position: relative; height:200px; overflow: auto; display: block;");
            __builder.AddMarkupContent(102, "\n                    ");
            __builder.OpenElement(103, "table");
            __builder.AddAttribute(104, "class", "table table-striped");
            __builder.AddMarkupContent(105, "\n                        ");
            __builder.AddMarkupContent(106, @"<thead class=""thead-light"">
                            <tr>
                                <th>Fotografo Id</th>
                                <th>Usuario Id</th>
                                <th>Nombre</th>
                                <th>Apellidos</th>
                                <th>Cedúla</th>
                                <th>Dirección</th>
                                <th>Teléfono</th>
                                <th>Celular</th>
                                <th>Sexo</th>
                                <th>Sueldo</th>
                                <th>Fecha de nacimiento</th>
                            </tr>
                        </thead>
                        ");
            __builder.OpenElement(107, "tbody");
            __builder.AddAttribute(108, "class", "bg-white");
            __builder.AddMarkupContent(109, "\n");
#nullable restore
#line 77 "C:\Users\14012\Desktop\ProyectoFinalPA2\StudioEF\Pages\Consultas\C_Fotografos.razor"
                             foreach (var item in AuxListaFotografos)
                            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(110, "                            ");
            __builder.OpenElement(111, "tr");
            __builder.AddMarkupContent(112, "\n                                ");
            __builder.OpenElement(113, "td");
            __builder.AddContent(114, 
#nullable restore
#line 80 "C:\Users\14012\Desktop\ProyectoFinalPA2\StudioEF\Pages\Consultas\C_Fotografos.razor"
                                     item.FotografoId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(115, "\n                                ");
            __builder.OpenElement(116, "td");
            __builder.AddContent(117, 
#nullable restore
#line 81 "C:\Users\14012\Desktop\ProyectoFinalPA2\StudioEF\Pages\Consultas\C_Fotografos.razor"
                                     item.UsuarioId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(118, "\n                                ");
            __builder.OpenElement(119, "td");
            __builder.AddContent(120, 
#nullable restore
#line 82 "C:\Users\14012\Desktop\ProyectoFinalPA2\StudioEF\Pages\Consultas\C_Fotografos.razor"
                                     item.Nombres

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(121, "\n                                ");
            __builder.OpenElement(122, "td");
            __builder.AddContent(123, 
#nullable restore
#line 83 "C:\Users\14012\Desktop\ProyectoFinalPA2\StudioEF\Pages\Consultas\C_Fotografos.razor"
                                     item.Apellidos

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(124, "\n                                ");
            __builder.OpenElement(125, "td");
            __builder.AddContent(126, 
#nullable restore
#line 84 "C:\Users\14012\Desktop\ProyectoFinalPA2\StudioEF\Pages\Consultas\C_Fotografos.razor"
                                     item.Cedula

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(127, "\n                                ");
            __builder.OpenElement(128, "td");
            __builder.AddContent(129, 
#nullable restore
#line 85 "C:\Users\14012\Desktop\ProyectoFinalPA2\StudioEF\Pages\Consultas\C_Fotografos.razor"
                                     item.Direccion

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(130, "\n                                ");
            __builder.OpenElement(131, "td");
            __builder.AddContent(132, 
#nullable restore
#line 86 "C:\Users\14012\Desktop\ProyectoFinalPA2\StudioEF\Pages\Consultas\C_Fotografos.razor"
                                     item.Telefono

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(133, "\n                                ");
            __builder.OpenElement(134, "td");
            __builder.AddContent(135, 
#nullable restore
#line 87 "C:\Users\14012\Desktop\ProyectoFinalPA2\StudioEF\Pages\Consultas\C_Fotografos.razor"
                                     item.Celular

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(136, "\n                                ");
            __builder.OpenElement(137, "td");
            __builder.AddContent(138, 
#nullable restore
#line 88 "C:\Users\14012\Desktop\ProyectoFinalPA2\StudioEF\Pages\Consultas\C_Fotografos.razor"
                                     item.Sexo

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(139, "\n                                ");
            __builder.OpenElement(140, "td");
            __builder.AddContent(141, 
#nullable restore
#line 89 "C:\Users\14012\Desktop\ProyectoFinalPA2\StudioEF\Pages\Consultas\C_Fotografos.razor"
                                     item.Sueldo

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(142, "\n                                ");
            __builder.OpenElement(143, "td");
            __builder.AddContent(144, 
#nullable restore
#line 90 "C:\Users\14012\Desktop\ProyectoFinalPA2\StudioEF\Pages\Consultas\C_Fotografos.razor"
                                     item.FechaNacimiento

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(145, "\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(146, "\n");
#nullable restore
#line 92 "C:\Users\14012\Desktop\ProyectoFinalPA2\StudioEF\Pages\Consultas\C_Fotografos.razor"
                            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(147, "                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(148, "\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(149, "\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(150, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(151, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(152, "\n\n        ");
            __builder.OpenElement(153, "div");
            __builder.AddAttribute(154, "class", "form-group text-center");
            __builder.AddAttribute(155, "display:", true);
            __builder.AddAttribute(156, "inline-block", true);
            __builder.AddMarkupContent(157, "\n            ");
            __builder.OpenElement(158, "nav");
            __builder.AddAttribute(159, "aria-label", "Page navigation example");
            __builder.AddMarkupContent(160, "\n                ");
            __builder.OpenElement(161, "ul");
            __builder.AddAttribute(162, "class", "pagination justify-content-center");
            __builder.AddMarkupContent(163, "\n                    ");
            __builder.OpenElement(164, "li");
            __builder.AddAttribute(165, "class", "page-item");
            __builder.AddMarkupContent(166, "\n                        ");
            __builder.OpenElement(167, "button");
            __builder.AddAttribute(168, "class", "page-link btn btn-primary");
            __builder.AddAttribute(169, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 104 "C:\Users\14012\Desktop\ProyectoFinalPA2\StudioEF\Pages\Consultas\C_Fotografos.razor"
                                            e => NavegateTo("Anterior")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(170, "tabindex", "-1");
            __builder.AddMarkupContent(171, "\n                            Anterior\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(172, "\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(173, "\n\n");
#nullable restore
#line 109 "C:\Users\14012\Desktop\ProyectoFinalPA2\StudioEF\Pages\Consultas\C_Fotografos.razor"
                     for (int i = 0; i < TotalPaginas; i++)
                    {
                        var NumeroPagina = i;

#line default
#line hidden
#nullable disable
            __builder.AddContent(174, "                        ");
            __builder.OpenElement(175, "li");
            __builder.AddAttribute(176, "class", "page-item");
            __builder.AddMarkupContent(177, "\n                            ");
            __builder.OpenElement(178, "button");
            __builder.AddAttribute(179, "class", 
#nullable restore
#line 113 "C:\Users\14012\Desktop\ProyectoFinalPA2\StudioEF\Pages\Consultas\C_Fotografos.razor"
                                             pagina.paginas == NumeroPagina ? "page-link btn btn-dark" : "page-link btn btn-danger"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(180, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 114 "C:\Users\14012\Desktop\ProyectoFinalPA2\StudioEF\Pages\Consultas\C_Fotografos.razor"
                                                u => Consultar(NumeroPagina)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(181, "\n                                ");
            __builder.AddContent(182, 
#nullable restore
#line 115 "C:\Users\14012\Desktop\ProyectoFinalPA2\StudioEF\Pages\Consultas\C_Fotografos.razor"
                                  i + 1

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(183, "\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(184, "\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(185, "\n");
#nullable restore
#line 118 "C:\Users\14012\Desktop\ProyectoFinalPA2\StudioEF\Pages\Consultas\C_Fotografos.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(186, "\n                    ");
            __builder.OpenElement(187, "li");
            __builder.AddAttribute(188, "class", "page-item");
            __builder.AddMarkupContent(189, "\n                        ");
            __builder.OpenElement(190, "button");
            __builder.AddAttribute(191, "type", "button");
            __builder.AddAttribute(192, "class", "page-link btn btn-primary");
            __builder.AddAttribute(193, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 121 "C:\Users\14012\Desktop\ProyectoFinalPA2\StudioEF\Pages\Consultas\C_Fotografos.razor"
                                                                                            e => NavegateTo("Siguiente")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(194, "tabindex", "-1");
            __builder.AddContent(195, "Siguiente");
            __builder.CloseElement();
            __builder.AddMarkupContent(196, "\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(197, "\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(198, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(199, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(200, "\n\n        ");
            __builder.OpenElement(201, "div");
            __builder.AddAttribute(202, "class", "card-footer bg-dark");
            __builder.AddMarkupContent(203, "\n            ");
            __builder.OpenElement(204, "div");
            __builder.AddAttribute(205, "class", "form-group text-center");
            __builder.AddMarkupContent(206, "\n                ");
            __builder.OpenElement(207, "button");
            __builder.AddAttribute(208, "class", "btn btn-lg btn-primary oi oi-file");
            __builder.AddAttribute(209, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 129 "C:\Users\14012\Desktop\ProyectoFinalPA2\StudioEF\Pages\Consultas\C_Fotografos.razor"
                                                                            GenerarReporte

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(210, " Generar Reporte");
            __builder.CloseElement();
            __builder.AddMarkupContent(211, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(212, "\n\n            ");
            __builder.OpenElement(213, "form");
            __builder.AddMarkupContent(214, "\n");
#nullable restore
#line 133 "C:\Users\14012\Desktop\ProyectoFinalPA2\StudioEF\Pages\Consultas\C_Fotografos.razor"
                 if (Data is { })
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(215, "                    ");
            __builder.OpenElement(216, "object");
            __builder.AddAttribute(217, "data", 
#nullable restore
#line 135 "C:\Users\14012\Desktop\ProyectoFinalPA2\StudioEF\Pages\Consultas\C_Fotografos.razor"
                                   pdfContent

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(218, "width", "1000");
            __builder.AddAttribute(219, "height", "500");
            __builder.CloseElement();
            __builder.AddMarkupContent(220, "\n");
#nullable restore
#line 136 "C:\Users\14012\Desktop\ProyectoFinalPA2\StudioEF\Pages\Consultas\C_Fotografos.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(221, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(222, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(223, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(224, "\n");
#nullable restore
#line 140 "C:\Users\14012\Desktop\ProyectoFinalPA2\StudioEF\Pages\Consultas\C_Fotografos.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 142 "C:\Users\14012\Desktop\ProyectoFinalPA2\StudioEF\Pages\Consultas\C_Fotografos.razor"
       
    public List<Fotografos> ListaFotografos { get; set; }
    public List<Fotografos> AuxListaFotografos { get; set; }

    Paginas pagina = new Paginas();
    private DateTime Desde { get; set; } = DateTime.Now;
    private DateTime Hasta { get; set; } = DateTime.Now;

    public string Criterio { get; set; }

    private int TotalRegistros { get; set; }
    private int TotalPaginas { get; set; }
    public string Filtro { get; set; }
    private string FiltroFecha { get; set; }

    byte[] Data;
    string pdfContent = "";

    protected override void OnInitialized()
    {
        Nuevo();
    }

    private void Nuevo()
    {
        ListaFotografos = new List<Fotografos>();
        AuxListaFotografos = new List<Fotografos>();
        Filtro = "0";
        Criterio = string.Empty;
    }

    public void Consultar(int pag)
    {
        switch (Filtro)
        {
            case "0": //Todo
                ListaFotografos = FotografosBLL.GetList(c => true);
                break;
            case "1": //FotogradoId
                if (Criterio.Trim().Length > 0)
                {
                    try
                    {
                        int id = Convert.ToInt32(Criterio);
                        ListaFotografos = FotografosBLL.GetList(a => a.FotografoId == id);
                    }
                    catch (FormatException)
                    {
                        toast.ShowWarning("Ingrese un numero");
                    }
                }
                else
                {
                    ListaFotografos = FotografosBLL.GetList(c => true).OrderBy(c => c.FotografoId).ToList();
                }
                break;
            case "2": //UsuarioId
                if (Criterio.Trim().Length > 0)
                {
                    try
                    {
                        int UsuarioId = Convert.ToInt32(Criterio);
                        ListaFotografos = FotografosBLL.GetList(c => c.UsuarioId == UsuarioId);
                    }
                    catch (FormatException)
                    {
                        toast.ShowWarning("Ingrese un numero");
                    }
                }
                else
                {
                    ListaFotografos = FotografosBLL.GetList(c => true).OrderBy(c => c.UsuarioId).ToList();
                }
                break;

            case "3": //Nombre
                if (Criterio.Trim().Length > 0)
                    ListaFotografos = FotografosBLL.GetList(c => c.Nombres.Contains(Criterio));
                else
                    ListaFotografos = FotografosBLL.GetList(c => true).OrderBy(c => c.Nombres).ToList();
                break;
            case "4": //Apellido
                if (Criterio.Trim().Length > 0)
                    ListaFotografos = FotografosBLL.GetList(c => c.Apellidos.Contains(Criterio));
                else
                    ListaFotografos = FotografosBLL.GetList(c => true).OrderBy(c => c.Apellidos).ToList();
                break;
            case "5": //Cedula
                if (Criterio.Trim().Length > 0)
                    ListaFotografos = FotografosBLL.GetList(c => c.Cedula.Contains(Criterio));
                else
                    ListaFotografos = FotografosBLL.GetList(c => true).OrderBy(c => c.Cedula).ToList();
                break;
            case "6": //Direccion
                if (Criterio.Trim().Length > 0)
                    ListaFotografos = FotografosBLL.GetList(c => c.Direccion.Contains(Criterio));
                else
                    ListaFotografos = FotografosBLL.GetList(c => true).OrderBy(c => c.Direccion).ToList();
                break;
            case "7": //Telefono
                if (Criterio.Trim().Length > 0)
                    ListaFotografos = FotografosBLL.GetList(c => c.Telefono.Contains(Criterio));
                else
                    ListaFotografos = FotografosBLL.GetList(c => true).OrderBy(c => c.Telefono).ToList();
                break;
            case "8": //celular
                if (Criterio.Trim().Length > 0)
                    ListaFotografos = FotografosBLL.GetList(c => c.Celular.Contains(Criterio));
                else
                    ListaFotografos = FotografosBLL.GetList(c => true).OrderBy(c => c.Celular).ToList();
                break;
            case "9": //Sexo
                if (Criterio.Trim().Length > 0)
                    ListaFotografos = FotografosBLL.GetList(c => c.Sexo.Contains(Criterio));
                else
                    ListaFotografos = FotografosBLL.GetList(c => true).OrderBy(c => c.Sexo).ToList();
                break;
            case "10": //Sueldo
                try
                {
                    decimal Sueldo = Convert.ToDecimal(Criterio);
                    ListaFotografos = FotografosBLL.GetList(a => a.Sueldo == Sueldo);
                }
                catch (FormatException)
                {
                    toast.ShowWarning("Ingrese un numero");
                }
                break;

        }

        switch (FiltroFecha)
        {
            case "0": //Nada
                break;
            case "1": //Fecha
                ListaFotografos = ListaFotografos.Where(s => s.FechaNacimiento >= Desde && s.FechaNacimiento <= Hasta).ToList();
                break;

        }

        TotalPaginas = (int)Math.Ceiling(ListaFotografos.Count() / (decimal)pagina.cantidaditems);
        ActualizarLista(pag);

        Filtro = "0";

    }

    private void ActualizarLista(int NumeroPagina)
    {
        AuxListaFotografos = ListaFotografos.Skip(NumeroPagina * pagina.cantidaditems).Take(pagina.cantidaditems).ToList();
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
        ReporteFotografo fotografo = new ReporteFotografo();

        Data = fotografo.Reporte(AuxListaFotografos);

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
