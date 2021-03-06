#pragma checksum "C:\Users\14012\Desktop\ProyectoFinalPA2\StudioEF\Pages\Registros\R_Compras.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "44455ae019c5ba47678e8a207c2854d29d3591be"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace FEG.Pages.Registros
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
#line 4 "C:\Users\14012\Desktop\ProyectoFinalPA2\StudioEF\Pages\Registros\R_Compras.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\14012\Desktop\ProyectoFinalPA2\StudioEF\Pages\Registros\R_Compras.razor"
using BLL;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/RCompras")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/RCompras/{CompraId:int}")]
    public partial class R_Compras : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 140 "C:\Users\14012\Desktop\ProyectoFinalPA2\StudioEF\Pages\Registros\R_Compras.razor"
       

    Compras Compra = new Compras();
    ComprasDetalle CompraD = new ComprasDetalle();

    [Parameter]
    public int CompraId { get; set; }
    public decimal costo { get; set; }
    public int Cantidad { get; set; }
    public int ArticuloSeleccionado { get; set; }


    private List<Articulos> Lista = new List<Articulos>();

    protected override void OnInitialized()
    {
        Nuevo();


    }

    private string ObtenerDescripcion(int id)
    {
        string Descripcion = null;
        Articulos a = ArticulosBLL.Buscar(id);

        Descripcion = a.Descripcion;
        return Descripcion;
    }

    private void Nuevo()
    {
        Compra = new Compras();
        Cantidad = 0;
        costo = 0;

        Lista = ArticulosBLL.GetList(c => true);
    }



    private void Guardar()
    {
        bool paso;
        paso = ComprasBLL.Guardar(Compra);

        if (paso)
        {
            Nuevo();
            toast.ShowSuccess("Guardado correctamente");
        }
        else
        {
            toast.ShowError("No fue posible guardar");
        }
    }

    private void Agregar()
    {
        if (ArticuloSeleccionado == 0)
        {
            toast.ShowWarning("Tiene que seleccionar un producto.");
            return;
        }

        if (Cantidad <= 0)
        {
            toast.ShowWarning("La cantidad debe ser mayor a 0.");
            return;
        }
        else
        {
            this.Compra.ComprasDetalle.Add(new ComprasDetalle
            {
                ArticuloId = ArticuloSeleccionado,
                Descripcion = ObtenerDescripcion(ArticuloSeleccionado),
                CantidadArticulos = Cantidad,
                Costo = costo
            });

            ComprasBLL.ObtenerCantidad(Compra);
            ComprasBLL.ObtenerCosto(Compra);

            ArticuloSeleccionado = 0;
            costo = 0;
            Cantidad = 0;

        }
        CalcularMonto();

    }

    private void Eliminar()
    {
        bool elimino;

        ComprasBLL.BorrarCantidad(Compra);
        ComprasBLL.BorrarCosto(Compra);
        elimino = ComprasBLL.Eliminar(Compra.CompraId);

        if (elimino)
        {
            Nuevo();
            toast.ShowSuccess("Eliminado correctamente");
        }
        else
            toast.ShowError("No fue posible eliminar");
    }




    private void CalcularMonto()
    {
        decimal total = 0;
        foreach (var item in Compra.ComprasDetalle)
        {
            total += (item.Costo * item.CantidadArticulos);
        }
        Compra.Monto = total;
    }

    private void EliminarDetalle(ComprasDetalle detalle)
    {
        try
        {
            ComprasBLL.BorrarCantidad(Compra);
            ComprasBLL.BorrarCosto(Compra);
            Compra.ComprasDetalle.Remove(detalle);
            CalcularMonto();
        }
        catch (Exception)
        {

            throw;
        }
    }


    private void Buscar()
    {
        var encontrado = ComprasBLL.Buscar(Compra.CompraId);
        if (encontrado != null)
        {
            this.Compra = encontrado;
        }
        else
            toast.ShowWarning("No encontrado");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService toast { get; set; }
    }
}
#pragma warning restore 1591
