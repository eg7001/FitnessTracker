using FitnessTracker.DTOs.ExercisesDTOs;
using FitnessTracker.Interfaces;
using FitnessTracker.Models;

namespace FitnessTracker.Repositories;

public class ExercisesRepository : IExercisesRepository
{
    public Task<Exercises?> CreateExercises(Exercises exercises)
    {
        throw new NotImplementedException();
    }

    public Task<Exercises?> GetExercisesById(int id)
    {
        throw new NotImplementedException();
    }

    public Task<List<Exercises>> GetExercisesByWorkout(int workoutId)
    {
        throw new NotImplementedException();
    }

    public Task<Exercises?> UpdateExercises(int id, UpdateExercisesDto dto)
    {
        throw new NotImplementedException();
    }

    public Task<Exercises?> DeleteExercises(int id)
    {
        throw new NotImplementedException();
    }
}