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
    public class MensagemService : BaseService, IMensagemService
    {
        private readonly IMensagemRepository _mensagemRepository;

        public MensagemService(IMensagemRepository mensagemRepository,
        INotificador notificador) : base(notificador)
        {
            _mensagemRepository = mensagemRepository;
        }

        public async Task Adicionar(Mensagem mensagem)
        {
            // Valida estado da entidade
            if (!ExecutarValidacao(new MensagemValidation(), mensagem)) return;
            // Se passar pela validação
            await _mensagemRepository.Adicionar(mensagem);
        }

        public async Task Atualizar(Mensagem mensagem)
        {
            // Valida estado da entidade
            if (!ExecutarValidacao(new MensagemValidation(), mensagem)) return;
            // Se passar pela validação
            await _mensagemRepository.Atualizar(mensagem);
        }

        public async Task Remover(Guid id)
        {
           await  _mensagemRepository.Remover(id);    
        }

        public void Dispose()
        {
            _mensagemRepository.Dispose();
        }
    }
}
