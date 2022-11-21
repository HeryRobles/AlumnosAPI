using AlumnosAPI.Model;
using AlumnosAPI.Model.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AlumnosAPI.Controllers
{
    [ApiController, Route("api/[Controller]")]
    public class MateriasController : ControllerBase
    {
        private readonly ApplicationDbContext context;
        private ActionResult<List<Materia>> materias;

        public MateriasController(ApplicationDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Materia>>> GetMaterias()
        {
            var materia = await context.Materias.ToListAsync();
            return materias;
        }

        [HttpGet("{id:int}")]

        public async Task<ActionResult<List<Materia>>> GetMateria(int id)
        {
            var materia = await context.Materias.SingleOrDefaultAsync(x => x.Id == id);
            if (materia == null)
            {
                return NotFound("Materia no encotrada");
            }

            return materias;

           
        }

        [HttpPost]
        public async Task<ActionResult> Add([FromBody] Materia materia)
        {
            context.Materias.Add(materia);
            await context.SaveChangesAsync();
            return Ok();
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult> Edit(int id, [FromBody] Materia materia)
        {
            var materiaDb = await context.Materias.FirstOrDefaultAsync(x => x.Id == id);

            if (materiaDb == null)
            {
                return NotFound();
            }

            materiaDb.Nombre = materia.Nombre;

            context.Materias.Update(materiaDb);
            await context.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var materiaDb = await context.Materias.FirstOrDefaultAsync(x => x.Id == id);

            if (materiaDb == null)
            {
                return NotFound();
            }

            context.Materias.Remove(materiaDb);
            await context.SaveChangesAsync();
            return Ok();
        }
    }
}
