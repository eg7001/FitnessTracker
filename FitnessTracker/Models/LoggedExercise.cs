namespace FitnessTracker.Models;

public class LoggedExercise
{
    public int Id { get; set; }
    public int WorkoutId { get; set; }
    public Workout Workout { get; set; }
    
    public int ExerciseDefinitionId { get; set; }
    public ExerciseDefinition ExerciseDefinition { get; set; }
    
    public List<Sets> Sets { get; set; } 
}