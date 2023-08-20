using System.ComponentModel.DataAnnotations;

namespace APP.ViewModels
{
    public class LojaViewModel
    {
        public Guid ID_Usuario { get; set; }

        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Whatsapp { get; set; }

        public string Rua { get; set; }
        public string Bairro { get; set; }
        public int Numero { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Cep { get; set; }
    }
}
