﻿using System.ComponentModel.DataAnnotations;


namespace AlumnosAPI.Model.Entities
{
    public class Alumno
    {

        public int Id { get; set; }

        [Required]
        public string Nombre { get; set; }
    }
}
