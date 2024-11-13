using ApiCeuDeGraos.Data;
using ApiCeuDeGraos.Models;
using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApiCeuDeGraos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private readonly SistemasFazendaContext _context;

        public UsuariosController(SistemasFazendaContext context)
        {
            _context = context;
        }

        // Endpoint para obter todos os usuários
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Usuario>>> GetUsuarios()
        {
            return await _context.Usuarios.ToListAsync();
        }

        // Endpoint para cadastrar um novo usuário
        [HttpPost("cadastrar")]
        public async Task<ActionResult<Usuario>> CadastrarUsuario(Usuario usuario)
        {
            _context.Usuarios.Add(usuario);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(CadastrarUsuario), new { id = usuario.UsuarioID }, usuario);
        }
    }


}
