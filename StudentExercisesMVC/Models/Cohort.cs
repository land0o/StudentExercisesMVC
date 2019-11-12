using System;
using System.Collections.Generic;

namespace StudentExercises
{
    public class Cohort
    {
        public int Id { get; set; }
        public string CohortName { get; set; }

        public List<Student> student = new List<Student>();
        public List<Instructor> instructor = new List<Instructor>();


    }
}