using System.ComponentModel.DataAnnotations;


namespace Panaderia.BD.Data.Entidades


{
   // [Index(nameof(DNIProved), Name = "ProveedorDNI_UQ", IsUnique = true)]
    public class Proveedor 
    {

       
        public int Id { get; set; }


        [Required]
        [MaxLength(15, ErrorMessage = "El Nombre no debe superar los 15 caracteres")]
        public string NombreProved { get; set; }

        [Required]
        [MaxLength(9, ErrorMessage = "El DNI no debe superar los 9 caracteres")]
        public string DNIProved { get; set; }

        [Required]
        [MaxLength(30, ErrorMessage = "La Direccion no debe superar los 30 caracteres")]
        public string DireccionProved { get; set; }

        [Required]
        [MaxLength(12, ErrorMessage = "El Telefono no debe superar los 12 caracteres")]
        public string TelefonoProved { get; set; }

        [Required]
        [MaxLength(30, ErrorMessage = "La Fecha no debe superar los 10 caracteres")]
         public string FechaEntregaProved { get; set; }


       
        public int EncargadoId { get; set; }

        public Encargado Encargado { get; set; }

        // public List<Producto> Productos { get; set; }

    }
}
