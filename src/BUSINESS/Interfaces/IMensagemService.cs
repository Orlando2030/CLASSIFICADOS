using BUSINESS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUSINESS.Interfaces
{
    public interface IMensagemService : IDisposable
    {
        Task Adicionar(Mensagem mensagem);
        Task Atualizar(Mensagem mensagem);
        Task Remover(Guid id);
    }
}
