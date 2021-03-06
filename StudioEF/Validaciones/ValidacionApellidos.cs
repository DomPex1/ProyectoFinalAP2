﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FEG.Validaciones
{
    public class ValidacionApellidos : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            string cadena = value as string;

            if (!string.IsNullOrWhiteSpace(cadena))
            {
                if (cadena.Length <= 0)
                    return new ValidationResult("Debes poner un apellido");

                foreach (var caracter in cadena)
                {
                    if (!char.IsLetter(caracter) && !char.IsWhiteSpace(caracter))
                        return new ValidationResult("El apellido solo puede tener letras");
                }
                return ValidationResult.Success;
            }
            return new ValidationResult("Debes poner un apellido");
        }
    }

    
}
