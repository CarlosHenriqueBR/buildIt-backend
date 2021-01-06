using System;
using System.Threading.Tasks;
using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BuildIt_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CaixaEletronicaController : ControllerBase
    {
        private readonly ICaixaEletronicaRepository _caixaEletronicaRepository;
        private readonly INotasRepository _notasRepository;
        public CaixaEletronicaController(ICaixaEletronicaRepository caixaEletronicaRepository, INotasRepository notasRepository)
        {
            _caixaEletronicaRepository = caixaEletronicaRepository;
            _notasRepository = notasRepository;
        }

        [HttpGet("verificar-notas-disponiveis")]
        public async Task<ActionResult> VerificarNotasDisponiveis()
        {
            try
            {
                var response = await _notasRepository.VerificarNotasDisponiveis();
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
