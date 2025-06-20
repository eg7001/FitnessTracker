namespace FitnessTracker.DTOs.LoggedExerciseDTOs;

public class UpdateLoggedExerciseDto
{
   public int Id { get; set; }
   public int WorkoutId { get; set; }
   public int ExerciseDefinitionId { get; set; }
}