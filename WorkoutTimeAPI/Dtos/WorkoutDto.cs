using System.Text.Json.Serialization;

namespace WorkoutTimeAPI.Dtos
{
    public class WorkoutDto
    {
        [JsonPropertyName("uid")]
        public string Id { get; set; }
        public string Name { get; set; }
        public List<ExerciseDto> Exercises { get; set; }
    }
}
