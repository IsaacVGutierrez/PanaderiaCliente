using System.ComponentModel.DataAnnotations;


namespace Panaderia.BD.Data.Entidades
{

     public class Producto
    {
        [Required]
        public int Id { get; set; }


        [Required]
        [MaxLength(30, ErrorMessage = "El Nombre no debe superar los 30 caracteres")]
        public string NombreProduc { get; set; }

        [Required]
        [MaxLength(10, ErrorMessage = "El Precio no debe superar los 10 caracteres")]
        public string PrecioProduc { get; set; }

        [Required]
        [MaxLength(30, ErrorMessage = "El Codigo no debe superar los 30 caracteres")]
        public string CodigoProduc{ get; set; }

         [Required]
         [MaxLength(30, ErrorMessage = "La Fecha no debe superar los 10 caracteres")]
         public string FechaVencimientoProduc { get; set; }

        [Required]
        [MaxLength(10, ErrorMessage = "La Cantidad de Productos no debe superar los 10 caracteres")]
        public string CantidadProduc { get; set; }



        [Required(ErrorMessage = "El Proveedor es obligatorio")]
        public int ProveedorId { get; set; }

        public Proveedor Proveedor { get; set; }

       
        

    }


}
