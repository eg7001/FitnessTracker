using System.Security.Claims;
using FitnessTracker.DTOs.WorkoutDTOs;
using FitnessTracker.Interfaces;
using FitnessTracker.Mappers;
using FitnessTracker.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FitnessTracker.Controllers;
[ApiController]
public class WorkoutsController : ControllerBase
{
   private readonly IWorkoutRepository _workoutRepository;
   private readonly IHttpContextAccessor _accessor;

   public WorkoutsController(IWorkoutRepository workoutRepository,IHttpContextAccessor accessor)
   {
      _workoutRepository = workoutRepository;
      _accessor = accessor;
   }
   private string GetUserId() =>
      _accessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
   
   [Authorize]
   [HttpGet]
   [Route("getWorkout/{id:int}")]
   public async Task<ActionResult<Workout>> GetWorkoutById([FromRoute] int id)
   {
      if (!ModelState.IsValid)
      {
        return BadRequest(ModelState); 
      }

      var userId = GetUserId();
      return await _workoutRepository.GetWorkoutById(id, userId);
   }
   
   [Authorize]
   [HttpPost]
   [Route("createWorkout")]
   public async Task<ActionResult<Workout>> CreateWorkout(CreateWorkoutDto dto)
   {
      if (!ModelState.IsValid)
      {
        return BadRequest(ModelState); 
      }
      var userId = GetUserId();
      var workout = new Workout
      {
         Name = dto.Name,
         Date = dto.Date,
         AppUserId = userId
      };
      
      await _workoutRepository.CreateWorkout(workout);

      return NoContent();
   }

   [Authorize]
   [HttpPut]
   [Route("updateWorkout")]
   public async Task<ActionResult<Workout>> UpdateWorkout(int id,[FromBody] UpdateWorkoutDto dto)
   {
      if (!ModelState.IsValid)
      {
         return BadRequest(ModelState); 
      }

      return await _workoutRepository.UpdateWorkout(id, dto);
   }
   
   [Authorize]
   [HttpDelete]
   [Route("deleteWorkout")]
   public async Task<ActionResult<Workout>> DeleteWorkout(int id)
   {
      if (!ModelState.IsValid)
      {
         return BadRequest(ModelState); 
      }

      var workoutModel = await _workoutRepository.DeleteWorkout(id);
      if (workoutModel == null)
      {
         return NotFound();
      }

      return Ok(workoutModel);
   }
   
}