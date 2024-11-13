namespace ApiCeuDeGraos.Models
{
    public class Producao
    {
        public int ProducaoID { get; set; }
        public int ProdutoID { get; set; }
        public string NomeProduto { get; set; }
        public DateTime DataPlantio { get; set; }
        public DateTime? DataColheita { get; set; }
        public string Status { get; set; }
        public int QuantidadePlantada { get; set; }

        // Relacionamento
        public Produto Produto { get; set; }
    }

}
