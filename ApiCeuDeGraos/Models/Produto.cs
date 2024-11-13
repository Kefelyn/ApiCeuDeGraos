namespace ApiCeuDeGraos.Models
{
    // Classe modelo para a tabela "Produtos"
    public class Produto
    {
        public int ProdutoID { get; set; } // Chave primária
        public string NomeProduto { get; set; } // Nome do produto
        public string Descricao { get; set; } // Descrição do produto
        public decimal Preco200g { get; set; } // Preço para 200g do produto
        public decimal Preco500g { get; set; } // Preço para 500g do produto
        public int Estoque { get; set; } // Quantidade de estoque disponível
    }

}
