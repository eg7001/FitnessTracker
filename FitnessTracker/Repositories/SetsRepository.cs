using FitnessTracker.Context;
using FitnessTracker.DTOs.SetsDTOs;
using FitnessTracker.Interfaces;
using FitnessTracker.Models;

namespace FitnessTracker.Repositories;

public class SetsRepository: ISetsRepository
{
    private readonly ApplicationDbContext _context;

    public SetsRepository(ApplicationDbContext context)
    {
       _context = context; 
    }
    public async Task<Sets?> CreateSets(Sets sets)
    {
        await _context.AddAsync(sets);
        await _context.SaveChangesAsync();
        return sets;
    }

    public async Task<Sets?> UpdateSets(int id, UpdateSetsDto dto)
    {
        var exists = _context.Sets.FirstOrDefault(s => s.Id == id);
        if (exists == null) 
        {
            return null;
        }

        exists.Reps = dto.Reps;
        exists.Weight = dto.Weight;
        exists.Comment = dto.Comment;
        exists.LoggedExerciseId = dto.LoggedExerciseId;
        await _context.SaveChangesAsync();

        return exists;
    }

    public Task<List<Sets>> GetSetsByWorkout(int workoutId)
    {
        throw new NotImplementedException();
    }

    public async Task<Sets?> DeleteSets(int id)
    {
        var exists = _context.Sets.FirstOrDefault(s => s.Id == id);
        if (exists == null)
            return null;
        _context.Sets.Remove(exists);
        await _context.SaveChangesAsync();
        return exists;
    }
}