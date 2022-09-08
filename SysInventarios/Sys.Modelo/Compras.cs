using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sys.Modelo
{
    public class Compras
    {
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }
		public int ProveedorId { get; set; }
		public DateTime Fecha { get; set; }
		public string CodigoFactura { get; set; }
		public decimal Total { get; set; }
		public bool Estatus { get; set; }
		public int EmpresaId { get; set; }
		public int UsuarioId { get; set; }

		//se inicializan valores
		public Compras()
		{
			this.Fecha = DateTime.Now;
			this.CodigoFactura = "";
			this.Total = 0;
			this.Estatus = false;
		}
	}
}
