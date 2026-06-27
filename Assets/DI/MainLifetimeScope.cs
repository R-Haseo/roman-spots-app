using VContainer;
using VContainer.Unity;
using RomanSpots.Application;

namespace RomanSpots.DI
{
    public sealed class MainLifetimeScope : LifetimeScope
    {
        protected override void Configure(IContainerBuilder builder)
        {
            builder.RegisterEntryPoint<AppEntryPoint>();
        }
    }
}
