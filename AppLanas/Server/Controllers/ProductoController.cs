using AppLanas.BD.Data;
using AppLanas.BD.Data.Entity;
using AppLanas.Shared.DTO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AppLanas.Server.Controllers
{
    [ApiController]
    [Route("api/Producto")]
    public class ProductoController : ControllerBase
    {
        private readonly Context context;

        public ProductoController(Context context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Producto>>> Get()
        {
            var lista = await context.Productos.ToListAsync();
            if (lista == null || lista.Count == 0)
            {
                return BadRequest("no hay Producto cargado");
            }

            return Ok(lista);

        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Producto>> Get(int id)
        {
            var existe = await context.Productos.AnyAsync(x => x.id == id);
            if (!existe)
            {
                return NotFound($"El producto {id} no existe");
            }

            return await context.Productos.FirstOrDefaultAsync(pro => pro.id == id);
        }

        [HttpPost]
        public async Task<ActionResult<int>> Post(ProductoDTO entidad)
        {
            try
            {
                var existe = await context.Ventas.AnyAsync(x => x.Id == entidad.ventaId);
                if (!existe)
                {
                    return NotFound($"La venta de id = {entidad.ventaId} no existe");
                }

                Producto nuevoproducto = new Producto();

                nuevoproducto.ventaid = entidad.ventaId;
                nuevoproducto.nombreProducto = entidad.nombreProducto;
                nuevoproducto.precioProducto = entidad.precioProducto;
                nuevoproducto.precioProveedor = entidad.precioProveedor;
                nuevoproducto.porcentajeGanancia = entidad.porcentajeGanancia;

                await context.AddAsync(nuevoproducto);
                await context.SaveChangesAsync();
                return Ok("Se cargo correctamente el Producto.");
            }

            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPut("{id:int}")]

        public async Task<ActionResult> Put(Producto producto, int id)
        {
            if (id != producto.id)
            {
                BadRequest("El id de producto no coincide.");
            }
            var existe = await context.Productos.AnyAsync(x => x.id == id);
            if (!existe)
            {
                return NotFound($"El producto con el ID={id} no existe");
            }

            context.Update(producto);
            await context.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete]
        public async Task<ActionResult> Delete(int id)
        {
            var existe = await context.Productos.AnyAsync(x => x.id == id);
            if (!existe)
            {
                return BadRequest($"El producto con el ID={id} no existe");
            }

            context.Remove(new Producto() { id = id });
            await context.SaveChangesAsync();
            return Ok();
        }
    }
}
