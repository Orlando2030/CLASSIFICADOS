using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUSINESS.Models
{
    public class Usuario : Entity
    {


        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }

        public Anuncio Anuncio { get; set; }

    }
}
