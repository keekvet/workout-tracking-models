using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkoutTracking.Application.Dto.TrainingHistory
{
    public class ExercisePropertyHistoryDto
    {
        public int Id { get; set; }
        public int Duration { get; set; }
        public string DurationType { get; set; }
        public int Weigth { get; set; }
    }
}
