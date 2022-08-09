
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panaderia.BD.Data.Entidades
{
    [Index(nameof(CodigoProduc), Name = "CodigoProducVenta_UQ", IsUnique = true)]
    public class Venta : EntityBase
    {
        [Required]
        [MaxLength(30, ErrorMessage = "El Nombre Producto no debe superar los 30 caracteres")]
        public string NombreProduc { get; set; }


        [Required]
        [MaxLength(30, ErrorMessage = "El Codigo no debe superar los 30 caracteres")]
        public int CodigoProduc { get; set; }

        [Required]
        [MaxLength(10, ErrorMessage = "El Precio no debe superar los 10 caracteres")]
        public int PrecioProduc { get; set; }

        [Required]
        [MaxLength(10, ErrorMessage = "La Cantidad Productos no debe superar los 10 caracteres")]
        public int CantidadProduc { get; set; }

        [Required]
        [MaxLength(10, ErrorMessage = "La Fecha no debe superar los 10 caracteres")]
        public DateTime FechaVenta { get; set; }



        [Required(ErrorMessage = "El Producto es obligatorio")]
        public int ProductoId { get; set; }
        public Empleado Producto { get; set; }


        public List<Producto> Productos { get; set; }
        public List<Empleado> Empleados { get; set; }



    }
}
