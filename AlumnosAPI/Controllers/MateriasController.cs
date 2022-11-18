using AlumnosAPI.Model.Entities;
using AlumnosAPI.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AlumnosAPI.Controllers
{
    [ApiController, Route("api/[Controller]")]
    public class MateriasController
    {
        private readonly ApplicationDbContext context;

        public MateriasController(ApplicationDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Alumno>>> GetAlumnos()
        {
            var alumnos = await context.Alumnos.ToListAsync();
            return alumnos;
        }
    }
}
