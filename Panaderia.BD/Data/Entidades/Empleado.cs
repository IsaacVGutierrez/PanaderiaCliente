using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panaderia.BD.Data.Entidades
{

    [Index(nameof(DNIEmpleado), Name = "EmpleadoDNI_UQ", IsUnique = true)]


    public class Empleado : EntityBase
    {
        [Required]
        [MaxLength(15, ErrorMessage = "El Nombre no debe superar los 15 caracteres")]
        public string NombreEmpleado { get; set; }

        [Required]
        [MaxLength(20, ErrorMessage = "El Apellido no debe superar los 20 caracteres")]
        public string ApellidoEmpleado { get; set; }

        [Required]
        [MaxLength(9, ErrorMessage = "El DNI no debe superar los 9 caracteres")]
        public int DNIEmpleado { get; set; }

        [Required]
        [MaxLength(2, ErrorMessage = "La Edad no debe superar los 2 caracteres")]
        public int EdadEmpleado { get; set; }

        [Required]
        [MaxLength(10, ErrorMessage = "El Puesto no debe superar los 10 caracteres")]
        public string PuestoCargoEmpleado { get; set; }

        [Required]
        [MaxLength(12, ErrorMessage = "El Telefono no debe superar los 12 caracteres")]
        public int TelefonoEmpleado { get; set; }

        [Required]
        [MaxLength(30, ErrorMessage = "La Direccion no debe superar los 30 caracteres")]
        public string DireccionEmpleado { get; set; }


        [Required]
        [MaxLength(10, ErrorMessage = "La Fecha no debe superar los 10 caracteres")]
        public DateTime FechaContratoEmpleado { get; set; }

        public List<Cargo> Cargos { get; set; }



    }
}
