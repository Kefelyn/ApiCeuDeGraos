using ApiCeuDeGraos.Data;
using ApiCeuDeGraos.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApiCeuDeGraos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutosController : ControllerBase
    {
        private readonly SistemasFazendaContext _context;

        public ProdutosController(SistemasFazendaContext context)
        {
            _context = context;
        }

        // Endpoint para obter todos os produtos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Produto>>> GetProdutos()
        {
            return await _context.Produtos.ToListAsync();
        }

        // Endpoint para adicionar um novo produto
        [HttpPost]
        public async Task<ActionResult<Produto>> AdicionarProduto(Produto produto)
        {
            _context.Produtos.Add(produto);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(AdicionarProduto), new { id = produto.ProdutoID }, produto);
        }
    }



}
