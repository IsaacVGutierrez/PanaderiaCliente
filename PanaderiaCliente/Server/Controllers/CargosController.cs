using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Panaderia.BD.Data;
using Panaderia.BD.Data.Entidades;

namespace PanaderiaCliente.Server.Controllers
{
    [ApiController]
    [Route("api/Cargos")]

    public class CargosController : ControllerBase
    {
        private readonly Bdcontext context;

        public CargosController(Bdcontext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Cargo>>> Get()
        {

            return await context.Cargos.ToListAsync();


        }


        [HttpGet("{id:int}")]
        public async Task<ActionResult<Cargo>> Get(int id)
        {
            var cargo = await context.Cargos

                .Where(e => e.Id == id)
                .Include(m => m.Empleados)
                .FirstOrDefaultAsync();


            if (cargo == null)

            {
                return NotFound($"No existe el cargo de Id= {id}");

            }

            return cargo;

        }


        [HttpPost]

        public async Task<ActionResult<int>> Post(Cargo cargo)
        {
            try
            {


                context.Cargos.Add(cargo);
                await context.SaveChangesAsync();
                return cargo.Id;

            }
            catch (Exception p)
            {
                return BadRequest(p.Message);
            }


        }




        [HttpGet("CargoPorNombre/{nombre}")]

       public async Task<ActionResult<Cargo>> CargoPorNombre( string nombre)
       {
            var cargo = await context.Cargos

             .Where(x => x.NombreCargo == nombre)
           .Include(i => i.Empleados)
           .FirstOrDefaultAsync();


            if (cargo == null)

            {
                return NotFound($"No existe el nombre = {nombre}");

            }

            return cargo;

           }

    
            

            [HttpPut("{id:int}")]
            public ActionResult Put(int id, [FromBody] Cargo Cargo)
            {


                if (id != Cargo.Id)
                {
                    return BadRequest("No existe el cargo");
                }

                var carg = context.Cargos.Where(e => e.Id == id).FirstOrDefault();
                var emplead = context.Empleados.Where(e => e.Id == id).FirstOrDefault();

                if (carg == null)
                {
                    return NotFound("No existe el cargo");
                }

                carg.NombreCargo = Cargo.NombreCargo;
              

                try
                {
                    //throw(new Exception(""));
                    context.Cargos.Update(carg);
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
                var carg = context.Cargos.Where(x => x.Id == id).FirstOrDefault();

                if (carg == null)
                {
                    return NotFound($"El Cargo {id} no fue encontrado");
                }

                try
                {
                    context.Cargos.Remove(carg);
                    context.SaveChanges();
                    return Ok($"El registro de {carg.NombreCargo} ha sido borrado.");
                }
                catch (Exception e)
                {
                    return BadRequest($"Los datos no pudieron eliminarse por: {e.Message}");
                }
            }
    }
}
