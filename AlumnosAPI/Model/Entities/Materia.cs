using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AlumnosAPI.Model.Entities
{
    public class Materia
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MateriaId { get; set; }
        public string Nombre { get; set; }

        public int Id { get; set; }
        [ForeignKey("Id")]

        public virtual Alumno alumno { get; set; }
    }
}
