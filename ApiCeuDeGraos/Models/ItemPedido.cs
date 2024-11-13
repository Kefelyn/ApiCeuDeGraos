namespace ApiCeuDeGraos.Models
{
    // Classe modelo para a tabela "BDItensPedido"
    public class ItemPedido
    {
        public int ItensPedidoID { get; set; } // Chave primária
        public int PedidoID { get; set; } // ID do pedido (chave estrangeira)
        public int ProdutoID { get; set; } // ID do produto (chave estrangeira)
        public int Quantidade { get; set; } // Quantidade do produto no pedido
        public decimal Preco { get; set; } // Preço do item no pedido

        // Relacionamentos 
        public Pedido Pedido { get; set; } // Relacionamento com a tabela de pedidos
        public Produto Produto { get; set; } // Relacionamento com a tabela de produtos
    }

}
