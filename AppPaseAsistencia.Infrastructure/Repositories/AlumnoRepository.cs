using AppPaseAsistencia.Domain.Entities;
using AppPaseAsistencia.Domain.Interfaces;
using AppPaseAsistencia.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPaseAsistencia.Infrastructure.Repositories
{
    public class AlumnoRepository : IAlumnoRepository
    {
        private readonly AppDbContext _context;

        public AlumnoRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Alumno?> GetByNiaAndCctAsync(string nia, string cct)
        {
            return await _context.Alumno
                .Include(a => a.Escuela)
                .FirstOrDefaultAsync(a => a.NIA == nia && a.Escuela.Cct == cct);
        }
    }
}
