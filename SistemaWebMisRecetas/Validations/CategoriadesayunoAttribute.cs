using System;
using System.ComponentModel.DataAnnotations;

namespace SistemaWebMisRecetas.Validations
{
    public class CategoriadesayunoAttribute: ValidationAttribute
    {
        public CategoriadesayunoAttribute()
        {
            ErrorMessage = "La categoria tiene que ser desayuno";
        }
        public override bool IsValid(object value)
        {
            string desayuno = Convert.ToString(value);
            if (desayuno == "desayuno")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
