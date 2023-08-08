using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUSINESS.Models
{
    public class Usuario : Entity
    {
        public Guid ID_Endereco { get; set; }

        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }

        /* EF Relations */
        public Endereco Endereco { get; set; }

    }
}
