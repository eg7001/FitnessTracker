using FitnessTracker.DTOs.ExercisesDTOs;
using FitnessTracker.Models;

namespace FitnessTracker.Interfaces;

public interface IExercisesRepository
{
    Task<Exercises?> CreateExercises(Exercises exercises);
    
    Task<Exercises?> GetExercisesById(int id);
    Task<List<Exercises>> GetExercisesByWorkout(int workoutId);
    Task<Exercises?> UpdateExercises(int id, UpdateExercisesDto dto);
    Task<Exercises?> DeleteExercises(int id);
}