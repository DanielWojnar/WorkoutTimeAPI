using System.Text.Json.Serialization;

namespace WorkoutTimeAPI.Dtos
{
    public class ExerciseDto
    {
        [JsonPropertyName("uid")]
        public string Id { get; set; }
        public string Name { get; set; }
        public float RestBetweenSets { get; set; }
        public float RestAfter { get; set; }
        public int Sets { get; set; }
    }
}
