using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Construction.API.Data;
using Construction.Shared.Entidades;

namespace Construction.API.Controllers
{
    [ApiController]
    [Route("/api/ProyectoConstrucciones")]
    public class ProyectoConstruccionesControladores : ControllerBase
    {
        private readonly DataContext _context;

        public ProyectoConstruccionesControladores(DataContext context)
        {
            _context = context;

        }
        //metodo get lista
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            return Ok(await _context.ProyectoConstrucciones.ToListAsync());
        }


        [HttpPost]
        public async Task<ActionResult> PostAsync(ProyectoConstruccion proyectoConstruccion)
        {
            _context.Add(proyectoConstruccion);
            await _context.SaveChangesAsync();
            return Ok(proyectoConstruccion);
        }
        //metodo get lista por id
        [HttpGet("id:int")]
        public async Task<ActionResult> GetAsync(int id)
        {

            var proyectoConstruccion = await _context.ProyectoConstrucciones.FirstOrDefaultAsync(x => x.Id == id);
            if (proyectoConstruccion == null)
            {
                return NotFound();
            }

            return Ok(proyectoConstruccion);

        }//metodo update
        [HttpPut]
        public async Task<ActionResult> Put(ProyectoConstruccion proyectoConstruccion)
        {
            _context.Update(proyectoConstruccion);
            await _context.SaveChangesAsync();
            return Ok(proyectoConstruccion);
        }
        //metodo delete
        [HttpDelete("id:int")]
        public async Task<ActionResult> Delete(int id)
        {

            var filasAfectadas = await _context.ProyectoConstrucciones.
                Where(x => x.Id == id).ExecuteDeleteAsync();
            if (filasAfectadas == 0)
            {
                return NotFound();
            }
            return NoContent();

        }

    }
}
