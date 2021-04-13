using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkoutTracking.Application.Dto.TrainingExtra;

namespace WorkoutTracking.Application.Dto.Training
{
    public class TrainingTemplateDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int CreatorId { get; set; }
        public TrainingCategoryDto Category { get; set; }
        public IEnumerable<ExerciseDto> Exercises { get; set; }
    }
}
