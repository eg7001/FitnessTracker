namespace FitnessTracker.Models;

public class Exercises
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<Sets> Sets { get; set; }
    
    public int WorkoutId { get; set; }
    public Workout Workout { get; set; }
}