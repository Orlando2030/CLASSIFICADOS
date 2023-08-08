using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUSINESS.Models
{
    public class Loja : Entity
    {
        public Guid ID_Endereco { get; set; }
        public Guid ID_Usuario { get; set; }

        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Whatsapp { get; set; }

        /* EF Relations */
        public Endereco Endereco { get; set; }
        public Usuario Usuario { get; set; }
    }
}
