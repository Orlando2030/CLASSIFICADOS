using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using BUSINESS.Models.Enum;

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

        public Guid ID_Categoria { get; set; }
        public Guid ID_SubCategoria { get; set; }
        public Guid ID_Marca { get; set; }
        public Guid ID_Modelo { get; set; }
        public Guid ID_TipoAnucio { get; set; }
        public Guid ID_Usuario { get; set; }
        public Guid ID_Loja { get; set; }

        public decimal Valor { get; set; }
        public decimal Imagem { get; set; }

        public int Ano { get; set; }
        public int Quilometragem { get; set; }
        public bool AceitaTroca { get; set; }
        public Direcao Direcao { get; set; }
        public Combustivel Combustivel { get; set; }

        public DateTime Dt_Cadastro { get; set; }

    }

}
