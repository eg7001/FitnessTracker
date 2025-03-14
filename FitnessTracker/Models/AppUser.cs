using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace FitnessTracker.Models;

[Table("AppUser")]
public class AppUser : IdentityUser
{
    
}