﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUSINESS.Models
{
    public class Mensagem : Entity
    {
        public Guid ID_Anuncio { get; set; }
        public Guid ID_Usuario { get; set; }

        public string DS_Mensagem { get; set; }

        /* EF Relations */
        public Anuncio Anuncio { get; set; }
        public Usuario Usuario { get; set; }
    }
}
