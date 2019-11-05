using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SENAI.Cleverland.Domains;
using SENAI.Cleverland.Interfaces;
using SENAI.Cleverland.Repositories;

namespace SENAI.Cleverland.Controlers
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    [ApiController]
    public class MedicosController : ControllerBase
    {
        private IMedicoRepository MedicoRepository { get; set; }

        public MedicosController()
        {
            MedicoRepository = new MedicoRepository();
        }

        [HttpGet]
        public IActionResult Listar()
        {
            return Ok(MedicoRepository.ListarMedicos());
        }
        [HttpPost]
        public IActionResult Cadastrar(Medicos medico)
        {
            MedicoRepository.CadastrarMedico(medico);
            return Ok();
        }
    }
}