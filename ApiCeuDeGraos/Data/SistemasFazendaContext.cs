using ApiCeuDeGraos.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiCeuDeGraos.Data
{
    public class SistemasFazendaContext : DbContext
    {
        public SistemasFazendaContext(DbContextOptions<SistemasFazendaContext> options) : base(options) { }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<ItemPedido> ItensPedido { get; set; }
        public DbSet<Producao> Producoes { get; set; }
        public DbSet<StatusPedido> StatusPedidos { get; set; }
    }
}
