
using System.ComponentModel.DataAnnotations;


namespace Panaderia.BD.Data.Entidades
{
 
    public class Venta
    {
        [Required]
        public int Id { get; set; }


        [Required]
        [MaxLength(30, ErrorMessage = "El Codigo no debe superar los 30 caracteres")]
        public string CodigoVenta { get; set; }


        [Required]
        [MaxLength(10, ErrorMessage = "La Cantidad Productos no debe superar los 10 caracteres")]
        public string CantidadVenta { get; set; }

         [Required]
         [MaxLength(30, ErrorMessage = "La Fecha no debe superar los 10 caracteres")]
           public string FechaVenta { get; set; }


        [MaxLength(10, ErrorMessage = "Las Cuotas de Venta no debe superar los 10 caracteres")]
        public string CuotasVenta { get; set; }

        [MaxLength(10, ErrorMessage = "El interes de venta no debe superar los 10 caracteres")]
        public string InteresVenta { get; set; }

        [Required]
        [MaxLength(10, ErrorMessage = "El Precio de Venta no debe superar los 15 caracteres")]
        public string PrecioVenta { get; set; }

    

        [Required(ErrorMessage = "El Empleado es obligatorio")]
        public int EmpleadoId { get; set; }
        public Empleado Empleado { get; set; }


        [Required(ErrorMessage = "El Empleado es obligatorio")]
        public int ProductoId { get; set; }
        public Producto Producto { get; set; }




    }
}
