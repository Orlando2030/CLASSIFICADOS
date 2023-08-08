using BUSINESS.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA.Context
{
    public class MeuDbContext : DbContext
    {
        public MeuDbContext(DbContextOptions<MeuDbContext> options) : base(options)
        {
            
        }

        public DbSet<Anuncio> Anuncios { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<SubCategoria> SubCategorias { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Loja> Lojas { get; set; }
        public DbSet<Marca> Marcas { get; set; }
        public DbSet<Mensagem> Mensagens { get; set; }
        public DbSet<Modelo> Modelos { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<TipoAnuncio> TiposAnuncios { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

    }

}
