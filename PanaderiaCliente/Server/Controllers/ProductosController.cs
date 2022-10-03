﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Panaderia.BD.Data;
using Panaderia.BD.Data.Entidades;

namespace PanaderiaCliente.Server.Controllers
{
    [ApiController]
    [Route("api/Productos")]

    public class ProductosController : ControllerBase
    {
        private readonly BDContext context;

        public ProductosController(BDContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Producto>>> Get()
        {

            return await context.Productos.ToListAsync();


        }


        [HttpGet("{id:int}")]
        public async Task<ActionResult<Producto>> Get(int id)
        {
            var cargo = await context.Productos

                .Where(e => e.Id == id)
                .Include(m => m.Proveedores)
                .FirstOrDefaultAsync();


            if (cargo == null)

            {
                return NotFound($"No existe el Producto de Id= {id}");

            }

            return cargo;

        }


        [HttpPost]

        public async Task<ActionResult<Producto>> Post(Producto cargo)
        {
            try
            {


                context.Productos.Add(cargo);
                await context.SaveChangesAsync();
                return cargo;

            }
            catch (Exception p)
            {
                return BadRequest(p.Message);
            }


        }




        [HttpGet("ProductoPorNombre/{nombre}")]

        public async Task<ActionResult<Producto>> ProductoPorNombre(string nombre)
        {
            var cargo = await context.Productos

             .Where(x => x.NombreProduc == nombre)
           .Include(i => i.Proveedores)
           .FirstOrDefaultAsync();


            if (cargo == null)

            {
                return NotFound($"No existe el nombre = {nombre}");

            }

            return cargo;

        }




        [HttpPut("{id:int}")]
        public ActionResult Put(int id, [FromBody] Producto Cargo)
        {


            if (id != Cargo.Id)
            {
                return BadRequest("No existe el Producto");
            }

            var carg = context.Productos.Where(e => e.Id == id).FirstOrDefault();
            var emplead = context.Proveedores.Where(e => e.Id == id).FirstOrDefault();

            if (carg == null)
            {
                return NotFound("No existe el Producto");
            }

            carg.NombreProduc = Cargo.NombreProduc;


            try
            {
                //throw(new Exception(""));
                context.Productos.Update(carg);
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
            var carg = context.Productos.Where(x => x.Id == id).FirstOrDefault();

            if (carg == null)
            {
                return NotFound($"El Producto {id} no fue encontrado");
            }

            try
            {
                context.Productos.Remove(carg);
                context.SaveChanges();
                return Ok($"El registro de {carg.NombreProduc} ha sido borrado.");
            }
            catch (Exception e)
            {
                return BadRequest($"Los datos no pudieron eliminarse por: {e.Message}");
            }
        }
    }
}