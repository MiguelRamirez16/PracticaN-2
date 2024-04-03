using Construction.API.Data;
using Construction.Shared.Entidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Construction.API.Controllers
{
    [ApiController]
    [Route("/api/AsignacionEquipos")]
    public class AsignacionEquiposControladores : ControllerBase    
    {
        private readonly DataContext _context;
        public AsignacionEquiposControladores(DataContext context)
        {
            _context = context;

        }
        //metodo get lista
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            return Ok(await _context.AsignacionEquipos.ToListAsync());
        }


        [HttpPost]
        public async Task<ActionResult> Post(AsignacionEquipo asignacionEquipo)
        {
            _context.Add(asignacionEquipo);
            await _context.SaveChangesAsync();
            return Ok(asignacionEquipo);
        }
        //metodo get lista por id
        [HttpGet("id:int")]
        public async Task<ActionResult> Get(int id)
        {

            var asignacionEquipo = await _context.AsignacionEquipos.FirstOrDefaultAsync(x => x.Id == id);
            if (asignacionEquipo == null)
            {
                return NotFound();
            }

            return Ok(asignacionEquipo);

        }//metodo update
        [HttpPut]
        public async Task<ActionResult> Put(AsignacionEquipo asignacionEquipo)
        {
            _context.Update(asignacionEquipo);
            await _context.SaveChangesAsync();
            return Ok(asignacionEquipo);
        }
        [HttpDelete("id:int")]
        public async Task<ActionResult> Delete(int id)
        {

            var filasAfectadas = await _context.AsignacionEquipos.
                Where(x => x.Id == id).ExecuteDeleteAsync();
            if (filasAfectadas == 0)
            {
                return NotFound();
            }
            return NoContent();

        }
    }
}
