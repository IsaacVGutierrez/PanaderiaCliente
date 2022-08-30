using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panaderia.BD.Data.Entidades
{

    
    public class Cargo : EntityBase
    {

       [Required ( ErrorMessage = "El Nombre de Cargo es obligatorio")]
        [MaxLength(20, ErrorMessage = "El Nombre Cargo no debe superar los 20 caracteres")]
        public string NombreCargo { get; set; }

           
        public List<Empleado> Empleados { get; set; }

    }
}
