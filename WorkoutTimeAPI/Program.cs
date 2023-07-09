using Microsoft.EntityFrameworkCore;
using WorkoutTimeAPI.Data;
using WorkoutTimeAPI.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddTransient<IWorkoutService, WorkoutService>();
builder.Services.AddAutoMapper(typeof(Program).Assembly);
string? WorkoutTimeConnection = builder.Configuration.GetConnectionString("WorkoutTimeAPI");
builder.Services.AddDbContext<WorkoutTimeContext>(
    options => options.UseSqlServer(WorkoutTimeConnection)
    );

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapControllers();

app.Run();
