using AppPaseAsistencia.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPaseAsistencia.Domain.Interfaces
{
    public interface IEscuelaRepository
    {
        Task<bool> ExistsByIdAsync(int idEscuela);
        Task<Escuela?> GetByCctAsync(string cct);
    }
}
