using AppPaseAsistencia.Application.DTOs;
using AppPaseAsistencia.Application.Interfaces;
using AppPaseAsistencia.Domain.Entities;
using AppPaseAsistencia.Domain.Interfaces;
using AutoMapper;


namespace AppPaseAsistencia.Application.Services
{
    public class AlumnoService : IAlumnoService
    {
        private readonly IAlumnoRepository _alumnoRepository;
        private readonly IMapper _mapper;

        public AlumnoService(IAlumnoRepository alumnoRepository, IMapper mapper)
        {
            _alumnoRepository = alumnoRepository;
            _mapper = mapper;
        }

        public async Task<AlumnoDto?> GetByNiaAndCctAsync(string nia, string cct)
        {
            var alumno = await _alumnoRepository.GetByNiaAndCctAsync(nia, cct);
            return alumno is null ? null : _mapper.Map<AlumnoDto>(alumno);
        }
    }
}
