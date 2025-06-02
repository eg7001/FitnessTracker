using FitnessTracker.Interfaces;
using FitnessTracker.Mappers.AppUserDTOs;
using FitnessTracker.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace FitnessTracker.Controllers;
[Route("api/appuser")]
[ApiController]
public class AppUserController : ControllerBase
{
   private readonly UserManager<AppUser> _userManager;
   private readonly ITokenService _tokenService;
   private readonly SignInManager<AppUser> _signInManager;
   

   public AppUserController(UserManager<AppUser> userManager, ITokenService tokenService, SignInManager<AppUser> signInManager)
   {
      _userManager = userManager;
      _tokenService = tokenService;
      _signInManager = signInManager;
   }

   [Route("register")]
   [HttpPost]
   public async Task<IActionResult> Register([FromBody] UserRegisterDto userRegisterDto)
   {
      try
      {
         if (!ModelState.IsValid)
         {
            return BadRequest(ModelState);
         }

         var appUser = new AppUser
         {
            UserName = userRegisterDto.Username,
            Email = userRegisterDto.Email
         };
         var createUser = await _userManager.CreateAsync(appUser, userRegisterDto.Password);
         if (createUser.Succeeded)
         {
            var roleResult = await _userManager.AddToRoleAsync(appUser, "User");
            if (roleResult.Succeeded)
            {
               return Ok(
                  new NewUserDto
                  {
                     UserName   = appUser.UserName,
                     Email = appUser.Email,
                     Token = _tokenService.CreateToken(appUser)
                  });
            }
            else
            {
               return StatusCode(500, roleResult.Errors);
            }
         }
         else
         {
            return StatusCode(500, createUser.Errors);
         }
      }
      catch (Exception ex)
      {
         Console.WriteLine("Te try catch " + ex.Message);
         throw;
      }
   }
}