using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panaderia.BD.Data.Entidades
{
    [Index(nameof(DNIProved), Name = "ProveedorDNI_UQ", IsUnique = true)]

    public class Proveedor : EntityBase
    {
        [Required]
        [MaxLength(15, ErrorMessage = "El Nombre no debe superar los 15 caracteres")]
        public string NombreProved { get; set; }

        [Required]
        [MaxLength(9, ErrorMessage = "El DNI no debe superar los 9 caracteres")]
        public int DNIProved { get; set; }

        [Required]
        [MaxLength(30, ErrorMessage = "La Direccion no debe superar los 30 caracteres")]
        public string DireccionProved { get; set; }

        [Required]
        [MaxLength(12, ErrorMessage = "El Telefono no debe superar los 12 caracteres")]
        public int TelefonoProved { get; set; }

        [Required]
        [MaxLength(10, ErrorMessage = "La Fecha no debe superar los 10 caracteres")]
        public DateTime FechaEntregaProved { get; set; }


        [Required(ErrorMessage = "El Encargado es obligatorio")]
        public int EncargadoId { get; set; }

        public Encargado Encargado { get; set; }

     


    }
}
