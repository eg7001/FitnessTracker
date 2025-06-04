using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace FitnessTracker.Models;

[Table("AppUser")]
public class AppUser : IdentityUser
{
    public int? WorkoutId { get; set; }
    public List<Workout> Workouts { get; set; } = new List<Workout>();
}