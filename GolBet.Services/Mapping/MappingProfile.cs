// GolBet.Services/Mapping/MappingProfile.cs
using AutoMapper;
using GolBet.Entities;

namespace GolBet.Services;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        // Flattening by convention:
        // MatchDto.HomeTeamName  <- Match.HomeTeam.Name
        // MatchDto.AwayTeamCrestUrl <- Match.AwayTeam.CrestUrl
        CreateMap<Match, MatchDto>();
    }
}
