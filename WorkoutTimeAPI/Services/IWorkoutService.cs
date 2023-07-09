using WorkoutTimeAPI.Dtos;

namespace WorkoutTimeAPI.Services
{
    public interface IWorkoutService
    {
        public Task AddWorkout(WorkoutDto workoutDto);
        public Task<WorkoutDto?> GetWorkout(string id);
        public Task<IEnumerable<WorkoutDto>> GetWorkouts();
    }
}
