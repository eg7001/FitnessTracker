using FitnessTracker.DTOs.SetsDTOs;
using FitnessTracker.Interfaces;
using FitnessTracker.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FitnessTracker.Controllers;
[ApiController]
public class SetsController : ControllerBase
{
    private readonly ISetsRepository _setsRepository;

    public SetsController(ISetsRepository setsRepository)
    {
        _setsRepository = setsRepository;
    }
     
    [Authorize]
    [HttpGet]
    [Route("getSetById/{setId}")]
    public async Task<ActionResult<Sets>> GetSets()
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState); 
        }

        return BadRequest("Not yet implemented");
    }
   
    [Authorize]
    [HttpPost]
    [Route("createSets")]
    public async Task<ActionResult<Sets>> CreateSets([FromBody] Sets sets)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState); 
        }
        return Ok(await _setsRepository.CreateSets(sets));
    }

    [Authorize]
    [HttpPut]
    [Route("updateSets")]
    public async Task<ActionResult<Sets>> UpdateSets(int id, UpdateSetsDto sets)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState); 
        }
        var exists = await _setsRepository.UpdateSets(id, sets);
        if (exists == null)
            return BadRequest("Not Found");
        return Ok(exists);
    }
   
    [Authorize]
    [HttpDelete]
    [Route("deleteSets")]
    public async Task<ActionResult<Sets>> DeleteSets(int id)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState); 
        }

        var exists = await _setsRepository.DeleteSets(id);
        if(exists==null)
            return BadRequest("Set not found");
        
        return Ok(exists);
    }
}