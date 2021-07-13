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
    public class LivrosController : ControllerBase
    {
        private ILivroRepository _livroRepository { get; set; }

        public LivrosController()
        {
            _livroRepository = new LivroRepository();
        }

        [Authorize(Roles = "2")]
        [HttpGet]

        public IActionResult Get()
        {
            try
            {
                return Ok(_livroRepository.ListarTodos());
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [Authorize(Roles = "1")]
        [HttpPost]
        public IActionResult Post(Livro novoLivro)
        {

            _livroRepository.Cadastrar(novoLivro);


            return StatusCode(201);
        }

    }
}
