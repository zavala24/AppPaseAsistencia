using AppPaseAsistencia.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPaseAsistencia.Application.Interfaces
{
    public interface IAlumnoService
    {
        Task<AlumnoDto?> GetByNiaAndCctAsync(string nia, string cct);
    }
}
