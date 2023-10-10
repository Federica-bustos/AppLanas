using AppLanas.BD.Data;
using AppLanas.BD.Data.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AppLanas.Server.Controllers
{
    [ApiController]
    [Route("api/Caja")]
    public class CajaController : ControllerBase
    {
        private readonly Context context;

        public CajaController(Context context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Caja>>> Get()
        {
            var lista = await context.Cajas.ToListAsync();
            if (lista == null || lista.Count == 0)
            {
                return BadRequest("no hay caja cargada");
            }

            return Ok(lista);

        }

        [HttpGet("{id:int}")]

        public async Task<ActionResult<Caja>> Get(int id)
        {
            var existe = await context.Cajas.AnyAsync(x => x.Id == id);
            if (!existe)
            {
                return NotFound($"la caja {id} no existe");
            }
            return await context.Cajas.FirstOrDefaultAsync(caj => caj.Id == id);
        }
    }
}

