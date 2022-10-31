using System.ComponentModel.DataAnnotations;


namespace Panaderia.BD.Data.Entidades
{

    
    public class Cargo
    {
     
        public int Id { get; set; }


       [Required ( ErrorMessage = "El Nombre de Cargo es obligatorio")]
        [MaxLength(20, ErrorMessage = "El Nombre Cargo no debe superar los 20 caracteres")]
        public string NombreCargo { get; set; }

           
        public List<Empleado> Empleados { get; set; }

    }
}
