using Business.Intefaces;
using BUSINESS.Interfaces;
using BUSINESS.Models;
using BUSINESS.Models.Validations;

namespace BUSINESS.Services
{
    public class AnuncioService : BaseService, IAnuncioService
    {
        private readonly IAnuncioRepository _anuncioRepository;

        public AnuncioService(IAnuncioRepository anuncioRepository,
                              INotificador notificador) : base(notificador)
        {
            _anuncioRepository = anuncioRepository;
        }

        public async Task Adicionar(Anuncio anuncio)
        {
            // Valida estado da entidade
            if (!ExecutarValidacao(new AnuncioValidation(), anuncio)) return;
            // Se passar pela validação
            await _anuncioRepository.Adicionar(anuncio);
        }

        public async Task Atualizar(Anuncio anuncio)
        {
            // Valida estado da entidade
            if (!ExecutarValidacao(new AnuncioValidation(), anuncio)) return;
            // Se passar pela validação
            await _anuncioRepository.Atualizar(anuncio);
        }

        public async Task Remover(Guid id)
        {
            await _anuncioRepository.Remover(id);
        }

        public void Dispose()
        {
            _anuncioRepository?.Dispose();
        }
    }
}
