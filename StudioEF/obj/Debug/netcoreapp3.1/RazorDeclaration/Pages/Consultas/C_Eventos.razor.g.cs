#pragma checksum "C:\Users\14012\Desktop\ProyectoFinalPA2\StudioEF\Pages\Consultas\C_Eventos.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e5d34e8a219be0ed8bed45cf7e96b8486c499824"
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
#line 3 "C:\Users\14012\Desktop\ProyectoFinalPA2\StudioEF\Pages\Consultas\C_Eventos.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\14012\Desktop\ProyectoFinalPA2\StudioEF\Pages\Consultas\C_Eventos.razor"
using BLL;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\14012\Desktop\ProyectoFinalPA2\StudioEF\Pages\Consultas\C_Eventos.razor"
using Reportes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\14012\Desktop\ProyectoFinalPA2\StudioEF\Pages\Consultas\C_Eventos.razor"
using Paginacion;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/C_Eventos")]
    public partial class C_Eventos : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 131 "C:\Users\14012\Desktop\ProyectoFinalPA2\StudioEF\Pages\Consultas\C_Eventos.razor"
       
    public List<Eventos> ListaEventos { get; set; }
    public List<Eventos> AuxListaEventos { get; set; }

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
        ListaEventos = new List<Eventos>();
        AuxListaEventos = new List<Eventos>();
        Filtro = "0";
        Criterio = string.Empty;
    }

    public void Consultar(int pag)
    {
        switch (Filtro)
        {
            case "0": //Todo
                ListaEventos = EventosBLL.GetList(c => true);
                break;
            case "1": //ClienteId
                if (Criterio.Trim().Length > 0)
                {
                    try
                    {
                        int id = Convert.ToInt32(Criterio);
                        ListaEventos = EventosBLL.GetList(a => a.EventoId == id);
                    }
                    catch (FormatException)
                    {
                        toast.ShowWarning("Ingrese un numero");
                    }
                }
                else
                {
                    ListaEventos = EventosBLL.GetList(c => true).OrderBy(c => c.EventoId).ToList();
                }
                break;
            case "2": //UsuarioId
                if (Criterio.Trim().Length > 0)
                {
                    try
                    {
                        int usuarioId = Convert.ToInt32(Criterio);
                        ListaEventos = EventosBLL.GetList(c => c.UsuarioId == usuarioId);
                    }
                    catch (FormatException)
                    {
                        toast.ShowWarning("Ingrese un numero");
                    }
                }
                else
                {
                    ListaEventos = EventosBLL.GetList(c => true).OrderBy(c => c.UsuarioId).ToList();
                }
                break;

            case "3": //FotografoId
                if (Criterio.Trim().Length > 0)
                {
                    try
                    {
                        int FotografoId = Convert.ToInt32(Criterio);
                        ListaEventos = EventosBLL.GetList(c => c.FotografoId == FotografoId);
                    }
                    catch (FormatException)
                    {
                        toast.ShowWarning("Ingrese un numero");
                    }
                }
                else
                {
                    ListaEventos = EventosBLL.GetList(c => true).OrderBy(c => c.FotografoId).ToList();
                }
                break;
            case "4": //Descripcion
                if (Criterio.Trim().Length > 0)
                    ListaEventos = EventosBLL.GetList(c => c.Descripcion.Contains(Criterio));
                else
                    ListaEventos = EventosBLL.GetList(c => true).OrderBy(c => c.Descripcion).ToList();
                break;
            case "5": //Lugar
                if (Criterio.Trim().Length > 0)
                    ListaEventos = EventosBLL.GetList(c => c.Lugar.Contains(Criterio));
                else
                    ListaEventos = EventosBLL.GetList(c => true).OrderBy(c => c.Lugar).ToList();
                break;
            case "6": //Precio
                try
                {
                    decimal Precio = Convert.ToDecimal(Criterio);
                    ListaEventos = EventosBLL.GetList(a => a.Precio == Precio);
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
                ListaEventos = ListaEventos.Where(s => s.FechaInicio >= Desde && s.FechaFin <= Hasta).ToList();
                break;

        }

        TotalPaginas = (int)Math.Ceiling(ListaEventos.Count() / (decimal)pagina.cantidaditems);
        ActualizarLista(pag);

        Filtro = "0";

    }

    private void ActualizarLista(int NumeroPagina)
    {
        AuxListaEventos = ListaEventos.Skip(NumeroPagina * pagina.cantidaditems).Take(pagina.cantidaditems).ToList();
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
        ReporteEvento evento = new ReporteEvento();

        Data = evento.Reporte(AuxListaEventos);

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