using ApiCeuDeGraos.Data;
using ApiCeuDeGraos.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApiCeuDeGraos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PedidosController : ControllerBase
    {
        private readonly SistemasFazendaContext _context;

        public PedidosController(SistemasFazendaContext context)
        {
            _context = context;
        }

        // Endpoint para obter todos os pedidos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Pedido>>> GetPedidos()
        {
            return await _context.Pedidos.Include(p => p.Usuario).Include(p => p.StatusPedido).ToListAsync();
        }

        // Endpoint para criar um novo pedido
        [HttpPost]
        public async Task<ActionResult<Pedido>> CriarPedido(Pedido pedido)
        {
            _context.Pedidos.Add(pedido);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(CriarPedido), new { id = pedido.PedidoID }, pedido);
        }
    }


}
