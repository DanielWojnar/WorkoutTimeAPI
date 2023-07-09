using Microsoft.AspNetCore.Mvc;
using WorkoutTimeAPI.Dtos;
using WorkoutTimeAPI.Services;

namespace WorkoutTimeAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WorkoutController : ControllerBase
    {
        private readonly IWorkoutService _workoutService;
        public WorkoutController(IWorkoutService workoutService)
        {
            _workoutService = workoutService;
        }

        [HttpPost("AddWorkout")]
        public async Task<IActionResult> AddWorkout([FromBody] WorkoutDto workoutDto)
        {
            await _workoutService.AddWorkout(workoutDto);
            return Ok();
        }

        [HttpGet("GetWorkout/{id}")]
        public async Task<IActionResult> GetWorkout(string id)
        {
            var result = await _workoutService.GetWorkout(id);
            if(result == null)
            {
                return NotFound(result);
            }
            return Ok(result);
        }

        [HttpGet("GetWorkouts")]
        public async Task<IActionResult> GetWorkouts()
        {
            var result = await _workoutService.GetWorkouts();
            return Ok(result);
        }
    }
}
