using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkoutTracking.Application.Models.ExerciseProperty
{
    public class ExercisePropertyModel
    {
        public int Duration { get; set; }
        public string DurationType { get; set; }
        public int Weigth { get; set; }
        public int ExerciseId { get; set; }
    }
}
