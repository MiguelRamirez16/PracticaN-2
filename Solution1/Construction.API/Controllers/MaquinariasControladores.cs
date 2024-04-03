using Construction.API.Data;
using Construction.Shared.Entidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Construction.API.Controllers
{
    [ApiController]
    [Route("/api/Maquinarias")]
    public class MaquinariasControladores : ControllerBase
    {
        private readonly DataContext _context;

        public MaquinariasControladores(DataContext context)
        {
            _context = context;

        }
        //metodo get lista
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            return Ok(await _context.Maquinarias.ToListAsync());
        }


        [HttpPost]
        public async Task<ActionResult> Post(Maquinaria maquinaria)
        {
            _context.Add(maquinaria);
            await _context.SaveChangesAsync();
            return Ok(maquinaria);
        }
        //metodo get lista por id
        [HttpGet("id:int")]
        public async Task<ActionResult> Get(int id)
        {

            var maquinaria = await _context.Maquinarias.FirstOrDefaultAsync(x => x.Id == id);
            if (maquinaria == null)
            {
                return NotFound();
            }

            return Ok(maquinaria);

        }//metodo update
        [HttpPut]
        public async Task<ActionResult> Put(Maquinaria maquinaria)
        {
            _context.Update(maquinaria);
            await _context.SaveChangesAsync();
            return Ok(maquinaria);
        }
        //metodo delete
        [HttpDelete("id:int")]
        public async Task<ActionResult> Delete(int id)
        {

            var filasAfectadas = await _context.Maquinarias.
                Where(x => x.Id == id).ExecuteDeleteAsync();
            if (filasAfectadas == 0)
            {
                return NotFound();
            }
            return NoContent();

        }

    }
}
