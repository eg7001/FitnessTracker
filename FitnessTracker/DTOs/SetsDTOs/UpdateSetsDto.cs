namespace FitnessTracker.DTOs.SetsDTOs;

public class UpdateSetsDto
{
    
    public int Reps { get; set; }
    public double Weight { get; set; }
    public string? Comment { get; set; }
    
    public int LoggedExerciseId { get; set; }
}