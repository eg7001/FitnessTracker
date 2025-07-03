using FitnessTracker.Context;
using FitnessTracker.DTOs.WorkoutDTOs;
using FitnessTracker.Interfaces;
using FitnessTracker.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FitnessTracker.Repositories;

public class WorkoutRepository : IWorkoutRepository
{
    private readonly ApplicationDbContext _dbContext;

    public WorkoutRepository(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    public async Task<Workout?> CreateWorkout(Workout workout)
    {
        await _dbContext.AddAsync(workout);
        await _dbContext.SaveChangesAsync();
        
        return workout;
    }

    public async Task<Workout?> GetWorkoutById(int id, string userId)
    {
        return await _dbContext.Workouts.Include(w => w.LoggedExercises)
            .ThenInclude(e => e.Sets)
            .Include(w => w.LoggedExercises)
            .ThenInclude(e => e.ExerciseDefinition)
            .FirstOrDefaultAsync(w => w.Id == id && w.AppUserId == userId);
    }

    public Task<Workout?> GetWorkoutbyDate(DateTime data)
    {
        throw new NotImplementedException();
    }

    public Task<List<Workout>> GetWorkoutsByUser(string appUserId)
    {
        throw new NotImplementedException();
    }

    public async Task<Workout> UpdateWorkout(int id, UpdateWorkoutDto dto)
    {
        var workoutModel = await _dbContext.Workouts.FirstOrDefaultAsync(x => x.Id == id);
        if (workoutModel == null)
        {
            return null;
        }

        workoutModel.Name = dto.Name;
        workoutModel.Date = dto.Date;
        await _dbContext.SaveChangesAsync();
        return workoutModel;
    }

    public  async Task<Workout> DeleteWorkout(int id)
    {
        var workoutModel = await _dbContext.Workouts.FirstOrDefaultAsync(x => x.Id == id);
        if (workoutModel == null)
        {
            return null;
        }
        
        _dbContext.Workouts.Remove(workoutModel);
        await _dbContext.SaveChangesAsync();
        return workoutModel;
    }
}