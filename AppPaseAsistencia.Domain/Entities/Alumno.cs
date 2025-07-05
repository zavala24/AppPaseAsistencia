using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPaseAsistencia.Domain.Entities
{
    public class Alumno
    {
        [Key]
        public int IdAlumno { get; set; }
        [Required]
        public int IdEscuela { get; set; }
        public Escuela Escuela { get; set; } = null!;
        public string? ApellidoPat { get; set; }
        public string? ApellidoMat { get; set; }
        public string Nombres { get; set; } = null!;
        public string NIA { get; set; } = null!;
        public int Grado { get; set; }
        public string Grupo { get; set; } = null!;
        public string? CURP { get; set; }
        public string? Genero { get; set; }
        public bool Activo { get; set; }
        public int? UsuarioIns { get; set; }
        public DateTime FechaIns { get; set; }
        public int? UsuarioAct { get; set; }
        public DateTime? FechaAct { get; set; }
    }
}
