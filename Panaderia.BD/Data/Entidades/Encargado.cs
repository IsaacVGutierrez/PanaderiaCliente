using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panaderia.BD.Data.Entidades
{
    [Index(nameof(DNI), Name = "EncargadoDNI_UQ", IsUnique = true)]


    public class Encargado : EntityBase
    {
        [Required]
        [MaxLength(15, ErrorMessage = "El Nombre no debe superar los 15 caracteres")]
        public string NombreEncargado { get; set; }

        [Required]
        [MaxLength(20, ErrorMessage = "El Apellido no debe superar los 20 caracteres")]
        public string ApellidoEncargado { get; set; }

        [Required]
        [MaxLength(9, ErrorMessage ="El DNI no debe superar los 9 caracteres" )]
        public int DNI { get; set; }

        [Required]
        [MaxLength(2, ErrorMessage = "La Edad no debe superar los 2 caracteres")]
        public int Edad { get; set; }

        [Required]
        [MaxLength(10, ErrorMessage = "El Puesto no debe superar los 10 caracteres")]
        public string PuestoCargo { get; set; }


        [Required]
        [MaxLength(12, ErrorMessage = "El Telefono no debe superar los 12 caracteres")]
        public int Telefono { get; set; }

        [Required]
        [MaxLength(30, ErrorMessage = "La Direccion no debe superar los 30 caracteres")]
        public string Direccion { get; set; }


        [Required]
        [MaxLength(10, ErrorMessage = "La Fecha no debe superar los 10 caracteres")]
        public DateTime FechaInicio { get; set; }

        public List<Cargo> Cargos { get; set; }

    }
}
