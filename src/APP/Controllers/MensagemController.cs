using APP.ViewModels;
using AutoMapper;
using Business.Intefaces;
using BUSINESS.Interfaces;
using BUSINESS.Models;
using Microsoft.AspNetCore.Mvc;

namespace APP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MensagemController : MainController
    {
        private readonly IMensagemRepository _mensagemRepository;
        private readonly IMensagemService _mensagemService;
        private readonly IMapper _mapper;

        public MensagemController(INotificador notificador,
                                IMensagemRepository mensagemRepository,
                                IMensagemService mensagemService,     
                                IMapper mapper)  : base (notificador)
        {
            _mensagemRepository = mensagemRepository;
            _mensagemService = mensagemService;
            _mapper = mapper;   
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<MensagemViewModel>>> ObterTodos()
        {
            var mensagemViewModel = _mapper.Map<IEnumerable<MensagemViewModel>>(await _mensagemRepository.ObterTodos());
            if (mensagemViewModel == null) return NotFound();
            return Ok(mensagemViewModel);
        }

        [HttpGet("{id:guid}")]
        public async Task<ActionResult<MensagemViewModel>> ObterEnderecoPorId(Guid id)
        {
            var mensagemViewModel = _mapper.Map<MensagemViewModel>(await ObterMensagem(id));
            if (mensagemViewModel == null) return NotFound();

            return mensagemViewModel;
        }

        [HttpPost("adicionar-loja")]
        public async Task<ActionResult<MensagemViewModel>> AdcionarEndereco([FromBody] MensagemViewModel mensagemViewModel)
        {
            if (!ModelState.IsValid) return NotFound();

            mensagemViewModel.Dt_Cadastro = DateTime.Now;
            //usuarioViewModel.Email = this.User.Claims.ToList()[4].Value;

            await _mensagemService.Adicionar(_mapper.Map<Mensagem>(mensagemViewModel));
            return CustomResponse(mensagemViewModel);
        }

        [HttpPut("editar-loja/{id:guid}")]
        public async Task<ActionResult<MensagemViewModel>> Editar(Guid id, [FromBody] MensagemViewModel mensagemViewModel)
        {
            if (id != mensagemViewModel.Id) return NotFound();
            if (!ModelState.IsValid) return NotFound();

            await _mensagemService.Atualizar(_mapper.Map<Mensagem>(mensagemViewModel));
            return CustomResponse(mensagemViewModel);
        }

        [HttpDelete("excluir-loja/{id:guid}")]
        public async Task<ActionResult<MensagemViewModel>> Excluir(Guid id)
        {
            var mensagemViewModel = await ObterMensagem(id);
            if (mensagemViewModel == null) return NotFound();


            await _mensagemService.Remover(id);
            return CustomResponse(mensagemViewModel);
        }

        private async Task<MensagemViewModel> ObterMensagem(Guid id)
        {
            return _mapper.Map<MensagemViewModel>(await _mensagemRepository.ObterPorId(id));
        }
    }
}
