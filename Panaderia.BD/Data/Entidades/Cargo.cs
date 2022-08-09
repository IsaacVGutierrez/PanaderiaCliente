using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panaderia.BD.Data.Entidades
{

    [Index(nameof(EmpleadoId), nameof(Id) ,Name = "EmpleadoCargoId_UQ", IsUnique = true)]

    [Index(nameof(EncargadoId), nameof(Id), Name = "EncargadoCargoId_UQ", IsUnique = true)]

    public class Cargo : EntityBase
    {

       [Required ( ErrorMessage = "El Nombre de Cargo es obligatorio")]
        [MaxLength(20, ErrorMessage = "El Nombre Cargo no debe superar los 20 caracteres")]
        public string NombrCargo { get; set; }


        [Required(ErrorMessage = "El Empleado es obligatorio")]
        public int EmpleadoId { get; set; }
        public Empleado Empleado { get; set; }



        [Required(ErrorMessage = "El Encargado es obligatorio")]
        public int EncargadoId { get; set; }
        public Encargado Encargado { get; set; }

             
    }
}
