using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sys.Modelo
{
    public class RolPermiso
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Accion { get; set; }
        public int RolId { get; set; }
        public bool Activo { get; set; }
        public DateTime Fecha { get; set; }

        [ForeignKey("RoId")]
        public virtual Roles Roles { get; set; }

        //se inicializan valores
        public RolPermiso()
        {
            this.Accion = "";
            this.Activo = false;
            this.Fecha = DateTime.Now;
            this.Roles = new Roles();
        }
    }
}
