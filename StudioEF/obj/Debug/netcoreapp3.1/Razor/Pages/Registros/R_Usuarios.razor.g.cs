#pragma checksum "C:\Users\14012\Desktop\ProyectoFinalPA2\StudioEF\Pages\Registros\R_Usuarios.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "59e276372c32734be268e2096b6a83d93ada073b"
// <auto-generated/>
#pragma warning disable 1591
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
#line 4 "C:\Users\14012\Desktop\ProyectoFinalPA2\StudioEF\Pages\Registros\R_Usuarios.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\14012\Desktop\ProyectoFinalPA2\StudioEF\Pages\Registros\R_Usuarios.razor"
using BLL;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\14012\Desktop\ProyectoFinalPA2\StudioEF\Pages\Registros\R_Usuarios.razor"
using System.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\14012\Desktop\ProyectoFinalPA2\StudioEF\Pages\Registros\R_Usuarios.razor"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/RUsuarios")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/RUsuarios/{UsuarioId:int}")]
    public partial class R_Usuarios : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(2, "\n        ");
                __builder2.AddMarkupContent(3, "<p class=\"h4 text-center\">Usted no esta autorizado para acceder a esta pagina</p>\n\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(4, "\n\n");
#nullable restore
#line 19 "C:\Users\14012\Desktop\ProyectoFinalPA2\StudioEF\Pages\Registros\R_Usuarios.razor"
 if (AuthenticationStateProvider.GetAuthenticationStateAsync().Result.User.Identity.IsAuthenticated)
{


#line default
#line hidden
#nullable disable
            __builder.AddContent(5, "    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(6);
            __builder.AddAttribute(7, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 22 "C:\Users\14012\Desktop\ProyectoFinalPA2\StudioEF\Pages\Registros\R_Usuarios.razor"
                     Usuario

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 22 "C:\Users\14012\Desktop\ProyectoFinalPA2\StudioEF\Pages\Registros\R_Usuarios.razor"
                                             Guardar

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(9, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(10, "\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(11);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(12, "\n        ");
                __builder2.OpenElement(13, "div");
                __builder2.AddAttribute(14, "class", "card-img");
                __builder2.AddMarkupContent(15, "\n            ");
                __builder2.AddMarkupContent(16, "<div class=\"card-header bg-dark\">\n                <h3>Registro de Usuarios</h3>\n            </div>\n            ");
                __builder2.OpenElement(17, "div");
                __builder2.AddAttribute(18, "class", "card-body");
                __builder2.AddMarkupContent(19, "\n                ");
                __builder2.OpenElement(20, "form");
                __builder2.AddMarkupContent(21, "\n\n                    ");
                __builder2.OpenElement(22, "div");
                __builder2.AddAttribute(23, "class", "form-row align-items-center");
                __builder2.AddMarkupContent(24, "\n                        ");
                __builder2.OpenElement(25, "div");
                __builder2.AddAttribute(26, "class", "col");
                __builder2.AddMarkupContent(27, "\n                            ");
                __builder2.OpenElement(28, "div");
                __builder2.AddAttribute(29, "class", "form-group");
                __builder2.AddMarkupContent(30, "\n                                ");
                __builder2.AddMarkupContent(31, "<label>UsuarioId</label>\n                                ");
                __builder2.OpenElement(32, "div");
                __builder2.AddAttribute(33, "class", "input-group");
                __builder2.AddMarkupContent(34, "\n                                    ");
                __Blazor.FEG.Pages.Registros.R_Usuarios.TypeInference.CreateInputNumber_0(__builder2, 35, 36, "form-control col-4", 37, 
#nullable restore
#line 37 "C:\Users\14012\Desktop\ProyectoFinalPA2\StudioEF\Pages\Registros\R_Usuarios.razor"
                                                              Usuario.UsuarioId

#line default
#line hidden
#nullable disable
                , 38, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Usuario.UsuarioId = __value, Usuario.UsuarioId)), 39, () => Usuario.UsuarioId);
                __builder2.AddMarkupContent(40, "\n                                    ");
                __builder2.OpenElement(41, "div");
                __builder2.AddAttribute(42, "class", "input-group-append");
                __builder2.AddMarkupContent(43, "\n                                        ");
                __builder2.OpenElement(44, "button");
                __builder2.AddAttribute(45, "type", "button");
                __builder2.AddAttribute(46, "class", "btn btn-primary input-group-text");
                __builder2.AddAttribute(47, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 39 "C:\Users\14012\Desktop\ProyectoFinalPA2\StudioEF\Pages\Registros\R_Usuarios.razor"
                                                                                                                 Buscar

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(48, "<i class=\"oi oi-magnifying-glass\"></i>Buscar");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(49, "\n                                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(50, "\n                                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(51, "\n                                ");
                __Blazor.FEG.Pages.Registros.R_Usuarios.TypeInference.CreateValidationMessage_1(__builder2, 52, 53, 
#nullable restore
#line 42 "C:\Users\14012\Desktop\ProyectoFinalPA2\StudioEF\Pages\Registros\R_Usuarios.razor"
                                                          () => Usuario.UsuarioId

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(54, "\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(55, "\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(56, "\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(57, "\n\n                \n                    ");
                __builder2.OpenElement(58, "div");
                __builder2.AddAttribute(59, "class", "form-group");
                __builder2.AddMarkupContent(60, "\n                        ");
                __builder2.AddMarkupContent(61, "<label>Nombres</label>\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(62);
                __builder2.AddAttribute(63, "class", "form-control");
                __builder2.AddAttribute(64, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 51 "C:\Users\14012\Desktop\ProyectoFinalPA2\StudioEF\Pages\Registros\R_Usuarios.razor"
                                                Usuario.Nombres

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(65, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Usuario.Nombres = __value, Usuario.Nombres))));
                __builder2.AddAttribute(66, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Usuario.Nombres));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(67, "\n                        ");
                __Blazor.FEG.Pages.Registros.R_Usuarios.TypeInference.CreateValidationMessage_2(__builder2, 68, 69, 
#nullable restore
#line 52 "C:\Users\14012\Desktop\ProyectoFinalPA2\StudioEF\Pages\Registros\R_Usuarios.razor"
                                                  () => Usuario.Nombres

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(70, "\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(71, "\n\n                    ");
                __builder2.OpenElement(72, "div");
                __builder2.AddAttribute(73, "class", "form-group");
                __builder2.AddMarkupContent(74, "\n                        ");
                __builder2.AddMarkupContent(75, "<label>Nombre Usuario</label>\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(76);
                __builder2.AddAttribute(77, "class", "form-control");
                __builder2.AddAttribute(78, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 58 "C:\Users\14012\Desktop\ProyectoFinalPA2\StudioEF\Pages\Registros\R_Usuarios.razor"
                                                Usuario.NombreUsuario

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(79, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Usuario.NombreUsuario = __value, Usuario.NombreUsuario))));
                __builder2.AddAttribute(80, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Usuario.NombreUsuario));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(81, "\n                        ");
                __Blazor.FEG.Pages.Registros.R_Usuarios.TypeInference.CreateValidationMessage_3(__builder2, 82, 83, 
#nullable restore
#line 59 "C:\Users\14012\Desktop\ProyectoFinalPA2\StudioEF\Pages\Registros\R_Usuarios.razor"
                                                  () => Usuario.NombreUsuario

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(84, "\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(85, "\n\n                    ");
                __builder2.OpenElement(86, "div");
                __builder2.AddAttribute(87, "class", "form-group");
                __builder2.AddMarkupContent(88, "\n                        ");
                __builder2.AddMarkupContent(89, "<label>Contraseña</label>\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(90);
                __builder2.AddAttribute(91, "type", "password");
                __builder2.AddAttribute(92, "class", "form-control");
                __builder2.AddAttribute(93, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 65 "C:\Users\14012\Desktop\ProyectoFinalPA2\StudioEF\Pages\Registros\R_Usuarios.razor"
                                                                Usuario.Contrasena

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(94, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Usuario.Contrasena = __value, Usuario.Contrasena))));
                __builder2.AddAttribute(95, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Usuario.Contrasena));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(96, "\n                        ");
                __Blazor.FEG.Pages.Registros.R_Usuarios.TypeInference.CreateValidationMessage_4(__builder2, 97, 98, 
#nullable restore
#line 66 "C:\Users\14012\Desktop\ProyectoFinalPA2\StudioEF\Pages\Registros\R_Usuarios.razor"
                                                  () => Usuario.Contrasena

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(99, "\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(100, "\n\n                    ");
                __builder2.OpenElement(101, "div");
                __builder2.AddAttribute(102, "class", "form-group");
                __builder2.AddMarkupContent(103, "\n                        ");
                __builder2.AddMarkupContent(104, "<label>Email</label>\n                        ");
                __builder2.OpenElement(105, "div");
                __builder2.AddAttribute(106, "class", "row");
                __builder2.AddMarkupContent(107, "\n                            ");
                __builder2.OpenElement(108, "div");
                __builder2.AddAttribute(109, "class", "col");
                __builder2.AddMarkupContent(110, "\n                                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(111);
                __builder2.AddAttribute(112, "class", "form-control");
                __builder2.AddAttribute(113, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 74 "C:\Users\14012\Desktop\ProyectoFinalPA2\StudioEF\Pages\Registros\R_Usuarios.razor"
                                                        Usuario.Email

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(114, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Usuario.Email = __value, Usuario.Email))));
                __builder2.AddAttribute(115, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Usuario.Email));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(116, "\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(117, "\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(118, "\n                        ");
                __Blazor.FEG.Pages.Registros.R_Usuarios.TypeInference.CreateValidationMessage_5(__builder2, 119, 120, 
#nullable restore
#line 77 "C:\Users\14012\Desktop\ProyectoFinalPA2\StudioEF\Pages\Registros\R_Usuarios.razor"
                                                  () => Usuario.Email

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(121, "\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(122, "\n\n                  \n\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(123, "\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(124, "\n            ");
                __builder2.OpenElement(125, "div");
                __builder2.AddAttribute(126, "class", "card-footer");
                __builder2.AddMarkupContent(127, "\n                ");
                __builder2.OpenElement(128, "div");
                __builder2.AddAttribute(129, "class", "form-group text-center");
                __builder2.AddAttribute(130, "display:", true);
                __builder2.AddAttribute(131, "inline-block", true);
                __builder2.AddMarkupContent(132, "\n                    ");
                __builder2.OpenElement(133, "button");
                __builder2.AddAttribute(134, "type", "button");
                __builder2.AddAttribute(135, "class", "btn btn-lg btn-primary");
                __builder2.AddAttribute(136, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 86 "C:\Users\14012\Desktop\ProyectoFinalPA2\StudioEF\Pages\Registros\R_Usuarios.razor"
                                                                                   Nuevo

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(137, "<i class=\"oi oi-plus\"></i>Nuevo");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(138, "\n                    ");
                __builder2.AddMarkupContent(139, "<button type=\"submit\" class=\"btn btn-lg btn-success\"><i class=\"oi oi-hard-drive\"></i>Guardar</button>\n                    ");
                __builder2.OpenElement(140, "button");
                __builder2.AddAttribute(141, "type", "button");
                __builder2.AddAttribute(142, "class", "btn btn-lg btn-danger");
                __builder2.AddAttribute(143, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 88 "C:\Users\14012\Desktop\ProyectoFinalPA2\StudioEF\Pages\Registros\R_Usuarios.razor"
                                                                                  Eliminar

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(144, "<i class=\"oi oi-trash\"></i>Eliminar");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(145, "\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(146, "\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(147, "\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(148, "\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(149, "\n");
#nullable restore
#line 93 "C:\Users\14012\Desktop\ProyectoFinalPA2\StudioEF\Pages\Registros\R_Usuarios.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 95 "C:\Users\14012\Desktop\ProyectoFinalPA2\StudioEF\Pages\Registros\R_Usuarios.razor"
       
    [Parameter]
    public int UsuarioId { get; set; }

    [CascadingParameter]
    private Task<AuthenticationState> authState { get; set; }

    private Usuarios Usuario = new Usuarios();

    public string nombreUsuarioCreacion { get; set; } = "";
    public string usuarioIdCreacion { get; set; } = "";

    protected override void OnInitialized()
    {
        Nuevo();
        BuscarParametro();
    }

    public void Nuevo()
    {
        Usuario = new Usuarios();

        ReiniciarUsuarioCreacion();
    }

    private async void ReiniciarUsuarioCreacion()
    {
        nombreUsuarioCreacion = (await authState).User.Identity.Name;

        usuarioIdCreacion = (await authState).User.Claims
            .Where(c => c.Type == ClaimTypes.NameIdentifier)
            .Select(c => c.Value).FirstOrDefault();
    }

    private void BuscarParametro()
    {
        if (UsuarioId > 0)
        {
            var encontrado = UsuariosBLL.Buscar(UsuarioId);

            if (encontrado != null)
                this.Usuario = encontrado;
            else
                toast.ShowWarning("No encontrado");
        }
    }


    private void Buscar()
    {
        if (Usuario.UsuarioId > 0)
        {
            var encontrado = UsuariosBLL.Buscar(Usuario.UsuarioId);

            if (encontrado != null)
            {
                this.Usuario = encontrado;
             
            }
            else
                toast.ShowWarning("No encontrado");
        }
    }


    public void Guardar()
    {
        bool guardo;

        if (UsuariosBLL.ExisteUsuario(Usuario.NombreUsuario, Usuario.Contrasena) && Usuario.UsuarioId == 0)
        {
            toast.ShowInfo("Usuario existente");
            return;
        }


        guardo = UsuariosBLL.Guardar(Usuario);

        if (guardo)
        {
            Nuevo();
            toast.ShowSuccess("Guardado correctamente");
        }
        else
            toast.ShowError("No fue posible guardar");
    }

    public void Eliminar()
    {
        bool elimino;

        if (Usuario.UsuarioId == Convert.ToInt32(usuarioIdCreacion))
        {
            toast.ShowInfo("No se puede eliminar a si mismo");
            return;
        }

        elimino = UsuariosBLL.Eliminar(Usuario.UsuarioId);

        if (elimino)
        {
            Nuevo();
            toast.ShowSuccess("Eliminado correctamente");
        }
        else
            toast.ShowError("No fue posible eliminar");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService toast { get; set; }
    }
}
namespace __Blazor.FEG.Pages.Registros.R_Usuarios
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputNumber_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_5<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591