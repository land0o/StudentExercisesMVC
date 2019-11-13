using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace StudentExercises.Models
{
    public class Cohort
    {
        public int Id { get; set; }

        [Required]
        [StringLength(12, MinimumLength = 6)]
        public string CohortName { get; set; }

        public List<Student> student = new List<Student>();
        public List<Instructor> instructor = new List<Instructor>();


    }
}