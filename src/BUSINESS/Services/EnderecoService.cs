using Business.Intefaces;
using BUSINESS.Interfaces;
using BUSINESS.Models;
using BUSINESS.Models.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUSINESS.Services
{
    public class EnderecoService : BaseService, IEnderecoService
    {
        private readonly IEnderecoRepository _enderecoRepository;

        public EnderecoService(IEnderecoRepository enderecoRepository,
                              INotificador notificador) : base(notificador)
        {
            _enderecoRepository = enderecoRepository;
        }

        public async Task Adicionar(Endereco endereco)
        {
            // Valida estado da entidade
            if (!ExecutarValidacao(new EnderecoValidation(), endereco)) return;
            // Se passar pela validação
            await _enderecoRepository.Adicionar(endereco);
        }

        public async Task Atualizar(Endereco endereco)
        {
            // Valida estado da entidade
            if (!ExecutarValidacao(new EnderecoValidation(), endereco)) return;
            // Se passar pela validação
            await _enderecoRepository.Atualizar(endereco);
        }

        public async Task Remover(Guid id)
        {
            await _enderecoRepository.Remover(id);
        }

        public void Dispose()
        {
            _enderecoRepository?.Dispose();
        }
    }
}
