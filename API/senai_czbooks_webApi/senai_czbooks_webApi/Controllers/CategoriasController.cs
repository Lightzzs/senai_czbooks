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
    public class CategoriasController : ControllerBase
    {
        private ICategoriaRepository _categoriaRepository { get; set; }

        public CategoriasController()
        {
            _categoriaRepository = new CategoriaRepository();
        }

        [Authorize(Roles = "1")]
        [HttpPost]
        public IActionResult Post(Categoria novaCategoria)
        {

            _categoriaRepository.Cadastrar(novaCategoria);


            return StatusCode(201);
        }
    }
}
