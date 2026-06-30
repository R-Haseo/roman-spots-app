using UnityEngine;
using RomanSpots.Domain;
using RomanSpots.Application;

namespace RomanSpots.Presentation
{
    public sealed class MainPresenter
    {
        private readonly MainView _mainView;
        private readonly ISpotRepository _repository;

        public MainPresenter(MainView mainView, ISpotRepository repository)
        {
            _mainView = mainView;
            _repository = repository;
        }

        public void Initialize()
        {
            var spots = _repository.GetAll();

            _mainView.ShowSpots(spots, OnSpotClicked);
        }

        private void OnSpotClicked(Spot spot)
        {
            Debug.Log(spot.Name);
        }
    }
}
