using FitnessTracker.Models;

namespace FitnessTracker.DTOs.WorkoutDTOs;

public class ReturnWorkoutDto
{
    public string Name { get; set; }
    
    public DateTime? Date { get; set; } 
}