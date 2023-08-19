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
    public class UsuarioController : MainController
    {
        private readonly IUsuarioRepository _usuarioRepository;
        private readonly IUsuarioService _usuarioService;
        private readonly IMapper _mapper;

        public UsuarioController(INotificador notificador, 
                                IUsuarioRepository usuarioRepository,
                                IUsuarioService usuarioService,     
                                IMapper mapper)  : base (notificador)
        {
            _usuarioRepository = usuarioRepository;
            _usuarioService = usuarioService;
            _mapper = mapper;   
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<UsuarioViewModel>>> ObterTodos()
        {
            var usuariosViewModel = _mapper.Map<IEnumerable<UsuarioViewModel>>(await _usuarioRepository.ObterTodos());
            if (usuariosViewModel == null) return NotFound();
            return Ok(usuariosViewModel);
        }

        [HttpGet("{id:guid}")]
        public async Task<ActionResult<UsuarioViewModel>> ObterUsuarioPorId(Guid id)
        {
            var usuarioViewModel = _mapper.Map<UsuarioViewModel>(await ObterUsuario(id));
            if (usuarioViewModel == null) return NotFound();

            return usuarioViewModel;
        }

        [HttpPost("adicionar-usuario")]
        public async Task<ActionResult<UsuarioViewModel>> AdcionarUsuario([FromBody] UsuarioViewModel usuarioViewModel)
        {
            if (!ModelState.IsValid) return NotFound();

            usuarioViewModel.Dt_Cadastro = DateTime.Now;
            //usuarioViewModel.Email = this.User.Claims.ToList()[4].Value;

            await _usuarioService.Adicionar(_mapper.Map<Usuario>(usuarioViewModel));
            return CustomResponse(usuarioViewModel);
        }

        [HttpPut("editar-usuario/{id:guid}")]
        public async Task<ActionResult<UsuarioViewModel>> Editar(Guid id, [FromBody] UsuarioViewModel usuarioViewModel)
        {
            if (id != usuarioViewModel.Id) return NotFound();
            if (!ModelState.IsValid) return NotFound();

            await _usuarioService.Atualizar(_mapper.Map<Usuario>(usuarioViewModel));
            return CustomResponse(usuarioViewModel);
        }

        [HttpDelete("excluir-usuario/{id:guid}")]
        public async Task<ActionResult<UsuarioViewModel>> Excluir(Guid id)
        {
            var usuarioViewModel = await ObterUsuario(id);
            if (usuarioViewModel == null) return NotFound();


            await _usuarioService.Remover(id);
            return CustomResponse(usuarioViewModel);
        }

        private async Task<UsuarioViewModel> ObterUsuario(Guid id)
        {
            return _mapper.Map<UsuarioViewModel>(await _usuarioRepository.ObterPorId(id));
        }
    }
}
