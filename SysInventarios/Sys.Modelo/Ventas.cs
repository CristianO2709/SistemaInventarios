using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sys.Modelo
{
    public class Ventas
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public int ContactoId { get; set; }
        public string CodigoFactura { get; set; }
        public decimal Total { get; set; }
        public bool Estatus { get; set; }
        public int EmpresaId { get; set; }
        public int UsuarioId { get; set; }

        //se inicializan valores
        public Ventas()
        {
            this.Fecha = DateTime.Now;
            this.CodigoFactura = "";
            this.Total = 0;
            this.Estatus = false;
        }
    }
}
