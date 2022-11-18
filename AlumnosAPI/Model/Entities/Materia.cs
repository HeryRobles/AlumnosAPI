using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AlumnosAPI.Model.Entities
{
    public class Materia
    {
  
        public int Id { get; set; }
        public string Nombre { get; set; }

        public int AlumnoId { get; set; }
        [ForeignKey("AlumnoId")]
        public virtual Alumno alumno { get; set; }  
    
    }
}
