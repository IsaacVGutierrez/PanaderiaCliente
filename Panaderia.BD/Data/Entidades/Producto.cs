using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panaderia.BD.Data.Entidades
{

    [Index( nameof (Codigo) , Name ="ProductoCodigo_UQ" , IsUnique = true) ]


    public class Producto : EntityBase
    {
        [Required]
        [MaxLength(30, ErrorMessage = "El Nombre no debe superar los 30 caracteres")]
        public string Nombre { get; set; }

        [Required]
        [MaxLength(10, ErrorMessage = "El Precio no debe superar los 10 caracteres")]
        public int Precio { get; set; }

        [Required]
        [MaxLength(30, ErrorMessage = "El Codigo no debe superar los 30 caracteres")]
        public int Codigo { get; set; }

        [Required]
        [MaxLength(10, ErrorMessage = "La Fecha no debe superar los 10 caracteres")]
        public DateTime FechaVencimiento { get; set; }

        public List<Proveedor> Proveedores { get; set; }






    }


}
