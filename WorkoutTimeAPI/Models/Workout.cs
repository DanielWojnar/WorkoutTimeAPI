using Microsoft.Extensions.Hosting;
using System.ComponentModel.DataAnnotations;

namespace WorkoutTimeAPI.Models
{
    public class Workout
    {
        [Key]
        public string Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int Popularity { get; set; } = 1;
        public List<Exercise> Exercises { get; set; }
    }
}
