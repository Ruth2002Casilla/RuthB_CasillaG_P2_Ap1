using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace Biblioteca.Models
{
    public class Accesorios
    {
        [Key]
        public int AccesorioId { get; set; }

        [Required(ErrorMessage = "Este campo es Obligatorio")]
        [RegularExpression(@"^[A-ZÁÉÍÓÚÑ][a-zA-ZÁÉÍÓÚÑ\s]*$", ErrorMessage = "La Descripción debe comenzar con una letra mayúscula y puede contener letras, espacios y acentos.")]
        public string? Descripcion { get; set; }
    }
}
