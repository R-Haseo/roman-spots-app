using VContainer;
using VContainer.Unity;
using RomanSpots.Application;
using RomanSpots.Presentation;
using RomanSpots.Infrastructure;

namespace RomanSpots.DI
{
    public sealed class MainLifetimeScope : LifetimeScope
    {
        protected override void Configure(IContainerBuilder builder)
        {
            // Repositories
            builder.Register<ISpotRepository, JsonSpotRepository>(Lifetime.Singleton);
            
            // Presenters
            builder.Register<MainPresenter>(Lifetime.Singleton);

            // Entry Points
            builder.RegisterEntryPoint<AppEntryPoint>();
        }
    }
}
