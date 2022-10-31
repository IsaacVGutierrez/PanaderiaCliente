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
        private readonly Bdcontext context;

        public VentasController(Bdcontext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Venta>>> Get()
        {

            return await context.Ventas

                    .Include(i => i.Producto)
                .Include(m => m.Empleado)
                .ToListAsync();


        }


        [HttpGet("{id:int}")]
        public async Task<ActionResult<Venta>> Get(int id)
        {
            var cargo = await context.Ventas

                .Where(e => e.Id == id)
               .Include(i => i.Producto)
                .Include(m => m.Empleado)
                .FirstOrDefaultAsync();


            if (cargo == null)

            {
                return NotFound($"No existe la Venta de Id= {id}");

            }

            return cargo;

        }


        [HttpPost]

        public async Task<ActionResult<int>> Post(Venta venta)
        {
            try
            {


                context.Ventas.Add(venta);
                await context.SaveChangesAsync();
                return venta.Id;

            }
            catch (Exception p)
            {
                return BadRequest(p.Message);
            }


        }




        [HttpGet("VentasPorNombre/{nombre}")]

        public async Task<ActionResult<Venta>> VentasPorNombre(string nombre)
        {
            var cargo = await context.Ventas

             .Where(x => x.CodigoVenta == nombre)
           .Include(i => i.Producto)
             .Include(i => i.Empleado)
           
           .FirstOrDefaultAsync();


            if (cargo == null)

            {
                return NotFound($"No existe el Codigo = {nombre}");

            }

            return cargo;

        }




        [HttpPut("{id:int}")]
        public ActionResult Put(int id, [FromBody] Venta venta)
        {


            if (id != venta.Id)
            {
                return BadRequest("No existe el Codigo");
            }

            var carg = context.Ventas.Where(e => e.Id == id).FirstOrDefault();
            var emplead = context.Empleados.Where(e => e.Id == id).FirstOrDefault();
            var prod = context.Productos.Where(e => e.Id == id).FirstOrDefault();

            if (carg == null)
            {
                return NotFound("No existe la Venta");
            }

            carg.CodigoVenta = venta.CodigoVenta;
           carg.CantidadVenta = venta.CantidadVenta;
            carg.InteresVenta = venta.InteresVenta;
           carg.CuotasVenta = venta.CuotasVenta;
            carg.PrecioVenta = venta.PrecioVenta;
            carg.FechaVenta = venta.FechaVenta;


            emplead.NombreEmpleado = venta.Empleado.NombreEmpleado;
            prod.NombreProduc = venta.Producto.NombreProduc;

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
