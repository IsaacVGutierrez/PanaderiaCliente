using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Panaderia.BD.Data;
using Panaderia.BD.Data.Entidades;


namespace PanaderiaCliente.Server.Controllers
{
    [ApiController]
    [Route("api/Empleados")]

    public class EmpleadosController : ControllerBase
    {

        private readonly Bdcontext context;

        public EmpleadosController(Bdcontext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Empleado>>> Get()
        {

            return await context.Empleados.
                                           Include(m => m.Cargo)
                                          .ToListAsync();


        }


        [HttpGet("{id:int}")]
        public async Task<ActionResult<Empleado>> Get(int id)
        {

            var empleado = await context.Empleados

                .Where(e => e.Id == id)
                .Include(m => m.Cargo)
                .FirstOrDefaultAsync();


            if (empleado == null)

            {
                return NotFound($"No existe el Empleado de Id= {id}");

            }

            return empleado;

        }


        [HttpPost]

        public async Task<ActionResult<int>> Post(Empleado empleado)
        {
          
            try
            {

                context.Empleados.Add(empleado);
                await context.SaveChangesAsync();
                return empleado.Id;
                
            }
            catch (Exception p)
            {
                return BadRequest(p.Message);
            }


        }




        [HttpGet("EmpleadoPorNombre/{nombre}")]

        public async Task<ActionResult<Empleado>> EmpleadoPorNombre(string nombre)
        {
            var empleado = await context.Empleados

             .Where(x => x.NombreEmpleado == nombre)
           .Include(i => i.Cargo)
           .FirstOrDefaultAsync();


            if (empleado == null)

            {
                return NotFound($"No existe el nombre = {nombre}");

            }

            return empleado;

        }




        [HttpPut("{id:int}")]
        public ActionResult Put(int id, [FromBody] Empleado Empleado)
        {


            if (id != Empleado.Id)
            {
                return BadRequest("No existe el Empleado");
            }

            var emp = context.Empleados.Where(e => e.Id == id).FirstOrDefault();
            var emplead = context.Cargos.Where(e => e.Id == id).FirstOrDefault();
            var vent = context.Ventas.Where(e => e.Id == id).FirstOrDefault();

            if (emp == null)
            {
                return NotFound("No existe el empleado");
            }

            emp.NombreEmpleado = Empleado.NombreEmpleado;
            emp.ApellidoEmpleado = Empleado.ApellidoEmpleado;
            emp.DNIEmpleado = Empleado.DNIEmpleado;
            emp.EdadEmpleado = Empleado.EdadEmpleado;
            emp.TelefonoEmpleado = Empleado.TelefonoEmpleado;
            emp.DireccionEmpleado = Empleado.DireccionEmpleado;
            emp.FechaContratoEmpleado = Empleado.FechaContratoEmpleado;

            emplead.NombreCargo = Empleado.Cargo.NombreCargo;

            try
            {
                
                context.Empleados.Update(emp);
                context.SaveChanges();
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest($"Los datos no han sido actualizados por: {e.Message}");
            }
        }



        [HttpDelete("{id:int}")]
        public ActionResult Delete(int id)
        {
            var carg = context.Empleados.Where(x => x.Id == id).FirstOrDefault();

            if (carg == null)
            {
                return NotFound($"El Empleado {id} no fue encontrado");
            }

            try
            {
                context.Empleados.Remove(carg);
                context.SaveChanges();
                return Ok($"El registro de {carg.NombreEmpleado} ha sido borrado.");
            }
            catch (Exception e)
            {
                return BadRequest($"Los datos no pudieron eliminarse por: {e.Message}");
            }
        }






    }
}
