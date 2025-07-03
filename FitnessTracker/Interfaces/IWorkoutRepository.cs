using FitnessTracker.DTOs.WorkoutDTOs;
using FitnessTracker.Models;
using Microsoft.AspNetCore.Mvc;

namespace FitnessTracker.Interfaces;

public interface IWorkoutRepository
{
    Task<Workout?> CreateWorkout(Workout workout);
    Task<Workout> GetWorkoutById(int id, string userId);
    Task<Workout?> GetWorkoutbyDate(DateTime data);
    Task<List<Workout>> GetWorkoutsByUser(string appUserId);
    Task<Workout> UpdateWorkout(int id, UpdateWorkoutDto dto);
    Task<Workout> DeleteWorkout(int id);
}