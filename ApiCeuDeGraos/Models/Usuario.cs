namespace ApiCeuDeGraos.Models
{
    // Classe modelo para a tabela "BDusuario"
    public class Usuario
    {
        public int UsuarioID { get; set; } // Chave primária
        public string Nome { get; set; } // Nome do usuário
        public string Email { get; set; } // Email do usuário (único)
        public string CPF_CNPJ { get; set; } // CPF ou CNPJ do usuário (único)
        public string Senha { get; set; } // Senha de acesso
        public DateTime DataCadastro { get; set; } = DateTime.Now; // Data de cadastro (padrão: data atual)
        public string Endereco { get; set; } // Endereço do usuário
        public string TipoUsuario { get; set; } // Tipo de usuário (ex: administrador, cliente)
        public bool Ativo { get; set; } = true; // Status ativo/inativo do usuário
    }


}
