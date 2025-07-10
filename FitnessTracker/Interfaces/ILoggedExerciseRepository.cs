using FitnessTracker.DTOs.LoggedExerciseDTOs;
using FitnessTracker.Models;

namespace FitnessTracker.Interfaces;

public interface ILoggedExerciseRepository
{
    Task<LoggedExercise?> CreateLoggedExercise(LoggedExercise loggedExercise);
    Task<LoggedExercise?> UpdateLoggedExercise(int id, LoggedExercise loggedExercise);
    Task<LoggedExercise?> GetByIdLoggedExercise(int workoutId);
    Task<LoggedExercise?> DeleteLoggedExercise(int id);
}