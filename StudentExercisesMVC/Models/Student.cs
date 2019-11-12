using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace StudentExercises
{
    public class Student
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "A First Name is Required")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "A Last Name is Required")]
        public string LastName { get; set; }

        [Required]
        public string SlackHandle { get; set; }

        [Required]
        public int CohortId { get; set; }
        public Cohort Cohort { get; set; }

        public List<Exercise> StudentCurrentExercise = new List<Exercise>();

        //public void AddExercise(Exercise exercise)
        //{
        //    StudentCurrentExercise.Add(exercise);
        //}

    }
}