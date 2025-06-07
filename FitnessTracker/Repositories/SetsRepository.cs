using FitnessTracker.DTOs.SetsDTOs;
using FitnessTracker.Interfaces;
using FitnessTracker.Models;

namespace FitnessTracker.Repositories;

public class SetsRepository: ISetsRepository
{
    public Task<Sets?> CreateSets(Sets sets)
    {
        throw new NotImplementedException();
    }

    public Task<Sets?> UpdateSets(int id, UpdateSetsDto dto)
    {
        throw new NotImplementedException();
    }

    public Task<List<Sets>> GetSetsByWorkout(int workoutId)
    {
        throw new NotImplementedException();
    }

    public Task<Sets?> DeleteSets(int id)
    {
        throw new NotImplementedException();
    }
}