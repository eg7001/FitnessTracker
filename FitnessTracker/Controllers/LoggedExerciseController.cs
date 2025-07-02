using FitnessTracker.Interfaces;
using FitnessTracker.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FitnessTracker.Controllers;

[ApiController]
public class LoggedExerciseController : ControllerBase
{
   private readonly ILoggedExerciseRepository _loggedExerciseRepo;

   public LoggedExerciseController(ILoggedExerciseRepository loggedExerciseRepo)
   {
       _loggedExerciseRepo = loggedExerciseRepo;
   }
   [Authorize]
   [HttpGet]
   [Route("getLoggedExercise")]
   public async Task<ActionResult<List<LoggedExercise>>> GetSets()
   {
       if (!ModelState.IsValid)
       {
           return BadRequest(ModelState); 
       }

       return BadRequest("Not yet implemented");
   }
   
   [Authorize]
   [HttpPost]
   [Route("createLoggedExercise")]
   public async Task<ActionResult<LoggedExercise>> CreateLoggedExercise(LoggedExercise loggedExercise)
   {
       if (!ModelState.IsValid)
       {
           return BadRequest(ModelState); 
       }
       return BadRequest("Not yet implemented");
   }
   
   [Authorize]
   [HttpPut]
   [Route("updateLoggedExercise")]
   public async Task<ActionResult<LoggedExercise>> UpdateSets(int id, LoggedExercise loggedExercise)
   {
       if (!ModelState.IsValid)
       {
           return BadRequest(ModelState); 
       }
       return BadRequest("Not yet implemented");
   }
   
   [Authorize]
   [HttpDelete]
   [Route("deleteLoggedExercise")]
   public async Task<ActionResult<LoggedExercise>> DeleteLoggedExercise(int id)
   {
       if (!ModelState.IsValid)
       {
           return BadRequest(ModelState); 
       }
       return BadRequest("Not yet implemented");
   }
}