using System;
using System.Collections.Generic;
using RomanSpots.Domain;
using UnityEngine;

namespace RomanSpots.Presentation
{
    public sealed class MainView : MonoBehaviour
    {
        [SerializeField] private GameObject _listViewRoot;
        [SerializeField] private DetailView _detailView;
        [SerializeField] private Transform _contentRoot;
        [SerializeField] private SpotItemView _spotItemPrefab;

        public void ShowSpots(IReadOnlyList<Spot> spots, Action<Spot> onSpotClicked)
        {
            ClearSpotItems();

            foreach (var spot in spots)
            {
                var item = Instantiate(_spotItemPrefab, _contentRoot);
                item.SetData(spot, onSpotClicked);
            }

            ShowList();
        }

        public void ShowList()
        {
            _listViewRoot.SetActive(true);
            _detailView.gameObject.SetActive(false);
        }

        public void ShowDetail(Spot spot)
        {
            _listViewRoot.SetActive(false);
            _detailView.gameObject.SetActive(true);
            _detailView.SetData(spot);
        }

        private void ClearSpotItems()
        {
            foreach (Transform child in _contentRoot)
            {
                Destroy(child.gameObject);
            }
        }
    }
}
