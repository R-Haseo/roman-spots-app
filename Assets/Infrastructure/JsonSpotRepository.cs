using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using UnityEngine;
using UnityApplication = UnityEngine.Application;
using RomanSpots.Domain;
using RomanSpots.Application;
using RomanSpots.Infrastructure.DTO;

namespace RomanSpots.Infrastructure
{
    public sealed class JsonSpotRepository : ISpotRepository
    {
        private const string JsonPath = "Data/spots.json";
        public IReadOnlyList<Spot> GetAll()
        {
            var filePath = Path.Combine(UnityApplication.streamingAssetsPath, JsonPath);

            if (!File.Exists(filePath))
            {
                Debug.LogError($"Spot data file not found: {filePath}");
                return new List<Spot>();
            }

            var json = File.ReadAllText(filePath);
            var dto = JsonConvert.DeserializeObject<SpotListDto>(json);

            if (dto?.Spots == null)
            {
                Debug.LogError("Failed to deserialize spot data.");
                return new List<Spot>();
            }

            return dto.Spots
                .Select(x => new Spot(x.Id, x.Name, x.Prefecture, x.Category, x.Description, x.ImageAddress, x.MapUrl, x.ReferenceUrl))
                .ToList();
        }
    }
}
