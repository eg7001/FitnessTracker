using FitnessTracker.DTOs.ExercisesDTOs;
using FitnessTracker.Interfaces;
using FitnessTracker.Mappers;
using FitnessTracker.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FitnessTracker.Controllers;
[ApiController]
public class ExercisesController : ControllerBase
{
    private readonly IExercisesRepository _exercisesRepository;

    public ExercisesController(IExercisesRepository exercisesRepository)
    {
        _exercisesRepository = exercisesRepository;
    }
    
    
    [Authorize]
    [HttpGet]
    [Route("getExercises")]
    public async Task<ActionResult<List<ExerciseDefinition>>> GetExercises()
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState); 
        }

        return BadRequest("Not yet implemented");
    }
   
    [Authorize]
    [HttpPost]
    [Route("createExercises")]
    public async Task<ActionResult<ReturnExerciseDto>> CreateExercises(CreateExerciseDto exerciseDefinition)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState); 
        }
        await _exercisesRepository.CreateExercises(exerciseDefinition.ToExerciseDefinitionFromDto());
        return Ok(exerciseDefinition);
    }

    [Authorize]
    [HttpPut]
    [Route("updateExercises")]
    public async Task<ActionResult<ExerciseDefinition>> UpdateExercises(int id, ExerciseDefinition exerciseDefinition)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState); 
        }
        return BadRequest("Not yet implemented");
    }
   
    [Authorize]
    [HttpDelete]
    [Route("deleteExercises")]
    public async Task<ActionResult<ExerciseDefinition>> DeleteExercises(int id)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState); 
        }
        var exerciseDefinition = await _exercisesRepository.DeleteExercises(id);
        if (exerciseDefinition == null)
        {
            return BadRequest("Not Found");
        }
        return Ok(exerciseDefinition);
    }
}