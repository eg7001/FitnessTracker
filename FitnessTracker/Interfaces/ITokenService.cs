using FitnessTracker.Models;

namespace FitnessTracker.Interfaces;

public interface ITokenService
{
    string CreateToken(AppUser user);
}