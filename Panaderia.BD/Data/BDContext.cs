using Microsoft.EntityFrameworkCore;
using Panaderia.BD.Data.Entidades;

namespace Panaderia.BD.Data
{
    public class Bdcontext : DbContext
    {
        public Bdcontext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Cargo> Cargos { get; set; }

        public DbSet<Empleado> Empleados { get; set; }

        public DbSet<Encargado> Encargados { get; set; }

        public DbSet<Producto> Productos { get; set; }

        public DbSet<Proveedor> Proveedores { get; set; }

        public DbSet<Venta> Ventas { get; set; }

    }
}