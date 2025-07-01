using FitnessTracker.Context;
using FitnessTracker.DTOs.ExercisesDTOs;
using FitnessTracker.Interfaces;
using FitnessTracker.Models;
using Microsoft.EntityFrameworkCore;

namespace FitnessTracker.Repositories;

public class ExercisesRepository : IExercisesRepository
{
    private readonly ApplicationDbContext _dbContext;

    public ExercisesRepository(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    public async Task<ExerciseDefinition?> CreateExercises(ExerciseDefinition exercises)
    {   
        await _dbContext.AddAsync(exercises);
        await _dbContext.SaveChangesAsync();
        return exercises;
    }

    public async Task<ExerciseDefinition?> GetExercisesById(int id)
    {
        return await _dbContext.Exercises.FirstOrDefaultAsync(x => x.Id == id);
    }

    public Task<List<ExerciseDefinition>> GetExercisesByWorkout(int workoutId)
    {
        throw new NotImplementedException();
    }

    public async Task<ExerciseDefinition?> UpdateExercises(int id, UpdateExercisesDto dto)
    {
       var exists = await _dbContext.Exercises.FirstOrDefaultAsync(x => x.Id == id);
       if (exists == null)
       {
           return null;
       }
       
       exists.Name = dto.Name;
       exists.Description = dto.Description;
       
       await _dbContext.SaveChangesAsync();
       return exists;
    }

    public async Task<ExerciseDefinition?> DeleteExercises(int id)
    {
        var exerciseModel = await _dbContext.Exercises.FirstOrDefaultAsync(x => x.Id == id);
        if (exerciseModel == null)
        {
            return null;
        }
        
        _dbContext.Exercises.Remove(exerciseModel);
        _dbContext.SaveChanges();
        return exerciseModel;
    }
}