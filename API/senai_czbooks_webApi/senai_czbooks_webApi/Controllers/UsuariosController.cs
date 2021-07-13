using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using senai_czbooks_webApi.Domains;
using senai_czbooks_webApi.Interfaces;
using senai_czbooks_webApi.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_czbooks_webApi.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]

    
    public class UsuariosController : ControllerBase
    {
        private IUsuarioRepository _usuarioRepository { get; set; }
        public UsuariosController()
        {
            _usuarioRepository = new UsuarioRepository();
        }

        [Authorize(Roles = "1")]
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_usuarioRepository.Listar());
            }
            catch (Exception erro)
            {
                return BadRequest(erro);
            }
        }

        [Authorize(Roles = "1")]
        [HttpPost]
        public IActionResult Post(Usuario novoUsuario)
        {
            try
            {
          
                _usuarioRepository.Cadastrar(novoUsuario);

                return StatusCode(201);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

    

    }
}
