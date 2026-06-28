using UnityEngine;
using RomanSpots.Application;

namespace RomanSpots.Presentation
{
    public sealed class MainPresenter
    {
        private readonly ISpotRepository _repository;

        public MainPresenter(ISpotRepository repository)
        {
            _repository = repository;
        }

        public void Initialize()
        {
            foreach (var spot in _repository.GetAll())
            {
                Debug.Log($"{spot.Name} / {spot.Prefecture} / {spot.Category}");
            }
        }
    }
}
