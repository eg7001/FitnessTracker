using FitnessTracker.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FitnessTracker.Context;

public class ApplicationDbContext : IdentityDbContext<AppUser>
{
    public ApplicationDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
    {
        
    } 
        public DbSet<AppUser> Users { get; set; }
        public DbSet<Workout> Workouts { get; set; }
        public DbSet<Exercises> Exercises { get; set; }
        public DbSet<Sets> Sets { get; set; }
}