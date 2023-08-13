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
    public class LojaRepository : Repository<Loja>, ILojaRepository
    {
        public LojaRepository(MeuDbContext db) : base(db)
        {
        }
    }
}
