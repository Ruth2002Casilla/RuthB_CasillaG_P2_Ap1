using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Biblioteca.Models
{
    public class VehiculoDetalle
    {
        [Key]
        public int VehiculoDetalleId { get; set; }

        [Required(ErrorMessage ="Este campo es Obligatorio")]
        [ForeignKey("Vehiculoid")]
        public int VehiculoId { get; set; }

        [Required(ErrorMessage = "Este campo es Obligatorio")]
        [ForeignKey("AccesorioId")]
        public int AccesorioId { get; set; }

        [Required(ErrorMessage = "Este campo es Obligatorio")]
        [Range(0, double.MaxValue - 1, ErrorMessage = "El monto debe ser mayor o igual a 0.")]
        public double Valor {  get; set; }

		public VehiculoDetalle() { }

		public VehiculoDetalle(int accesorioid, float valor)
		{
			AccesorioId = accesorioid;
			Valor = valor;
		}

		public VehiculoDetalle(int id, int accesorioid, float valor)
		{
			VehiculoDetalleId = id;
			AccesorioId = accesorioid;
			Valor = valor;
		}
	}
}
