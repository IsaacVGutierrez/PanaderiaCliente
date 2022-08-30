using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Panaderia.BD.Data;
using Panaderia.BD.Data.Entidades;

namespace PanaderiaCliente.Server.Controllers
{
    [ApiController]
    [Route("api/Ventas")]

    public class VentasController : ControllerBase
    {
        private readonly BDContext context;

        public VentasController(BDContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Venta>>> Get()
        {

            return await context.Ventas.ToListAsync();


        }


        [HttpGet("{id:int}")]
        public async Task<ActionResult<Venta>> Get(int id)
        {
            var cargo = await context.Ventas

                .Where(e => e.Id == id)
                .Include(m => m.Empleados)
                .FirstOrDefaultAsync();


            if (cargo == null)

            {
                return NotFound($"No existe la Venta de Id= {id}");

            }

            return cargo;

        }


        [HttpPost]

        public async Task<ActionResult<Venta>> Post(Venta cargo)
        {
            try
            {


                context.Ventas.Add(cargo);
                await context.SaveChangesAsync();
                return cargo;

            }
            catch (Exception p)
            {
                return BadRequest(p.Message);
            }


        }




        [HttpGet("VentasPorNombre/{nombre}")]

        public async Task<ActionResult<Venta>> VentasPorNombre(int nombre)
        {
            var cargo = await context.Ventas

             .Where(x => x.CodigoVenta == nombre)
           .Include(i => i.Empleados)
           .FirstOrDefaultAsync();


            if (cargo == null)

            {
                return NotFound($"No existe el Codigo = {nombre}");

            }

            return cargo;

        }




        [HttpPut("{id:int}")]
        public ActionResult Put(int id, [FromBody] Venta Cargo)
        {


            if (id != Cargo.Id)
            {
                return BadRequest("No existe el Codigo");
            }

            var carg = context.Ventas.Where(e => e.Id == id).FirstOrDefault();
            var emplead = context.Empleados.Where(e => e.Id == id).FirstOrDefault();

            if (carg == null)
            {
                return NotFound("No existe la Venta");
            }

            carg.CodigoVenta = Cargo.CodigoVenta;


            try
            {
                //throw(new Exception(""));
                context.Ventas.Update(carg);
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
            var carg = context.Ventas.Where(x => x.Id == id).FirstOrDefault();

            if (carg == null)
            {
                return NotFound($"La venta {id} no fue encontrado");
            }

            try
            {
                context.Ventas.Remove(carg);
                context.SaveChanges();
                return Ok($"El registro de {carg.CodigoVenta} ha sido borrado.");
            }
            catch (Exception e)
            {
                return BadRequest($"Los datos no pudieron eliminarse por: {e.Message}");
            }
        }
    }
}
