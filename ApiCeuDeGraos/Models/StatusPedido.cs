namespace ApiCeuDeGraos.Models
{
    // Classe modelo para a tabela "StatusPedidos"
    public class StatusPedido
    {
        public int StatusID { get; set; } // Chave primária
        public string StatusDescricao { get; set; } // Descrição do status (ex: "Em andamento", "Finalizado")
    }

}
