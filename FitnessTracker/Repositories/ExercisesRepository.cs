using FitnessTracker.Context;
using FitnessTracker.DTOs.ExercisesDTOs;
using FitnessTracker.Interfaces;
using FitnessTracker.Models;

namespace FitnessTracker.Repositories;

public class ExercisesRepository : IExercisesRepository
{
    private readonly ApplicationDbContext _dbContext;

    public ExercisesRepository(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    public Task<ExerciseDefinition?> CreateExercises(ExerciseDefinition exercises)
    {
        throw new NotImplementedException();
    }

    public Task<ExerciseDefinition?> GetExercisesById(int id)
    {
        throw new NotImplementedException();
    }

    public Task<List<ExerciseDefinition>> GetExercisesByWorkout(int workoutId)
    {
        throw new NotImplementedException();
    }

    public Task<ExerciseDefinition?> UpdateExercises(int id, UpdateExercisesDto dto)
    {
        throw new NotImplementedException();
    }

    public Task<ExerciseDefinition?> DeleteExercises(int id)
    {
        throw new NotImplementedException();
    }
}