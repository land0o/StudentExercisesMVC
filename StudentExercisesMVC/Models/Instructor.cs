using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace StudentExercises.Models
{
    public class Instructor
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="A First Name is Required")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "A Last Name is Required")]
        public string LastName { get; set; }

        [Required]
        public string SlackHandle { get; set; }
        [Required]
        public string Speciality { get; set; }

        public Cohort Cohort { get; set; }

        [Required]
        public int CohortId { get; set; }

        //public void AssignExercise(Exercise exercise, Student student)
        //{
        //    student.AddExercise(exercise);
        //}

    }
}