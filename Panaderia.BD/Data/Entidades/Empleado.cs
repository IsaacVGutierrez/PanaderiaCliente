using System.ComponentModel.DataAnnotations;

namespace Panaderia.BD.Data.Entidades
{

    //[Index(nameof(DNIEmpleado), Name = "EmpleadoDNI_UQ", IsUnique = true)]
    public class Empleado 
    {

       
        public int Id { get; set; }


        [Required]
        [MaxLength(20, ErrorMessage = "El Nombre no debe superar los 15 caracteres")]
        public string NombreEmpleado { get; set; }

        [Required]
        [MaxLength(20, ErrorMessage = "El Apellido no debe superar los 20 caracteres")]
        public string ApellidoEmpleado { get; set; }

        [Required]
        [MaxLength(12, ErrorMessage = "El DNI no debe superar los 9 caracteres")]
        public string DNIEmpleado { get; set; }

        [Required]
        [MaxLength(2, ErrorMessage = "La Edad no debe superar los 2 caracteres")]
        public string EdadEmpleado { get; set; }

        
        [Required]
        [MaxLength(12, ErrorMessage = "El Telefono no debe superar los 12 caracteres")]
        public string TelefonoEmpleado { get; set; }

        [Required]
        [MaxLength(30, ErrorMessage = "La Direccion no debe superar los 30 caracteres")]
        public string DireccionEmpleado { get; set; }


        [Required]
        [MaxLength(30, ErrorMessage = "La Fecha no debe superar los 10 caracteres")]
        public string FechaContratoEmpleado { get; set; }

            
        public int CargoId { get; set; }
        public Cargo Cargo { get; set; }

       
    }
}
