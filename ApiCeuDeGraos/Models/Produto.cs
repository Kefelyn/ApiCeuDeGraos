namespace ApiCeuDeGraos.Models
{
    public class Produto
    {
        public int ProdutoID { get; set; }
        public string NomeProduto { get; set; }
        public string Descricao { get; set; }
        public decimal Preco200g { get; set; }
        public decimal Preco500g { get; set; }
        public int Estoque { get; set; }
    }

}
