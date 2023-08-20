using System.ComponentModel.DataAnnotations;

namespace APP.ViewModels
{
    public class MensagemViewModel
    {
        public Guid ID_Anuncio { get; set; }
        public Guid ID_Usuario { get; set; }

        public string DS_Mensagem { get; set; }
    }
}
