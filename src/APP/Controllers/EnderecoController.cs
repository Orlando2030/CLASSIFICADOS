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
    public class EnderecoController : MainController
    {
        private readonly IEnderecoRepository _enderecoRepository;
        private readonly IEnderecoService _enderecoService;
        private readonly IMapper _mapper;

        public EnderecoController(INotificador notificador, 
                                IEnderecoRepository enderecoRepository,
                                IEnderecoService enderecoService,     
                                IMapper mapper)  : base (notificador)
        {
            _enderecoRepository = enderecoRepository;
            _enderecoService = enderecoService;
            _mapper = mapper;   
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<EnderecoViewModel>>> ObterTodos()
        {
            var enderecoViewModel = _mapper.Map<IEnumerable<EnderecoViewModel>>(await _enderecoRepository.ObterTodos());
            if (enderecoViewModel == null) return NotFound();
            return Ok(enderecoViewModel);
        }

        [HttpGet("{id:guid}")]
        public async Task<ActionResult<EnderecoViewModel>> ObterEnderecoPorId(Guid id)
        {
            var enderecoViewModel = _mapper.Map<EnderecoViewModel>(await ObterEndereco(id));
            if (enderecoViewModel == null) return NotFound();

            return enderecoViewModel;
        }

        [HttpPost("adicionar-endereco")]
        public async Task<ActionResult<EnderecoViewModel>> AdcionarEndereco([FromBody] EnderecoViewModel enderecoViewModel)
        {
            if (!ModelState.IsValid) return NotFound();

            enderecoViewModel.Dt_Cadastro = DateTime.Now;
            //usuarioViewModel.Email = this.User.Claims.ToList()[4].Value;

            await _enderecoService.Adicionar(_mapper.Map<Endereco>(enderecoViewModel));
            return CustomResponse(enderecoViewModel);
        }

        [HttpPut("editar-endereco/{id:guid}")]
        public async Task<ActionResult<EnderecoViewModel>> Editar(Guid id, [FromBody] EnderecoViewModel enderecoViewModel)
        {
            if (id != enderecoViewModel.Id) return NotFound();
            if (!ModelState.IsValid) return NotFound();

            await _enderecoService.Atualizar(_mapper.Map<Endereco>(enderecoViewModel));
            return CustomResponse(enderecoViewModel);
        }

        [HttpDelete("excluir-endereco/{id:guid}")]
        public async Task<ActionResult<EnderecoViewModel>> Excluir(Guid id)
        {
            var enderecoViewModel = await ObterEndereco(id);
            if (enderecoViewModel == null) return NotFound();


            await _enderecoService.Remover(id);
            return CustomResponse(enderecoViewModel);
        }

        private async Task<EnderecoViewModel> ObterEndereco(Guid id)
        {
            return _mapper.Map<EnderecoViewModel>(await _enderecoRepository.ObterPorId(id));
        }
    }
}
