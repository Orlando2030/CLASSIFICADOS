using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUSINESS.Models
{
    public class Categoria : Entity
    {

        public string NomeCategoria { get; set; }

        /* EF Relations */
        public IEnumerable<SubCategoria> SubCategoria { get; set; }

    }
}
