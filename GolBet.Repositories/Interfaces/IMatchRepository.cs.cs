// GolBet.Repositories/Interfaces/IMatchRepository.cs
using GolBet.Entities;

namespace GolBet.Repositories;

public interface IMatchRepository : IGenericRepository<Match>
{
    Task<IEnumerable<Match>> GetAllWithTeamsAsync(MatchStatus? status = null);
    Task<Match?> GetByIdWithDetailsAsync(int id);
}