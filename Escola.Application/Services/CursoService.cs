using Escola.Application.DTOs.Curso;
using Escola.Application.Interfaces;
using Escola.Domain.Entities;
using Escola.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Escola.Application.Services
{
    public class CursoService : ICursoService
    {
        private readonly ICursoRepository _cursoRepository;
        public CursoService(ICursoRepository cursoRepository)
        {
            _cursoRepository = cursoRepository;
        }
        public async Task<CursoGetDTO> AddAsync(CursoPostDTO cursoPostDTO)
        {
            var curso = new Curso
            {
                Nome = cursoPostDTO.Nome,
                Descricao = cursoPostDTO.Descricao
            };
            var createdCurso = await _cursoRepository.AddAsync(curso);
            return new CursoGetDTO
            {
                Id = createdCurso.Id,
                Nome = createdCurso.Nome,
                Descricao = createdCurso.Descricao
            };
        }

        public Task<CursoGetDTO> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<CursoGetDTO>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<CursoGetDTO> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<CursoGetDTO> UpdateAsync(CursoPutDTO cursoPutDTO)
        {
            throw new NotImplementedException();
        }
    }
}
