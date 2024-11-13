using ApiCeuDeGraos.Data;
using ApiCeuDeGraos.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApiCeuDeGraos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItensPedidosController : ControllerBase
    {
        private readonly SistemasFazendaContext _context;

        public ItensPedidosController(SistemasFazendaContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ItemPedido>>> GetItensPedidos()
        {
            return await _context.ItensPedido.Include(i => i.Pedido).Include(i => i.Produto).ToListAsync();
        }
    }

}
