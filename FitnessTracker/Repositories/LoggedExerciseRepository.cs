using FitnessTracker.Context;
using FitnessTracker.DTOs.ExercisesDTOs;
using FitnessTracker.DTOs.LoggedExerciseDTOs;
using FitnessTracker.Interfaces;
using FitnessTracker.Models;
using Microsoft.EntityFrameworkCore;

namespace FitnessTracker.Repositories;

public class LoggedExerciseRepository : ILoggedExerciseRepository
{
    private readonly ApplicationDbContext _dbContext;

    public LoggedExerciseRepository( ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    public async Task<LoggedExercise?> CreateLoggedExercise(LoggedExercise loggedExercise)
    {
        await _dbContext.AddAsync(loggedExercise);
        await _dbContext.SaveChangesAsync();
        return loggedExercise;
    }

    public async Task<LoggedExercise?> UpdateLoggedExercise(int id, UpdateLoggedExerciseDto dto)
    {
        var exists = await _dbContext.LoggedExercises.FirstOrDefaultAsync(x => x.Id == id);
        if (exists == null)
        {
            return null;
        }

        exists.WorkoutId = dto.WorkoutId;
        exists.ExerciseDefinitionId = dto.ExerciseDefinitionId;

        await _dbContext.SaveChangesAsync();

        return exists;
    }

    public Task<List<LoggedExercise>> GetByIdLoggedExercise(int loggedExerciseId)
    {
        throw new NotImplementedException();
    }

    public async Task<LoggedExercise?> DeleteLoggedExercise(int id)
    {
        var accountModel = await _dbContext.LoggedExercises.FirstOrDefaultAsync(x => x.Id == id);
        if (accountModel == null)
        {
            return null;
        }
        
        _dbContext.LoggedExercises.Remove(accountModel);
        await _dbContext.SaveChangesAsync();
        return accountModel;
    }
}