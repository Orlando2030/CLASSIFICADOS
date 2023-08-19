using BUSINESS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUSINESS.Interfaces
{
    public interface IEnderecoService : IDisposable
    {
        Task Adicionar(Endereco endereco);
        Task Atualizar(Endereco endereco);
        Task Remover(Guid id);
    }
}
