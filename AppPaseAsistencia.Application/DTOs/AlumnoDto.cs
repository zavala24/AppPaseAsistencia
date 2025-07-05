using AppPaseAsistencia.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPaseAsistencia.Application.DTOs
{
    public class AlumnoDto
    {
        public int IdAlumno { get; set; }

        public string NIA { get; set; } = null!;

        public string? ApellidoPat { get; set; }

        public string? ApellidoMat { get; set; }

        public string Nombres { get; set; } = null!;

        public int Grado { get; set; }

        public string Grupo { get; set; } = null!;

        public string? CURP { get; set; }

        public string? Genero { get; set; }

        public bool Activo { get; set; }

        public EscuelaDto Escuela { get; set; } = null!;
    }
}
