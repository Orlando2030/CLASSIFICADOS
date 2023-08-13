using BUSINESS.Interfaces;
using BUSINESS.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA.Repository
{
    public class CategoriaRepository : Repository<Categoria>, ICategoriaRepository
    {
        public CategoriaRepository(DbSet<Categoria> dbSet) : base(dbSet)
        {
        }
    }
}
