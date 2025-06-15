namespace FitnessTracker.Models;

public class Sets
{
    public int Id { get; set; }
    public int Reps { get; set; }
    public double Weight { get; set; }
    public string? Comment { get; set; }
    
    public int LoggedExerciseId { get; set; }
    public LoggedExercise LoggedExerciseExercises { get; set; }
}