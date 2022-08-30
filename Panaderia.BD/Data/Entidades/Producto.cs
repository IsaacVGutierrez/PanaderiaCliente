using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panaderia.BD.Data.Entidades
{

    [Index(nameof(CodigoProduc), Name = "ProductoCodigo_UQ", IsUnique = true)]


    public class Producto : EntityBase
    {
        [Required]
        [MaxLength(30, ErrorMessage = "El Nombre no debe superar los 30 caracteres")]
        public string NombreProduc { get; set; }

        [Required]
        [MaxLength(10, ErrorMessage = "El Precio no debe superar los 10 caracteres")]
        public int PrecioProduc { get; set; }

        [Required]
        [MaxLength(30, ErrorMessage = "El Codigo no debe superar los 30 caracteres")]
        public int CodigoProduc{ get; set; }

        [Required]
        [MaxLength(10, ErrorMessage = "La Fecha no debe superar los 10 caracteres")]
        public DateTime FechaVencimientoProduc { get; set; }

        [Required]
        [MaxLength(10, ErrorMessage = "La Cantidad de Productos no debe superar los 10 caracteres")]
        public int CantidadProduc { get; set; }

        public List<Proveedor> Proveedores { get; set; }






    }


}
