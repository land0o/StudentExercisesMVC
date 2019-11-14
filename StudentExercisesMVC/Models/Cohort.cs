using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace StudentExercises.Models
{
    public class Cohort
    {
        public int Id { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 6)]
        [Display(Name = "Cohort Name")]
        public string CohortName { get; set; }

        public Student student { get; set; }

        public List<Student> studentList = new List<Student>();
        public List<Instructor> instructor = new List<Instructor>();


    }
}