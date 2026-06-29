using System.Collections.Generic;
using RomanSpots.Domain;
using UnityEngine;

namespace RomanSpots.Presentation
{
    public sealed class MainView : MonoBehaviour
    {
        [SerializeField] private Transform _contentRoot;
        [SerializeField] private SpotItemView _spotItemPrefab;

        public void ShowSpots(IReadOnlyList<Spot> spots)
        {
            foreach (Transform child in _contentRoot)
            {
                Destroy(child.gameObject);
            }

            foreach (var spot in spots)
            {
                var item = Instantiate(_spotItemPrefab, _contentRoot);
                item.SetData(spot);
            }
        }
    }
}
