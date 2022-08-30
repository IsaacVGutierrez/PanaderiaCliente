
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panaderia.BD.Data.Entidades
{
    [Index(nameof(CodigoVenta), Name = "CodigoProducVenta_UQ", IsUnique = true)]
    public class Venta : EntityBase
    {


        [Required]
        [MaxLength(30, ErrorMessage = "El Codigo no debe superar los 30 caracteres")]
        public int CodigoVenta { get; set; }


        [Required]
        [MaxLength(10, ErrorMessage = "La Cantidad Productos no debe superar los 10 caracteres")]
        public int CantidadVenta { get; set; }

        [Required]
        [MaxLength(10, ErrorMessage = "La Fecha no debe superar los 10 caracteres")]
        public DateTime FechaVenta { get; set; }


        [MaxLength(10, ErrorMessage = "Las Cuotas de Venta no debe superar los 10 caracteres")]
        public int CuotasVenta { get; set; }

        [MaxLength(10, ErrorMessage = "El interes de venta no debe superar los 10 caracteres")]
        public int InteresVenta { get; set; }

        [Required]
        [MaxLength(10, ErrorMessage = "El Precio de Venta no debe superar los 15 caracteres")]
        public int PrecioVenta { get; set; }

    

        [Required(ErrorMessage = "El Empleado es obligatorio")]
        public int EmpleadoId { get; set; }
        public Empleado Empleados { get; set; }


        public List<Producto> Productos { get; set; } 
        



    }
}
