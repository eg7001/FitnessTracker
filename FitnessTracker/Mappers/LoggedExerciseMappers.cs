using FitnessTracker.DTOs.LoggedExerciseDTOs;
using FitnessTracker.Models;

namespace FitnessTracker.Mappers;

public static class LoggedExerciseMappers
{
   public static LoggedExercise ToLoggedExerciseFromDto(this UpdateLoggedExerciseDto dto)
   {
      return new LoggedExercise()
      {
         WorkoutId = dto.WorkoutId,
         ExerciseDefinitionId = dto.ExerciseDefinitionId
      };
   } 
}