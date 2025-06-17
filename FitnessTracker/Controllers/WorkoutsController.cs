using FitnessTracker.Interfaces;
using FitnessTracker.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FitnessTracker.Controllers;
[ApiController]
public class WorkoutsController : ControllerBase
{
   private readonly IWorkoutRepository _workoutRepository;

   public WorkoutsController(IWorkoutRepository workoutRepository)
   {
      _workoutRepository = workoutRepository;
   }
   
   [Authorize]
   [HttpGet]
   [Route("getWorkout")]
   public async Task<ActionResult<List<Workout>>> GetWorkouts()
   {
      if (!ModelState.IsValid)
      {
        return BadRequest(ModelState); 
      }

      return BadRequest("Not yet implemented");
   }
   
   [Authorize]
   [HttpPost]
   [Route("createWorkout")]
   public async Task<ActionResult<Workout>> CreateWorkout(Workout workout)
   {
      if (!ModelState.IsValid)
      {
        return BadRequest(ModelState); 
      }
      return BadRequest("Not yet implemented");
   }

   [Authorize]
   [HttpPut]
   [Route("updateWorkout")]
   public async Task<ActionResult<Workout>> UpdateWorkout(int id, Workout workout)
   {
      if (!ModelState.IsValid)
      {
         return BadRequest(ModelState); 
      }
      return BadRequest("Not yet implemented");
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
      return BadRequest("Not yet implemented");
   }
   
}