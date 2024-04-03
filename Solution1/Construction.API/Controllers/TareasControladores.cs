using Construction.API.Data;
using Construction.Shared.Entidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace Construction.API.Controllers
{
    [ApiController]
    [Route("/api/Tareas")]

    public class TareasControladores : ControllerBase
    {
        private readonly DataContext _context;

        public TareasControladores(DataContext context)
        {
            _context = context;

        }
        //metodo get lista
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            return Ok(await _context.Tareas.ToListAsync());
        }
        [HttpPost]
        public async Task<ActionResult> Post(Tarea tarea)
        {
            _context.Add(tarea);
            await _context.SaveChangesAsync();
            return Ok(tarea);
        }
        //metodo get lista por id
        [HttpGet("id:int")]
        public async Task<ActionResult> Get(int id)
        {

            var tarea = await _context.Tareas.FirstOrDefaultAsync(x => x.Id == id);
            if (tarea == null)
            {
                return NotFound();
            }

            return Ok(tarea);

        }//metodo update
        [HttpPut]
        public async Task<ActionResult> Put(Tarea tarea)
        {
            _context.Update(tarea);
            await _context.SaveChangesAsync();
            return Ok(tarea);
        }
        //metodo delete
        [HttpDelete("id:int")]
        public async Task<ActionResult> Delete(int id)
        {

            var filasAfectadas = await _context.Tareas.
                Where(x => x.Id == id).ExecuteDeleteAsync();
            if (filasAfectadas == 0)
            {
                return NotFound();
            }
            return NoContent();

        }

    }
}
