using FitnessTracker.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FitnessTracker.Context;

public class ApplicationDbContext : IdentityDbContext<AppUser>
{

    public ApplicationDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
    {
        
    }
    
        public DbSet<AppUser> Userst { get; set; }
        public DbSet<Workout> Workouts { get; set; }
        public DbSet<ExerciseDefinition> Exercises { get; set; }
        public DbSet<Sets> Sets { get; set; }
        public DbSet<LoggedExercise> LoggedExercises { get; set; }
        
        protected override void OnModelCreating(ModelBuilder builder)
        {

        
            base.OnModelCreating(builder); 
            List<IdentityRole> roles = new List<IdentityRole>
            {
                new IdentityRole
                {
                    Name = "Admin",
                    NormalizedName = "ADMIN"
                },
                new IdentityRole
                {
                    Name = "User",
                    NormalizedName = "USER"
                },
            };
            builder.Entity<IdentityRole>().HasData(roles);
        } 
}