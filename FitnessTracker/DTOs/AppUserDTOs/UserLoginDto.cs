using System.ComponentModel.DataAnnotations;

namespace FitnessTracker.Mappers.AppUserDTOs;

public class UserLoginDto
{
    [Required]
    public string Username { get; set; }
    [Required]
    public string Password { get; set; }
}