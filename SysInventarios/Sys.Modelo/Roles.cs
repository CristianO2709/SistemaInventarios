using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sys.Modelo
{
    public class Roles
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Rol { get; set; }
        public bool Activo { get; set; }
        public DateTime Fecha { get; set; }

        //se inicializan valores
        public Roles()
        {
            this.Rol = "";
            this.Activo = false;
            this.Fecha = DateTime.Now;
        }
    }
}
