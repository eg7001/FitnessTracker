using FitnessTracker.DTOs.LoggedExerciseDTOs;
using FitnessTracker.Models;

namespace FitnessTracker.Interfaces;

public interface ILoggedExerciseRepository
{
    Task<LoggedExercise?> CreateLoggedExercise(LoggedExercise sets);
    Task<LoggedExercise?> UpdateLoggedExercise(int id, UpdateLoggedExerciseDto dto);
    Task<List<LoggedExercise>> GetByIdLoggedExercise(int workoutId);
    Task<LoggedExercise?> DeleteLoggedExercise(int id);
}