using AutoMapper;
using Microsoft.EntityFrameworkCore;
using WorkoutTimeAPI.Data;
using WorkoutTimeAPI.Dtos;
using WorkoutTimeAPI.Models;

namespace WorkoutTimeAPI.Services
{
    public class WorkoutService : IWorkoutService
    {
        private readonly IMapper _mapper;
        private readonly WorkoutTimeContext _context;
        public WorkoutService(IMapper mapper, WorkoutTimeContext context) {
            _mapper = mapper;
            _context = context;
        }

        public async Task AddWorkout(WorkoutDto workoutDto)
        {
            var workout = _mapper.Map<Workout>(workoutDto);
            await _context.Workouts.AddAsync(workout);
            await _context.SaveChangesAsync();
        }

        public async Task<WorkoutDto?> GetWorkout(string id)
        {
            var workout = await _context.Workouts.Where(x => x.Id == id).Include(x => x.Exercises).FirstOrDefaultAsync();
            if(workout == null)
            {
                return null;
            }
            workout.Popularity = workout.Popularity + 1;
            _context.Workouts.Update(workout);
            await _context.SaveChangesAsync();
            var result = _mapper.Map<WorkoutDto>(workout);
            return result;
        }

        public async Task<IEnumerable<WorkoutDto>> GetWorkouts()
        {
            var workouts = await _context.Workouts.OrderByDescending(x => x.Popularity).Include(x => x.Exercises).Take(100).AsNoTracking().ToListAsync();
            var result = _mapper.Map<List<WorkoutDto>>(workouts);
            return result;
        }
    }
}
