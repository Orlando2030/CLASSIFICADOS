using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUSINESS.Models
{
    public class Marca : Entity
    {
        public Guid ID_SubCategoria { get; set; }

        public string NomeMarca { get; set; }

        /* EF Relations */
        public SubCategoria SubCategoria { get; set; }
    }
}
