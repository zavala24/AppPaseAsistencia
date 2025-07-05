using AutoMapper;
using AppPaseAsistencia.Domain.Entities; // Ajusta según tus namespaces
using AppPaseAsistencia.Application.DTOs; // Ajusta según donde estén tus DTOs

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Alumno, AlumnoDto>();
        CreateMap<Escuela, EscuelaDto>();
    }
}