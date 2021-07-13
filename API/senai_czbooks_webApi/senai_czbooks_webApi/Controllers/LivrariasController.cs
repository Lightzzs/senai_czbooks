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
    public class LivrariasController : ControllerBase
    {
        private ILivrariaRepository _livrariaRepository { get; set; }

        public LivrariasController()
        {
            _livrariaRepository = new LivrariaRepository();
        }

        [Authorize(Roles = "1")]
        [HttpPost]
        public IActionResult Post(Livraria novaLivraria)
        {

            _livrariaRepository.Cadastrar(novaLivraria);


            return StatusCode(201);

        }
    }
}
