using BUSINESS.Interfaces;
using BUSINESS.Models;
using DATA.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA.Repository
{
    public class TipoAnuncioRepository : Repository<TipoAnuncio>, ITipoAnuncioRepository
    {
        public TipoAnuncioRepository(MeuDbContext db) : base(db)
        {
        }
    }
}
