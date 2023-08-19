using BUSINESS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUSINESS.Interfaces
{
    public interface IAnuncioService : IDisposable
    {
        Task Adicionar(Anuncio anuncio);
        Task Atualizar(Anuncio anuncio);
        Task Remover(Guid id);
    }
}
