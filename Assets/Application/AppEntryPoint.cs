using UnityEngine;
using VContainer.Unity;

namespace RomanSpots.Application
{
    public sealed class AppEntryPoint : IInitializable
    {
        public void Initialize()
        {
            Debug.Log("Roman Spots App initialized.");
        }
    }
}
