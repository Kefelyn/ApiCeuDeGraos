namespace ApiCeuDeGraos.Models
{
    // Classe modelo para a tabela "BDPedidos"
    public class Pedido
    {
        public int PedidoID { get; set; } // Chave primária
        public int UsuarioID { get; set; } // ID do usuário que fez o pedido (chave estrangeira)
        public DateTime DataPedido { get; set; } = DateTime.Now; // Data em que o pedido foi feito (padrão: data atual)
        public int StatusID { get; set; } // ID do status do pedido (chave estrangeira)
        public decimal ValorTotal { get; set; } // Valor total do pedido
        public string Avaliacao { get; set; } // Avaliação do pedido pelo cliente

        // Relacionamentos (navigation properties)
        public Usuario Usuario { get; set; } // Relacionamento com a tabela de usuários
        public StatusPedido StatusPedido { get; set; } // Relacionamento com a tabela de status de pedidos
    }

}
