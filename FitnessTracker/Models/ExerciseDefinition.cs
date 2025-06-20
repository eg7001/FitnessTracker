namespace FitnessTracker.Models;

public class ExerciseDefinition
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    
    public List<LoggedExercise> LoggedExercises { get; set; }     
}