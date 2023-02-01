using SistemaWebMisRecetas.Validations;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaWebMisRecetas.Models
{
    public class Receta
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        [Required(ErrorMessage = "La categoria es obligatoria.")]
        [CategoriadesayunoAttribute]
        public string Categoria { get; set; }
        [Required(ErrorMessage = "Los ingredientes son obligatorios.")]
        [DataType(DataType.MultilineText)]
        public string Ingredientes { get; set; }
        [Required(ErrorMessage = "Las instrucciones son obligatorios.")]
        [DataType(DataType.MultilineText)]
        public string Instrucciones { get; set; }
        [Required(ErrorMessage = "El autor es obligatorio.")]
        public string Autor { get; set; }
        [Required(ErrorMessage = "El apellido es obligatorio.")]
        public string Apellido { get; set; }
        [EdadMayorA18Attribute]
        public int Edad { get; set; }
        [Required(ErrorMessage = "El email es obligatorio.")]
        [EmailAddressAttribute(ErrorMessage ="No es un email valido.")]
        public string Email { get; set; }
    }
}
