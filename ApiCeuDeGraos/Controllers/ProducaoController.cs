using ApiCeuDeGraos.Data;
using ApiCeuDeGraos.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApiCeuDeGraos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProducaoController : ControllerBase
    {
        private readonly SistemasFazendaContext _context;

        public ProducaoController(SistemasFazendaContext context)
        {
            _context = context;
        }

        // Endpoint para obter todas as produções
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Producao>>> GetProducoes()
        {
            return await _context.Producoes.Include(p => p.Produto).ToListAsync();
        }

        // Endpoint para adicionar uma nova produção
        [HttpPost]
        public async Task<ActionResult<Producao>> AdicionarProducao(Producao producao)
        {
            _context.Producoes.Add(producao);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(AdicionarProducao), new { id = producao.ProducaoID }, producao);
        }
    }

}
