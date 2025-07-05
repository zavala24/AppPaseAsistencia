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
    public class EscuelaRepository : IEscuelaRepository
    {
        private readonly AppDbContext _context;

        public EscuelaRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<bool> ExistsByIdAsync(int idEscuela)
        {
            return await _context.Escuela.AnyAsync(e => e.IdEscuela == idEscuela);
        }

        public async Task<Escuela?> GetByCctAsync(string cct)
        {
            return await _context.Escuela.FirstOrDefaultAsync(e => e.Cct == cct);
        }
    }
}
