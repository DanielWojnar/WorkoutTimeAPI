using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using WorkoutTimeAPI.Models;

namespace WorkoutTimeAPI.Data
{
    public class WorkoutTimeContext : DbContext
    {
        public WorkoutTimeContext(DbContextOptions<WorkoutTimeContext> options) : base(options)
        {
        }
        public DbSet<Workout> Workouts { get; set; }
        public DbSet<Exercise> Exercises { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Workout>().HasMany(x => x.Exercises).WithOne(x => x.Parent);
            modelBuilder.Entity<Exercise>().HasOne(x => x.Parent).WithMany(x => x.Exercises);
        }
    }
}
