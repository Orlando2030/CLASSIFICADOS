using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUSINESS.Models
{
    public class Modelo : Entity
    {
        public Guid ID_Marca { get; set; }

        public string NomeModelo { get; set; }

        /* EF Relations */
        public Marca Marca { get; set; }
    }
}
