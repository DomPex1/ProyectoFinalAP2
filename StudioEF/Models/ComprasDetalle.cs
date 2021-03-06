﻿using FEG.Validaciones;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FEG.Models
{
    public class ComprasDetalle
    {
        [Key]
        [ValidacionId]
        public int ComprasDetalleId { get; set; }

        [Required(ErrorMessage = "Este campo no puede estar vacio.")]
        public int CompraId { get; set; }

        [Required(ErrorMessage = "Este campo no puede estar vacio.")]
        [Range(minimum: 1, maximum: 200000000, ErrorMessage = "Este  campo debe poseer un rango mayor a 0.")]
        public int ArticuloId { get; set; }

        [Required(ErrorMessage = "Este campo no puede estar vacio.")]
        [MinLength(5, ErrorMessage = "Este campo no puede contener menos de 5 caracteres.")]
        [MaxLength(40, ErrorMessage = "Ha alcanzado el maximo de caracteres.")]
        public string Descripcion { get; set; }

        [CantidadValidacion]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public int CantidadArticulos { get; set; }

        [ValidacionPrecio]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal Costo { get; set; }

     


        public ComprasDetalle()
        {
            ComprasDetalleId = 0;
            CompraId = 0;
            ArticuloId = 0;
            CantidadArticulos = 0;
            Costo = 0.0m;
        }

        public ComprasDetalle(int comprasId,int articulosId, int cantidadArticulos, decimal costo)
        {
            ComprasDetalleId = 0;
            CompraId = comprasId;
            ArticuloId = articulosId;
            CantidadArticulos = cantidadArticulos;
            Costo = costo;
            
        }
    }
}
