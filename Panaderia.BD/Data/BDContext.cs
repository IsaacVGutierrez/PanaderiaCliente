using Microsoft.EntityFrameworkCore;
using Panaderia.BD.Data.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panaderia.BD.Data
{

    /// <summary>
    /// representacion de la base de datos
    /// </summary>


    public class BDContext : DbContext
    {

        public DbSet<Empleado> Empleados { get; set; }

        public DbSet<Producto> Productos { get; set; }

        public DbSet<Encargado> Encargados { get; set; }

        public DbSet<Proveedor> Proveedores { get; set; }

        public DbSet<Venta> Ventas { get; set; }

        public DbSet<Cargo> Cargos { get; set; }


        public BDContext(DbContextOptions options) : base(options)
        {


        }
    }
}
