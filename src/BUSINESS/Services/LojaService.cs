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
    public class LojaService : BaseService, ILojaService
    {

        private readonly ILojaRepository _lojaRepository;

        public LojaService( ILojaRepository lojaRepository,
                            INotificador notificador) : base(notificador)
        {
            _lojaRepository = lojaRepository;
        }

        public async Task Adicionar(Loja loja)
        {
            // Valida estado da entidade
            if (!ExecutarValidacao(new LojaValidation(), loja)) return;
            // Se passar pela validação
            await _lojaRepository.Adicionar(loja);
        }

        public async Task Atualizar(Loja loja)
        {
            // Valida estado da entidade
            if (!ExecutarValidacao(new LojaValidation(), loja)) return;
            // Se passar pela validação
            await _lojaRepository.Atualizar(loja);
        }

        public async Task Remover(Guid id)
        {
            await _lojaRepository.Remover(id);
        }

        public void Dispose()
        {
            _lojaRepository?.Dispose();
        }
    }
}
