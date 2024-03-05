using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Models
{
    public class Vehiculo
    {
        [Key]
        public int VehiculoId { get; set; }

        [Required(ErrorMessage = "Este campo es Obligatorio")]
        [DataType(DataType.Date)]
        public DateTime Fecha { get; set; } = DateTime.Now;


        [Required(ErrorMessage = "Este campo es Obligatorio")]
        [RegularExpression(@"^[A-ZÁÉÍÓÚÑ][a-zA-ZÁÉÍÓÚÑ\s]*$", ErrorMessage = "La Descripción debe comenzar con una letra mayúscula y puede contener letras, espacios y acentos.")]
        public string? Descripcion { get; set; }

        [Required(ErrorMessage = "Este campo es Obligatorio")]
        [Range(1.00, double.MaxValue, ErrorMessage = "El Monto debe ser mayor que 0.")]
        public double Costo { get; set; }
        public double Gasto { get; set; }
    }
}
