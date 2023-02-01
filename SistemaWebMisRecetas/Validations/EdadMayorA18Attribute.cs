using System;
using System.ComponentModel.DataAnnotations;

namespace SistemaWebMisRecetas.Validations
{
    public class EdadMayorA18Attribute:ValidationAttribute
    {
        public EdadMayorA18Attribute()
        {
            ErrorMessage = "La edad debe ser mayor o igual a 18";
        }
        public override bool IsValid(object value)
        {
            int edad = Convert.ToInt32(value);
            if (edad < 18)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
