using UnityEngine;
using VContainer.Unity;
using RomanSpots.Presentation;

namespace RomanSpots.DI
{
    public sealed class AppEntryPoint : IInitializable
    {
        private readonly MainPresenter _presenter;

        public AppEntryPoint(MainPresenter presenter)
        {
            _presenter = presenter;
        }

        public void Initialize()
        {
            _presenter.Initialize();
        }
    }
}
