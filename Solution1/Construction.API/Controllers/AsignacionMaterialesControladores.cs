using Construction.API.Data;
using Construction.Shared.Entidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Construction.API.Controllers
{
    [ApiController]
    [Route("/api/AsignacionMateriales")]
    public class AsignacionMaterialesControladores : ControllerBase
    {
        private readonly DataContext _context;
        public AsignacionMaterialesControladores(DataContext context)
        {
            _context = context;

        }
        //metodo get lista
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            return Ok(await _context.AsignacionMateriales.ToListAsync());
        }
        [HttpPost]
        public async Task<ActionResult> Post(AsignacionMaterial asignacionMaterial)
        {
            _context.Add(asignacionMaterial);
            await _context.SaveChangesAsync();
            return Ok(asignacionMaterial);
        }
        //metodo get lista por id
        [HttpGet("id:int")]
        public async Task<ActionResult> Get(int id)
        {

            var asignacionMaterial = await _context.AsignacionMateriales.FirstOrDefaultAsync(x => x.Id == id);
            if (asignacionMaterial == null)
            {
                return NotFound();
            }

            return Ok(asignacionMaterial);

        }//metodo update
        [HttpPut]
        public async Task<ActionResult> Put(AsignacionMaterial asignacionMaterial)
        {
            _context.Update(asignacionMaterial);
            await _context.SaveChangesAsync();
            return Ok(asignacionMaterial);
        }
        //metodo delete
        [HttpDelete("id:int")]
        public async Task<ActionResult> Delete(int id)
        {

            var filasAfectadas = await _context.AsignacionMateriales.
                Where(x => x.Id == id).ExecuteDeleteAsync();
            if (filasAfectadas == 0)
            {
                return NotFound();
            }
            return NoContent();

        }
    }
}
