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
    [Route("getSets")]
    public async Task<ActionResult<List<Sets>>> GetSets()
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
    public async Task<ActionResult<Sets>> CreateSets(Sets sets)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState); 
        }
        return BadRequest("Not yet implemented");
    }

    [Authorize]
    [HttpPut]
    [Route("updateSets")]
    public async Task<ActionResult<Sets>> UpdateSets(int id, Sets sets)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState); 
        }
        return BadRequest("Not yet implemented");
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
        return BadRequest("Not yet implemented");
    }
}