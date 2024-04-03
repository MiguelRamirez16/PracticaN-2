using Construction.API.Data;
using Construction.Shared.Entidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Construction.API.Controllers
{
    [ApiController]
    [Route("/api/EquipoConstrucciones")]
    public class EquipoConstruccionesControladores : ControllerBase
    {
        private readonly DataContext _context;

        public EquipoConstruccionesControladores(DataContext context)
        {
            _context = context;

        }
        //metodo get lista
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            return Ok(await _context.EquipoConstrucciones.ToListAsync());
        }


        [HttpPost]
        public async Task<ActionResult> Post(EquipoConstruccion equipoConstruccion)
        {
            _context.Add(equipoConstruccion);
            await _context.SaveChangesAsync();
            return Ok(equipoConstruccion);
        }
        //metodo get lista por id
        [HttpGet("id:int")]
        public async Task<ActionResult> Get(int id)
        {

            var equipoConstruccion = await _context.EquipoConstrucciones.FirstOrDefaultAsync(x => x.Id == id);
            if (equipoConstruccion == null)
            {
                return NotFound();
            }

            return Ok(equipoConstruccion);

        }//metodo update
        [HttpPut]
        public async Task<ActionResult> Put(EquipoConstruccion equipoConstruccion)
        {
            _context.Update(equipoConstruccion);
            await _context.SaveChangesAsync();
            return Ok(equipoConstruccion);
        }
        //metodo delete
        [HttpDelete("id:int")]
        public async Task<ActionResult> Delete(int id)
        {

            var filasAfectadas = await _context.EquipoConstrucciones.
                Where(x => x.Id == id).ExecuteDeleteAsync();
            if (filasAfectadas == 0)
            {
                return NotFound();
            }
            return NoContent();

        }


    }
}
