
using System.Collections.Generic;
using RomanSpots.Domain;

namespace RomanSpots.Application
{
    public interface ISpotRepository
    {
        IReadOnlyList<Spot> GetAll();
    }
}
