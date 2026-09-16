// GolBet.Services/Interfaces/IMatchService.cs
using GolBet.Entities;

namespace GolBet.Services;

public interface IMatchService
{
    /// <summary>Match board: all active matches ordered by date.</summary>
    Task<IEnumerable<MatchDto>> GetBoardAsync(MatchStatus? status = null);
}
