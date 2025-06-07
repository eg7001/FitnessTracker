using FitnessTracker.DTOs.WorkoutDTOs;
using FitnessTracker.Interfaces;
using FitnessTracker.Models;

namespace FitnessTracker.Repositories;

public class WorkoutRepository : IWorkoutRepository
{
    public Task<Workout?> CreateWorkout(Workout workout)
    {
        throw new NotImplementedException();
    }

    public Task<Workout?> GetWorkoutbyDate(DateTime data)
    {
        throw new NotImplementedException();
    }

    public Task<List<Workout>> GetWorkoutsByUser(string appUserId)
    {
        throw new NotImplementedException();
    }

    public Task<Workout> UpdateWorkout(int id, UpdateWorkoutDto dto)
    {
        throw new NotImplementedException();
    }

    public Task<Workout> DeleteWorkout(int id)
    {
        throw new NotImplementedException();
    }
}