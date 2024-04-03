using Construction.API.Data;
using Construction.Shared.Entidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Construction.API.Controllers
{
    [ApiController]
    [Route("/api/Presupuestos")]
    public class PresupuestosControladores : ControllerBase
    {
        private readonly DataContext _context;

        public PresupuestosControladores(DataContext context)
        {
            _context = context;

        }
        //metodo get lista
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            return Ok(await _context.Presupuestos.ToListAsync());
        }

        [HttpPost]
        public async Task<ActionResult> Post(Presupuesto presupuesto)
        {
            _context.Add(presupuesto);
            await _context.SaveChangesAsync();
            return Ok(presupuesto);
        }
        //metodo get lista por id
        [HttpGet("id:int")]
        public async Task<ActionResult> Get(int id)
        {

            var presupuesto = await _context.Presupuestos.FirstOrDefaultAsync(x => x.Id == id);
            if (presupuesto == null)
            {
                return NotFound();
            }

            return Ok(presupuesto);

        }//metodo update

        [HttpPut]
        public async Task<ActionResult> Put(Presupuesto presupuesto)
        {
            _context.Update(presupuesto);
            await _context.SaveChangesAsync();
            return Ok(presupuesto);
        }
        //metodo delete
        [HttpDelete("id:int")]
        public async Task<ActionResult> Delete(int id)
        {

            var filasAfectadas = await _context.Presupuestos.
                Where(x => x.Id == id).ExecuteDeleteAsync();
            if (filasAfectadas == 0)
            {
                return NotFound();
            }
            return NoContent();

        }
    }
}
