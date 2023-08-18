using Business.Intefaces;
using BUSINESS.Interfaces;
using BUSINESS.Models;
using BUSINESS.Models.Validations;

namespace BUSINESS.Services
{
    public class UsuarioService : BaseService, IUsuarioService
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioService(IUsuarioRepository usuarioRepository,
                              INotificador notificador) : base(notificador)
        {
            _usuarioRepository = usuarioRepository;
        }

        public async Task Adicionar(Usuario usuario)
        {
            // Valida estado da entidade
            if (!ExecutarValidacao(new UsuarioValidation(), usuario)) return;
            // Se passar pela validação
            await _usuarioRepository.Adicionar(usuario);
        }

        public async Task Atualizar(Usuario usuario)
        {
            // Valida estado da entidade
            if (!ExecutarValidacao(new UsuarioValidation(), usuario)) return;
            // Se passar pela validação
            await _usuarioRepository.Atualizar(usuario);
        }

        public async Task Remover(Guid id)
        {
            await _usuarioRepository.Remover(id);
        }

        public void Dispose()
        {
            _usuarioRepository?.Dispose();
        }
    }
}
