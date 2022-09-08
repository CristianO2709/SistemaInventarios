using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sys.Modelo
{
    public class Usuarios
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }
        public int RolId { get; set; }
        public string Password { get; set; }
        public bool Estatus { get; set; }
        public int? UsuarioPadreId { get; set; }

        [ForeignKey("RoId")]
        public virtual Roles Roles { get; set; }

        //se inicializan valores
        public Usuarios()
        {
            this.Nombre = "";
            this.Email = "";
            this.Password = "";
            this.Estatus = false;
            this.Roles = new Roles();
        }
    }
}
