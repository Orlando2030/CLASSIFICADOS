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
    public class PedidoService : BaseService, IPedidoService
    {
        private readonly IPedidoRepository _pedidoRepository;

        public PedidoService(IPedidoRepository pedidoRepository,
                                INotificador notificador) : base(notificador)
        {
            _pedidoRepository = pedidoRepository;
        }

        public async Task Adicionar(Pedido pedido)
        {
            // Valida estado da entidade
            if (!ExecutarValidacao(new PedidoValidation(), pedido)) return;
            // Se passar pela validação
            await _pedidoRepository.Adicionar(pedido);
        }

        public async Task Atualizar(Pedido pedido)
        {
            // Valida estado da entidade
            if (!ExecutarValidacao(new PedidoValidation(), pedido)) return;
            // Se passar pela validação
            await _pedidoRepository.Atualizar(pedido);
        }

        public async Task Remover(Guid id)
        {
            await _pedidoRepository.Remover(id);  
        }

        public void Dispose()
        {
            _pedidoRepository.Dispose();
        }
    }
}
