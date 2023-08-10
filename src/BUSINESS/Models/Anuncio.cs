using BUSINESS.Models.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUSINESS.Models
{
    public class Anuncio : Entity
    {
        public Guid ID_Categoria { get; set; }
        public Guid ID_SubCategoria { get; set; }
        public Guid ID_Marca { get; set; }
        public Guid ID_Modelo { get; set; }
        public Guid ID_TipoAnucio { get; set; }
        public Guid ID_Usuario { get; set; }
        public Guid ID_Loja { get; set; }

        public string NomeAnuncio { get; set; }
        public string Descricao { get; set; }
        public decimal Valor_Antigo { get; set; }
        public decimal Valor { get; set; }
        public decimal Imagem { get; set; }
        public bool Status { get; set; }

        public int Ano { get; set; }
        public int Quilometragem { get; set; }
        public bool AceitaTroca { get; set; }
        public Direcao Direcao { get; set; }
        public Combustivel Combustivel { get; set; }

    }
}
