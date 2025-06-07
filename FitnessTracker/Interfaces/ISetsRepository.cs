using FitnessTracker.DTOs.SetsDTOs;
using FitnessTracker.Models;

namespace FitnessTracker.Interfaces;

public interface ISetsRepository
{
    Task<Sets?> CreateSets(Sets sets);
    Task<Sets?> UpdateSets(int id, UpdateSetsDto dto);
    Task<List<Sets>> GetSetsByWorkout(int workoutId);
    Task<Sets?> DeleteSets(int id);
}