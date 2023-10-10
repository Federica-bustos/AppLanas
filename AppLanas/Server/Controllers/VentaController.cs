using AppLanas.BD.Data;
using AppLanas.BD.Data.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AppLanas.Server.Controllers
{
    [ApiController]
    [Route("api/Venta")]
    public class VentaController : ControllerBase
    {
        private readonly Context context;

        public VentaController(Context context)
        {
            this.context = context;
        }

        [HttpGet]

        public async Task<ActionResult<List<Venta>>> Get()
        {
            var lista = await context.Ventas.ToListAsync();
            if (lista == null || lista.Count == 0)
            {
                return BadRequest("no hay Ventas cargada");
            }

            return Ok(lista);

        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Venta>> Get(int id)
        {
            var existe = await context.Ventas.AnyAsync(x => x.Id == id);
            if (!existe)
            {
                return NotFound($"La Venta {id} no existe");
            }

            return await context.Ventas.FirstOrDefaultAsync(ven => ven.Id == id);
        }
    }
}
