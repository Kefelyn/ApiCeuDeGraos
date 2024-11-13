namespace ApiCeuDeGraos.Models
{
    // Classe modelo para a tabela "ProducoesP"
    public class Producao
    {
        public int ProducaoID { get; set; } // Chave primária
        public int ProdutoID { get; set; } // ID do produto (chave estrangeira)
        public string NomeProduto { get; set; } // Nome do produto produzido
        public DateTime DataPlantio { get; set; } // Data do plantio
        public DateTime? DataColheita { get; set; } // Data da colheita (pode ser nula)
        public string Status { get; set; } // Status da produção (ex: "Plantado", "Colhido")
        public int QuantidadePlantada { get; set; } // Quantidade plantada

        // Relacionamento 
        public Produto Produto { get; set; } // Relacionamento com a tabela de produtos
    }

}
