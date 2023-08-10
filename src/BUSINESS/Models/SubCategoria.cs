using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUSINESS.Models
{
    public class SubCategoria : Entity
    {
        public Guid ID_Categoria { get; set; }

        public string NomeSubCategoria { get; set; }

        /* EF Relations */
        public IEnumerable<Marca> Marca { get; set; }
    }
}
