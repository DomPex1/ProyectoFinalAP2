#pragma checksum "C:\Users\14012\Desktop\ProyectoFinalPA2\StudioEF\Pages\Registros\R_Eventos.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b0e1190b8450091899a217b5ad953fd1f9f4665e"
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
#line 4 "C:\Users\14012\Desktop\ProyectoFinalPA2\StudioEF\Pages\Registros\R_Eventos.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\14012\Desktop\ProyectoFinalPA2\StudioEF\Pages\Registros\R_Eventos.razor"
using BLL;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/REventos")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/REventosos/{EventoId:int}")]
    public partial class R_Eventos : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 111 "C:\Users\14012\Desktop\ProyectoFinalPA2\StudioEF\Pages\Registros\R_Eventos.razor"
           

        Eventos Evento = new Eventos();

        [Parameter]
        public int EventoId { get; set; }

        private List<Fotografos> Lista = new List<Fotografos>();

        protected override void OnInitialized()
        {
            Nuevo();
        }

        private void Nuevo()
        {
            Evento = new Eventos();
            Lista = FotografosBLL.GetList(f => true);
        }


        private void ObtenerFotografo()
        {
            Lista.Clear();

            Fotografos fotografo = FotografosBLL.Buscar(Evento.FotografoId);
            Lista.Add(fotografo);
        }

        private void Guardar()
        {
            bool guardo;

            guardo = EventosBLL.Guardar(Evento);

            if (guardo)
            {
                Nuevo();
                toast.ShowSuccess("Guardado correctamente");
            }
            else
                toast.ShowError("No fue posible guardar");
        }

        private void Eliminar()
        {
            bool elimino;

            elimino = EventosBLL.Eliminar(Evento.EventoId);

            if (elimino)
            {
                Nuevo();
                toast.ShowSuccess("Eliminado correctamente");
            }
            else
                toast.ShowError("No fue posible eliminar");
        }

        private void Buscar()
        {
            if (Evento.EventoId > 0)
            {
                var encontrado = EventosBLL.Buscar(Evento.EventoId);

                if (encontrado != null)
                    this.Evento = encontrado;
                else
                    toast.ShowWarning("No encontrado");
            }
        }

    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService toast { get; set; }
    }
}
#pragma warning restore 1591
