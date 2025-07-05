using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPaseAsistencia.Domain.Entities
{
    public class Escuela
    {
        [Key]
        public int IdEscuela { get; set; }

        public string? TipoEscuela { get; set; }

        [Required]
        public string NombreEscuela { get; set; } = null!;

        public string? Cct { get; set; }

        public string? ZonaEsc { get; set; }

        public string? Corde { get; set; }

        public DateTime? CicloEscInicio { get; set; }

        public DateTime? CicloEscFin { get; set; }

        public string? Turno { get; set; }

        public string? Nivel { get; set; }

        public int? AniosNivelEducativo { get; set; }

        public string? LeyendaDirector { get; set; }

        [Required]
        public string NombreDirector { get; set; } = null!;

        public DateTime? FechaIniCiclo { get; set; }

        public DateTime? FechaFinCiclo { get; set; }

        public string? Tel { get; set; }

        public string? Email { get; set; }

        public bool Activo { get; set; }

        public int? UsuarioIns { get; set; }

        public DateTime FechaIns { get; set; }

        public int? UsuarioAct { get; set; }

        public DateTime? FechaAct { get; set; }

    }
}
