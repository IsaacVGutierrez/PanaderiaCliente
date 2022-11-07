using System.ComponentModel.DataAnnotations;


namespace Panaderia.BD.Data.Entidades
{
    //[Index(nameof(CodigoProduc), Name = "ProductoCodigo_UQ", IsUnique = true)]
    public class Producto
    {
       
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



        
        public int ProveedorId { get; set; }

        public Proveedor Proveedor { get; set; }

        public List<Venta> Ventas { get; set; }


    }


}
