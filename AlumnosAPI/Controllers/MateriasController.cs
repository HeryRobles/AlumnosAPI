using AlumnosAPI.Model.Entities;
using AlumnosAPI.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AlumnosAPI.Controllers
{
    [ApiController, Route("api/[Controller]")]
    public class MateriasController : ControllerBase
    {
        private readonly ApplicationDbContext context;

        public MateriasController(ApplicationDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Alumno>>> GetMaterias()
        {
            var alumnos = await context.Alumnos.ToListAsync();
            return alumnos;
        }

        [HttpGet ("{id:int}")]

        public async Task<ActionResult<List<Materia>>> GetMateria(int id)
        {
            var materia = await context.Materias.SingleOrDefaultAsync(x => x.Id == id);
            if (materia == null)
            {
                return NotFound();
            }

            return materia;
        }
    }
}
