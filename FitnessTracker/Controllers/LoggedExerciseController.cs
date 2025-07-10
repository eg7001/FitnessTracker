using FitnessTracker.DTOs.LoggedExerciseDTOs;
using FitnessTracker.Interfaces;
using FitnessTracker.Mappers;
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
   [Route("getLoggedExercise{id:int}")]
   public async Task<ActionResult<LoggedExercise>> GetLoggedExercise([FromRoute] int id)
   {
       if (!ModelState.IsValid)
       {
           return BadRequest(ModelState); 
       }
       var mode = await _loggedExerciseRepo.GetByIdLoggedExercise(id);
       if (mode == null)
       {
           return BadRequest("Was not found");
       }

       return Ok(mode);
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

       return Ok(await _loggedExerciseRepo.CreateLoggedExercise(loggedExercise));
   }
   [Authorize]
   [HttpPut]
   [Route("updateLoggedExercise")]
   public async Task<ActionResult<LoggedExercise>> UpdateSets(int id, UpdateLoggedExerciseDto dto)
   {
       if (!ModelState.IsValid)
       {
           return BadRequest(ModelState); 
       }
       return Ok(await _loggedExerciseRepo.UpdateLoggedExercise(id, dto.ToLoggedExerciseFromDto()));
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
       var modl = await _loggedExerciseRepo.DeleteLoggedExercise(id);
       if (modl == null)
       {
           return BadRequest("The logged exercise does not exis");
       }
       return Ok(modl);
   }
}