using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUSINESS.Models
{
    public class Pedido : Entity
    {
        public Guid ID_Anuncio { get; set; }

        /* EF Relations */
        public Anuncio Anuncio { get; set; }
    }
}
