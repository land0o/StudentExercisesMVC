using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentExercises.Models.ViewModels
{
    public class StudentEditViewModel
    {
        public List<Cohort> Cohorts { get; set; } = new List<Cohort>();
        public List<Exercise> Exercises { get; set; } = new List<Exercise>();
        public List<int> ExerciseIds { get; set; } = new List<int>();
        public Student Student { get; set; }
        public List<SelectListItem> CohortOptions
        {
            get
            {
                if (Cohorts == null) return null;

                return Cohorts.Select(c => new SelectListItem(c.CohortName, c.Id.ToString())).ToList();
            }
        }

        public List<SelectListItem> ExerciseOptions { get; set; }
    }
}