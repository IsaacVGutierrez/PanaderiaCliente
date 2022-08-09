using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panaderia.BD.Data.Entidades
{
    [Index(nameof(DNI), Name = "ProveedorDNI_UQ", IsUnique = true)]

    public class Proveedor : EntityBase
    {
        [Required]
        [MaxLength(15, ErrorMessage = "El Nombre no debe superar los 15 caracteres")]
        public string Nombre { get; set; }

        [Required]
        [MaxLength(9, ErrorMessage = "El DNI no debe superar los 9 caracteres")]
        public int DNI { get; set; }

        [Required]
        [MaxLength(30, ErrorMessage = "La Direccion no debe superar los 30 caracteres")]
        public string Direccion { get; set; }

        [Required]
        [MaxLength(12, ErrorMessage = "El Telefono no debe superar los 12 caracteres")]
        public int Telefono { get; set; }



    }
}
