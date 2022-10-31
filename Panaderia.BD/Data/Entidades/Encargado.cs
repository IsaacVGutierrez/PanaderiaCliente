using System.ComponentModel.DataAnnotations;


namespace Panaderia.BD.Data.Entidades
{
   // [Index(nameof(DNIEncargado), Name = "EncargadoDNI_UQ", IsUnique = true)]
    public class Encargado 
    {

        

       
        public int Id { get; set; }


        [Required]
        [MaxLength(15, ErrorMessage = "El Nombre no debe superar los 15 caracteres")]
        public string NombreEncargado { get; set; }

        [Required]
        [MaxLength(20, ErrorMessage = "El Apellido no debe superar los 20 caracteres")]
        public string ApellidoEncargado { get; set; }

        [Required]
        [MaxLength(12, ErrorMessage ="El DNI no debe superar los 9 caracteres" )]
        public string DNIEncargado { get; set; }

        [Required]
        [MaxLength(2, ErrorMessage = "La Edad no debe superar los 2 caracteres")]
        public string EdadEncargado{ get; set; }

        [Required]
        [MaxLength(30, ErrorMessage = "El Puesto no debe superar los 30 caracteres")]
        public string PuestoCargoEncargado { get; set; }


        [Required]
        [MaxLength(15, ErrorMessage = "El Telefono no debe superar los 12 caracteres")]
        public string TelefonoEncargado { get; set; }

        [Required]
        [MaxLength(30, ErrorMessage = "La Direccion no debe superar los 30 caracteres")]
        public string DireccionEncargado { get; set; }


        [Required]
        [MaxLength(30, ErrorMessage = "La Fecha no debe superar los 30 caracteres")]
        public string FechaInicioEncargado { get; set; }
        

        public List<Proveedor> Proveedores { get; set; }

    }
}
