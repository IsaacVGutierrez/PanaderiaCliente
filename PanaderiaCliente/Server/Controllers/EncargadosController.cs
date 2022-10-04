using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Panaderia.BD.Data;
using Panaderia.BD.Data.Entidades;

namespace PanaderiaCliente.Server.Controllers
{
    [ApiController]
    [Route("api/Encargados")]

    public class EncargadosController : ControllerBase
    {
        private readonly BDContext context;

        public EncargadosController(BDContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Encargado>>> Get()
        {

            return await context.Encargados.ToListAsync();


        }


        [HttpGet("{id:int}")]
        public async Task<ActionResult<Encargado>> Get(int id)
        {
            var cargo = await context.Encargados

                .Where(e => e.Id == id)
                .Include(m => m.Proveedores)
                .FirstOrDefaultAsync();


            if (cargo == null)

            {
                return NotFound($"No existe el Encargado de Id= {id}");

            }

            return cargo;

        }


        [HttpPost]

        public async Task<ActionResult<Encargado>> Post(Encargado encargado )
        {
            try
            {


                context.Encargados.Add(encargado);
                await context.SaveChangesAsync();
                return encargado;

            }
            catch (Exception m)
            {
                return BadRequest(m.Message);
            }


        }




        [HttpGet("EncargadoPorNombre/{nombre}")]

        public async Task<ActionResult<Encargado>> EncargadoPorNombre(string nombre)
        {
            var cargo = await context.Encargados

             .Where(x => x.NombreEncargado == nombre)
           .Include(i => i.Proveedores)
           .FirstOrDefaultAsync();


            if (cargo == null)

            {
                return NotFound($"No existe el nombre = {nombre}");

            }

            return cargo;

        }




        [HttpPut("{id:int}")]
        public ActionResult Put(int id, [FromBody] Encargado Cargo)
        {


            if (id != Cargo.Id)
            {
                return BadRequest("No existe el Encargado");
            }

            var carg = context.Encargados.Where(e => e.Id == id).FirstOrDefault();
            var emplead = context.Proveedores.Where(e => e.Id == id).FirstOrDefault();

            if (carg == null)
            {
                return NotFound("No existe el Encargado");
            }

            carg.NombreEncargado = Cargo.NombreEncargado;


            try
            {
                //throw(new Exception(""));
                context.Encargados.Update(carg);
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
            var carg = context.Encargados.Where(x => x.Id == id).FirstOrDefault();

            if (carg == null)
            {
                return NotFound($"El Encargado {id} no fue encontrado");
            }

            try
            {
                context.Encargados.Remove(carg);
                context.SaveChanges();
                return Ok($"El registro de {carg.NombreEncargado} ha sido borrado.");
            }
            catch (Exception e)
            {
                return BadRequest($"Los datos no pudieron eliminarse por: {e.Message}");
            }
        }
    }
}
