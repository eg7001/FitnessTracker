using FitnessTracker.DTOs.ExercisesDTOs;
using FitnessTracker.Models;

namespace FitnessTracker.Mappers;

public static class ExerciseDefinitionMappers
{
    public static ExerciseDefinition ToExerciseDefinitionFromDto(this CreateExerciseDto dto)
    {
        return new ExerciseDefinition
        {
            Name = dto.Name,
            Description = dto.Description,
        };
    }

    public static ReturnExerciseDto ToDtoFromExercise(this ExerciseDefinition exerciseDefinition)
    {
        return new ReturnExerciseDto
        {
            Name = exerciseDefinition.Name,
            Description = exerciseDefinition.Description
        };
    }
}