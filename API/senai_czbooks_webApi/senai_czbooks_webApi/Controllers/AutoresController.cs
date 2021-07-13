using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
    public class AutoresController : ControllerBase
    {
        private IAutoresRepository _autoresRepository;

        public AutoresController()
        {
            _autoresRepository = new AutoresRepository();
        }


        [Authorize(Roles = "1, 2")]
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_autoresRepository.Listar());
            }
            catch (Exception codErro)
            {
                return BadRequest(codErro);
            }
        }
    }
}
