using System.Collections.Generic;

namespace RomanSpots.Infrastructure.DTO
{
    public sealed class SpotListDto
    {
        public List<SpotDto> Spots { get; set; } = new();
    } 
}
