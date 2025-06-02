using System.ComponentModel.DataAnnotations;

namespace FitnessTracker.Mappers.AppUserDTOs;

public class UserRegisterDto
{
    [Required]
    public string? Username { get; set; }
    [Required]
    [EmailAddress]
    public string? Email { get; set; }
    
    [Required]  
    public string? Password { get; set; }
}