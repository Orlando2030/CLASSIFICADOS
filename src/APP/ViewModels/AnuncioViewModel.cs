using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace APP.ViewModels
{
    public class AnuncioViewModel
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(100, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string NomeAnuncio { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(14, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 11)]
        public string Descricao { get; set; }

        [DisplayName("Valor")]
        public int Valor_Antigo { get; set; }

        [DisplayName("Ativo?")]
        public bool Status { get; set; }

    }

}
