using System.ComponentModel.DataAnnotations;

namespace APP.ViewModels
{
    public class MensagemViewModel
    {
        [Key]
        public Guid Id { get; set; }

        public Guid ID_Anuncio { get; set; }
        public Guid ID_Usuario { get; set; }

        public string DS_Mensagem { get; set; }

        public DateTime Dt_Cadastro { get; set; }
    }
}
