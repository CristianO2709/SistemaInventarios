using Microsoft.EntityFrameworkCore;
using Sys.Modelo;

namespace SysInventarios.DataContext
{
    public class InventariosDbContext : DbContext
    {
        public InventariosDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Almacenes> Almacenes { get; set; }
        public DbSet<Compra_Productos> Compra_Productos { get; set; }
        public DbSet<Compras> Compras { get; set; }
        public DbSet<Contactos> Contactos { get; set; }
        public DbSet<Empresas> Empresas { get; set; }
        public DbSet<Productos> Productos { get; set; }
        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<Venta_Productos> Venta_Productos { get; set; }
        public DbSet<Ventas> Ventas { get; set; }
        public DbSet<Roles> Roles { get; set; }
        public DbSet<RolPermiso> RolPermiso { get; set; }
        //public DbSet<Tokens> Tokens { get; set; }

    }
}
