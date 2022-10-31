using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Panaderia.BD.Data;
using Panaderia.BD.Data.Entidades;

namespace PanaderiaCliente.Server.Controllers
{
    [ApiController]
    [Route("api/Proveedores")]

    public class ProveedoresController : ControllerBase
    {
        private readonly Bdcontext context;

        public ProveedoresController(Bdcontext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Proveedor>>> Get()
        {

            return await context.Proveedores.
                                              Include(m => m.Encargado)
                                              .ToListAsync();


        }


        [HttpGet("{id:int}")]
        public async Task<ActionResult<Proveedor>> Get(int id)
        {
            var proveedor = await context.Proveedores

                .Where(e => e.Id == id)
                .Include(m => m.Encargado)
                .FirstOrDefaultAsync();


            if (proveedor == null)

            {
                return NotFound($"No existe el Proveedor de Id= {id}");

            }

            return proveedor;

        }


        [HttpPost]

        public async Task<ActionResult<int>> Post(Proveedor proveedor)
        {
            try
            {


                context.Proveedores.Add(proveedor);
                await context.SaveChangesAsync();
                return proveedor.Id;

            }
            catch (Exception p)
            {
                return BadRequest(p.Message);
            }


        }




        [HttpGet("ProveedorPorNombre/{nombre}")]

        public async Task<ActionResult<Proveedor>> ProveedoresPorNombre(string nombre)
        {
            var proveedor = await context.Proveedores

             .Where(x => x.NombreProved == nombre)
           .Include(i => i.Encargado)
           .FirstOrDefaultAsync();


            if (proveedor == null)

            {
                return NotFound($"No existe el nombre = {nombre}");

            }

            return proveedor;

        }




        [HttpPut("{id:int}")]
        public ActionResult Put(int id, [FromBody] Proveedor proveedor)
        {


            if (id != proveedor.Id)
            {
                return BadRequest("No existe el Proveedor");
            }

            var carg = context.Proveedores.Where(e => e.Id == id).FirstOrDefault();
            var emplead = context.Encargados.Where(e => e.Id == id).FirstOrDefault();
            var produc = context.Productos.Where(e => e.Id == id).FirstOrDefault();

            if (carg == null)
            {
                return NotFound("No existe el Proveedor");
            }

            carg.NombreProved = proveedor.NombreProved;


            try
            {
                //throw(new Exception(""));
                context.Proveedores.Update(carg);
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
            var carg = context.Proveedores.Where(x => x.Id == id).FirstOrDefault();

            if (carg == null)
            {
                return NotFound($"El Proveedor {id} no fue encontrado");
            }

            try
            {
                context.Proveedores.Remove(carg);
                context.SaveChanges();
                return Ok($"El registro de {carg.NombreProved} ha sido borrado.");
            }
            catch (Exception e)
            {
                return BadRequest($"Los datos no pudieron eliminarse por: {e.Message}");
            }
        }
    }
}
