using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_CRUD.Repository;
using Microsoft.AspNetCore.Mvc;

namespace API_CRUD.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioRepository _repository;

        public UsuarioController(IUsuarioRepository repository)
        {
            _repository = repository;
        }
        [HttpGet]

        public async Task<IActionResult> Get()
        {
            var usuarios = await _repository.BuscaUsuarios();
            return usuarios.Any()
                ? Ok(usuarios)
                : NoContent();
        }
    }
}