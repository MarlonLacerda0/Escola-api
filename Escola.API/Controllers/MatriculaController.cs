using Escola.Application.DTOs.Matricula;
using Escola.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Escola.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MatriculaController : Controller
    {
        private readonly IMatriculaService _matriculaService;
        public MatriculaController(IMatriculaService matriculaService)
        {
            _matriculaService = matriculaService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllMatriculas()
        {
            var matriculas = await _matriculaService.GetAllAsync();
            return Ok(matriculas);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetMatriculaById(int id)
        {
            var matricula = await _matriculaService.GetByIdAsync(id);
            if (matricula == null)
                return NotFound("Matrícula não encontrada.");
            return Ok(matricula);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMatricula(int id)
        {
            var deletedMatricula = await _matriculaService.DeleteAsync(id);
            if (deletedMatricula == null)
                return BadRequest("Matrícula não encontrada para exclusão.");
            return Ok(new { message = "Matrícula excluída com Sucesso" });
        }

        [HttpPost]
        public async Task<IActionResult> CreateMatricula(MatriculaPostDTO matriculaPostDTO)
        {
            var createdMatricula = await _matriculaService.AddAsync(matriculaPostDTO);
            if (createdMatricula == null)
                return BadRequest("Não foi possível criar a matrícula.");
            return Ok(new { message = "Matrícula incluída com Sucesso" });
        }

        [HttpPut]
        public async Task<IActionResult> UpdateMatricula(MatriculaPutDTO matriculaPutDTO)
        {
            var updatedMatricula = await _matriculaService.UpdateAsync(matriculaPutDTO);
            if (updatedMatricula == null)
                return BadRequest("Matrícula não encontrada para atualização.");
            return Ok(new { message = "Matrícula atualizada com Sucesso" });
        }
    }
}
