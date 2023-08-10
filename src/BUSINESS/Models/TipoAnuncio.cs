using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUSINESS.Models
{
    public class TipoAnuncio : Entity
    {
        public string NomeTipoAnuncio { get; set; }
        public int Duracao { get; set; }
        public decimal Valor { get; set; }

        public Anuncio Anuncio { get; set; }
    }
}
