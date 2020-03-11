using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Senai.Senatur.WebApi.Domains;
using Senai.Senatur.WebApi.Interfaces;
using Senai.Senatur.WebApi.Repositories;
// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860
namespace Senai.Senatur.WebApi.Controllers
{

    [Produces("application/json")]

    [Route("api/[controller]")]

    [ApiController]

    public class PacoteController : ControllerBase
    {
        private IPacoteRepository _pacoteRepository;
        public PacoteController()
        {
            _pacoteRepository = new PacotesRepository();
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_pacoteRepository.Listar());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(_pacoteRepository.BuscarPorId(id));
        }

        [Authorize(Roles = "1")]
        [HttpPost]
        public IActionResult Post(Pacotes novoPacote)
        {
            _pacoteRepository.Cadastrar(novoPacote);
            return StatusCode(201);
        }

        [Authorize(Roles = "1")]
        [HttpPut("{id}")]
        public IActionResult Put(int id, Pacotes pacoteAtualizado)
        {
            _pacoteRepository.Atualizar(id, pacoteAtualizado);
            return StatusCode(204);
        }
    }
}