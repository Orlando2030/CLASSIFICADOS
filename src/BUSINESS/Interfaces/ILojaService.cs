using BUSINESS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUSINESS.Interfaces
{
    public interface ILojaService : IDisposable
    {
        Task Adicionar(Loja loja);
        Task Atualizar(Loja loja);
        Task Remover(Guid id);
    }
}
