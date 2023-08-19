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
    public class AnuncioController : MainController
    {
        private readonly IAnuncioRepository _anuncioRepository;
        private readonly IAnuncioService _anuncioService;
        private readonly IMapper _mapper;

        public AnuncioController(INotificador notificador, 
                                IAnuncioRepository anuncioRepository,
                                IAnuncioService anuncioService,     
                                IMapper mapper)  : base (notificador)
        {
            _anuncioRepository = anuncioRepository;
            _anuncioService = anuncioService;
            _mapper = mapper;   
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<AnuncioViewModel>>> ObterTodos()
        {
            var anunciosViewModel = _mapper.Map<IEnumerable<AnuncioViewModel>>(await _anuncioRepository.ObterTodos());
            if (anunciosViewModel == null) return NotFound();
            return Ok(anunciosViewModel);
        }

        [HttpGet("{id:guid}")]
        public async Task<ActionResult<AnuncioViewModel>> ObterAnunciosPorId(Guid id)
        {
            var anuncioViewModel = _mapper.Map<AnuncioViewModel>(await ObterAnuncio(id));
            if (anuncioViewModel == null) return NotFound();

            return anuncioViewModel;
        }

        [HttpPost("adicionar-anuncio")]
        public async Task<ActionResult<AnuncioViewModel>> AdcionarUsuario([FromBody] AnuncioViewModel anuncioViewModel)
        {
            if (!ModelState.IsValid) return NotFound();

            anuncioViewModel.Dt_Cadastro = DateTime.Now;
            //usuarioViewModel.Email = this.User.Claims.ToList()[4].Value;

            await _anuncioService.Adicionar(_mapper.Map<Anuncio>(anuncioViewModel));
            return CustomResponse(anuncioViewModel);
        }

        [HttpPut("editar-anuncio/{id:guid}")]
        public async Task<ActionResult<AnuncioViewModel>> Editar(Guid id, [FromBody] AnuncioViewModel anuncioViewModel)
        {
            if (id != anuncioViewModel.Id) return NotFound();
            if (!ModelState.IsValid) return NotFound();

            await _anuncioService.Atualizar(_mapper.Map<Anuncio>(anuncioViewModel));
            return CustomResponse(anuncioViewModel);
        }

        [HttpDelete("excluir-anuncio/{id:guid}")]
        public async Task<ActionResult<UsuarioViewModel>> Excluir(Guid id)
        {
            var anuncioViewModel = await ObterAnuncio(id);
            if (anuncioViewModel == null) return NotFound();


            await _anuncioService.Remover(id);
            return CustomResponse(anuncioViewModel);
        }

        private async Task<AnuncioViewModel> ObterAnuncio(Guid id)
        {
            return _mapper.Map<AnuncioViewModel>(await _anuncioRepository.ObterPorId(id));
        }
    }
}
