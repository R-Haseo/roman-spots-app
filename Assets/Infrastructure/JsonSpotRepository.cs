using System.Collections.Generic;
using RomanSpots.Domain;
using RomanSpots.Application;

namespace RomanSpots.Infrastructure
{
    public sealed class JsonSpotRepository : ISpotRepository
    {
        public IReadOnlyList<Spot> GetAll()
        {
            return new List<Spot>
            {
                new Spot("高崎白衣大観音")
            };
        }
    }
}
