namespace ApiCeuDeGraos.Models
{
    public class Pedido
    {
        public int PedidoID { get; set; }
        public int UsuarioID { get; set; }
        public DateTime DataPedido { get; set; } = DateTime.Now;
        public int StatusID { get; set; }
        public decimal ValorTotal { get; set; }
        public string Avaliacao { get; set; }

        // Relacionamentos
        public Usuario Usuario { get; set; }
        public StatusPedido StatusPedido { get; set; }
    }

}
