using Exo.WebApi.Models;
using Exo.WebApi.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Exo.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjetosController : ControllerBase
    {
        private readonly ProjetoRepository _projetoRepository;
        public ProjetosController(ProjetoRepository projetoRepository)
        {
            _projetoRepository = projetoRepository;
        }

        [HttpGet]
        public IActionResult Listar()
        {
            return Ok(_projetoRepository.Listar());
        }

        // codigo novo quecompleta o CRUD.
        [HttpPost]
        public IActionResult Cadastrar(Projeto projeto)
        {
            _projetoRepository.Cadastrar(Projeto projeto)
            {
                _projetoRepository.Cadastrar(projeto);
                return StatusCode(201);
            }
            [HttpGet("{id}")]
            public IActionResult BuscarPorId(int id)
            {
                Projeto projeto = projetoRepository.BuscarPorId(id);
                if (projeto == null)
                {
                    return NotFound();
                }
                return Ok(projeto);
            }

            [HttpsPut("{id}")]
            public IActionResult Atualizar(int id, Projeto projeto)
            {
                _projetoRepository.Atualizar(id, projetos);
                return StatusCode(204);
            }

            [HttpDelete("{id}")]
            public IActionResult Deletar(int id)
            {
                try
                {
                    _projetoRepository.Deletar(id);
                    retur StatusCode(204);
                }
                catch (Exception e)
                {
                    
                  return BadRequest();
                }
            }
        }
    }
}
