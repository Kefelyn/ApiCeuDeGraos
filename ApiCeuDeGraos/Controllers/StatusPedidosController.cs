using ApiCeuDeGraos.Data;
using ApiCeuDeGraos.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApiCeuDeGraos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatusPedidosController : ControllerBase
    {
        private readonly SistemasFazendaContext _context;

        public StatusPedidosController(SistemasFazendaContext context)
        {
            _context = context;
        }

        // Endpoint para obter todos os status de pedidos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<StatusPedido>>> GetStatusPedidos()
        {
            return await _context.StatusPedidos.ToListAsync();
        }
    }


}
