using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUSINESS.Models
{
    public class Entity
    {
        protected Entity()
        {
            Id = Guid.NewGuid();
            Dt_Cadastro = DateTime.Now;
        }
        public Guid Id { get; set; }

        public DateTime Dt_Cadastro { get; set; }
    }
}
