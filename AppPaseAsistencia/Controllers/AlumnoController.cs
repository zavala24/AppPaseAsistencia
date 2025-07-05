using AppPaseAsistencia.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AppPaseAsistencia.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AlumnoController : ControllerBase
    {
        private readonly IAlumnoService _service;

        public AlumnoController(IAlumnoService service)
        {
            _service = service;
        }

        [HttpGet("{nia}/{cct}")]
        public async Task<IActionResult> GetByNiaAndCct(string nia, string cct)
        {
            var alumno = await _service.GetByNiaAndCctAsync(nia, cct);
            if (alumno == null)
                return NotFound();

            return Ok(alumno);
        }
    }
}
