using FitnessTracker.DTOs.ExercisesDTOs;
using FitnessTracker.Models;

namespace FitnessTracker.Interfaces;

public interface IExercisesRepository
{
    Task<ExerciseDefinition?> CreateExercises(ExerciseDefinition exercises);
    
    Task<ExerciseDefinition?> GetExercisesById(int id);
    Task<List<ExerciseDefinition>> GetExercisesByWorkout(int workoutId);
    Task<ExerciseDefinition?> UpdateExercises(int id, UpdateExercisesDto dto);
    Task<ExerciseDefinition?> DeleteExercises(int id);
}