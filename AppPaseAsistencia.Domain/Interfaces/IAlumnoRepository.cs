using AppPaseAsistencia.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPaseAsistencia.Domain.Interfaces
{
    public interface IAlumnoRepository
    {
        Task<Alumno?> GetByNiaAndCctAsync(string nia, string cct);
    }
}
