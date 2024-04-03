using Construction.API.Data;
using Construction.Shared.Entidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Construction.API.Controllers
{
    [ApiController]
    [Route("/api/Materiales")]
    public class MaterialesControladores : ControllerBase
    {
        private readonly DataContext _context;

        public MaterialesControladores(DataContext context)
        {
            _context = context;

        }
        //metodo get lista
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            return Ok(await _context.Materiales.ToListAsync());
        }


        [HttpPost]
        public async Task<ActionResult> Post(Material material)
        {
            _context.Add(material);
            await _context.SaveChangesAsync();
            return Ok(material);
        }
        //metodo get lista por id
        [HttpGet("id:int")]
        public async Task<ActionResult> Get(int id)
        {

            var material = await _context.Materiales.FirstOrDefaultAsync(x => x.Id == id);
            if (material == null)
            {
                return NotFound();
            }

            return Ok(material);

        }//metodo update
        [HttpPut]
        public async Task<ActionResult> Put(Material material)
        {
            _context.Update(material);
            await _context.SaveChangesAsync();
            return Ok(material);
        }
        //metodo delete
        [HttpDelete("id:int")]
        public async Task<ActionResult> Delete(int id)
        {

            var filasAfectadas = await _context.Materiales.
                Where(x => x.Id == id).ExecuteDeleteAsync();
            if (filasAfectadas == 0)
            {
                return NotFound();
            }
            return NoContent();

        }

    }
}
