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
    public class LojaController : MainController
    {
        private readonly ILojaRepository _lojaRepository;
        private readonly ILojaService _lojaService;
        private readonly IMapper _mapper;

        public LojaController(INotificador notificador, 
                                ILojaRepository lojaRepository,
                                ILojaService lojaService,     
                                IMapper mapper)  : base (notificador)
        {
            _lojaRepository = lojaRepository;
            _lojaService = lojaService;
            _mapper = mapper;   
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<LojaViewModel>>> ObterTodos()
        {
            var lojaViewModel = _mapper.Map<IEnumerable<LojaViewModel>>(await _lojaRepository.ObterTodos());
            if (lojaViewModel == null) return NotFound();
            return Ok(lojaViewModel);
        }

        [HttpGet("{id:guid}")]
        public async Task<ActionResult<LojaViewModel>> ObterEnderecoPorId(Guid id)
        {
            var lojaViewModel = _mapper.Map<LojaViewModel>(await ObterLoja(id));
            if (lojaViewModel == null) return NotFound();

            return lojaViewModel;
        }

        [HttpPost("adicionar-loja")]
        public async Task<ActionResult<LojaViewModel>> AdcionarEndereco([FromBody] LojaViewModel lojaViewModel)
        {
            if (!ModelState.IsValid) return NotFound();

            lojaViewModel.Dt_Cadastro = DateTime.Now;
            //usuarioViewModel.Email = this.User.Claims.ToList()[4].Value;

            await _lojaService.Adicionar(_mapper.Map<Loja>(lojaViewModel));
            return CustomResponse(lojaViewModel);
        }

        [HttpPut("editar-loja/{id:guid}")]
        public async Task<ActionResult<LojaViewModel>> Editar(Guid id, [FromBody] LojaViewModel lojaViewModel)
        {
            if (id != lojaViewModel.Id) return NotFound();
            if (!ModelState.IsValid) return NotFound();

            await _lojaService.Atualizar(_mapper.Map<Loja>(lojaViewModel));
            return CustomResponse(lojaViewModel);
        }

        [HttpDelete("excluir-loja/{id:guid}")]
        public async Task<ActionResult<LojaViewModel>> Excluir(Guid id)
        {
            var lojaViewModel = await ObterLoja(id);
            if (lojaViewModel == null) return NotFound();


            await _lojaService.Remover(id);
            return CustomResponse(lojaViewModel);
        }

        private async Task<LojaViewModel> ObterLoja(Guid id)
        {
            return _mapper.Map<LojaViewModel>(await _lojaRepository.ObterPorId(id));
        }
    }
}
