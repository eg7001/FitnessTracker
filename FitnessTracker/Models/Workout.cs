namespace FitnessTracker.Models;

public class Workout
{
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime? Date { get; set; }
    public List<Exercises> ExercisesList { get; set; } = new List<Exercises>();
}