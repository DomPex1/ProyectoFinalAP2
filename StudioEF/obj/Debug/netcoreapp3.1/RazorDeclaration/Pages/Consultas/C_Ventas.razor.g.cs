#pragma checksum "C:\Users\14012\Desktop\ProyectoFinalPA2\StudioEF\Pages\Consultas\C_Ventas.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b6fcae8718b89c8e0a354d7d4e4146195402aa1d"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 3 "C:\Users\14012\Desktop\ProyectoFinalPA2\StudioEF\Pages\Consultas\C_Ventas.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\14012\Desktop\ProyectoFinalPA2\StudioEF\Pages\Consultas\C_Ventas.razor"
using BLL;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\14012\Desktop\ProyectoFinalPA2\StudioEF\Pages\Consultas\C_Ventas.razor"
using Reportes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\14012\Desktop\ProyectoFinalPA2\StudioEF\Pages\Consultas\C_Ventas.razor"
using Paginacion;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/C_Ventas")]
    public partial class C_Ventas : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 154 "C:\Users\14012\Desktop\ProyectoFinalPA2\StudioEF\Pages\Consultas\C_Ventas.razor"
       
    public List<Ventas> ListaVentas { get; set; }
    public List<Ventas> AuxListaVentas { get; set; }

    Paginas pagina = new Paginas();

    private DateTime Desde { get; set; } = DateTime.Now;
    private DateTime Hasta { get; set; } = DateTime.Now;

    public string Filtro { get; set; }
    private string FiltroFecha { get; set; }

    public string Criterio { get; set; }

    private int TotalRegistros { get; set; }
    private int TotalPaginas { get; set; }

    byte[] Data;
    string pdfContent = "";

    protected override void OnInitialized()
    {
        Nuevo();
    }

    private void Nuevo()
    {
        ListaVentas = new List<Ventas>();
        AuxListaVentas = new List<Ventas>();
        Filtro = "0";
        Criterio = string.Empty;
    }

    public void Consultar(int pag)
    {
        switch (Filtro)
        {
            case "0": //Todo
                ListaVentas = VentasBLL.GetList(c => true);
                break;
            case "1": //ventaId
                if (Criterio.Trim().Length > 0)
                {
                    try
                    {
                        int id = Convert.ToInt32(Criterio);
                        ListaVentas = VentasBLL.GetList(c => c.VentaId == id);
                    }
                    catch (FormatException)
                    {
                        toast.ShowWarning("Ingrese un numero");
                    }
                }
                else
                {
                    ListaVentas = VentasBLL.GetList(c => true).OrderBy(c => c.VentaId).ToList();
                }
                break;
            case "2": //ClienteId
                if (Criterio.Trim().Length > 0)
                {
                    try
                    {
                        int ClienteId = Convert.ToInt32(Criterio);
                        ListaVentas = VentasBLL.GetList(c => c.ClienteId == ClienteId);
                    }
                    catch (FormatException)
                    {
                        toast.ShowWarning("Ingrese un numero");
                    }
                }
                else
                {
                    ListaVentas = VentasBLL.GetList(c => true).OrderBy(c => c.ClienteId).ToList();
                }
                break;

            case "3": //Nombres
                if (Criterio.Trim().Length > 0)
                    ListaVentas = VentasBLL.GetList(c => c.Nombres.Contains(Criterio));
                else
                    ListaVentas = VentasBLL.GetList(c => true).OrderBy(c => c.Nombres).ToList();
                break;
            case "4": //Apellidos
                if (Criterio.Trim().Length > 0)
                    ListaVentas = VentasBLL.GetList(c => c.Apellidos.Contains(Criterio));
                else
                    ListaVentas = VentasBLL.GetList(c => true).OrderBy(c => c.Apellidos).ToList();
                break;
            case "5": //Total
                try
                {
                    decimal Total = Convert.ToDecimal(Criterio);
                    ListaVentas = VentasBLL.GetList(a => a.Total == Total);
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
                ListaVentas = ListaVentas.Where(s => s.Fecha >= Desde && s.Fecha <= Hasta).ToList();
                break;

        }

        TotalPaginas = (int)Math.Ceiling(ListaVentas.Count() / (decimal)pagina.cantidaditems);
        ActualizarLista(pag);

        Filtro = "0";
        FiltroFecha = "0";
    }

    private void ActualizarLista(int NumeroPagina)
    {
        AuxListaVentas = ListaVentas.Skip(NumeroPagina * pagina.cantidaditems).Take(pagina.cantidaditems).ToList();
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
        ReporteVenta Ventas = new ReporteVenta();

        Data = Ventas.Reporte(AuxListaVentas);

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
