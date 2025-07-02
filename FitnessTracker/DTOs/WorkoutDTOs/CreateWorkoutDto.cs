using FitnessTracker.Models;

namespace FitnessTracker.DTOs.WorkoutDTOs;

public class CreateWorkoutDto
{
    
    public string Name { get; set; }
    
    public DateTime? Date { get; set; } 
    
}