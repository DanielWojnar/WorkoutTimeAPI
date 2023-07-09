using System.ComponentModel.DataAnnotations;

namespace WorkoutTimeAPI.Models
{
    public class Exercise
    {
        [Key]
        public string Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public float RestBetweenSets { get; set; }
        [Required]
        public float RestAfter { get; set; }
        [Required]
        public int Sets { get; set; }
        [Required]
        public Workout Parent { get; set; }
    }
}
