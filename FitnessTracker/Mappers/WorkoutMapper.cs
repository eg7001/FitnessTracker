using FitnessTracker.DTOs.WorkoutDTOs;
using FitnessTracker.Models;

namespace FitnessTracker.Mappers;

public static class WorkoutMapper
{
   

    public static ReturnWorkoutDto ToReturnFromCreate(this CreateWorkoutDto workout)
    {
        return new ReturnWorkoutDto
        {
            Name = workout.Name,
            Date = workout.Date,
        };
    }
}