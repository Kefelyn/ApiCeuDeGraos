namespace ApiCeuDeGraos.Models
{
    public class ItemPedido
    {
        public int ItensPedidoID { get; set; }
        public int PedidoID { get; set; }
        public int ProdutoID { get; set; }
        public int Quantidade { get; set; }
        public decimal Preco { get; set; }

        // Relacionamentos
        public Pedido Pedido { get; set; }
        public Produto Produto { get; set; }
    }

}
