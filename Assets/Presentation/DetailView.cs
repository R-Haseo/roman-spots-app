using System;
using RomanSpots.Domain;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityApplication = UnityEngine.Application;

namespace RomanSpots.Presentation
{
    public sealed class DetailView : MonoBehaviour
    {
        [SerializeField] private TMP_Text _nameText;
        [SerializeField] private TMP_Text _infoText;
        [SerializeField] private Button _backButton;
        [SerializeField] private Button _mapButton;
        [SerializeField] private Button _referenceButton;

        private Spot _spot;
        private Action _onBackClicked;

        public void Initialize(Action onBackClicked)
        {
            _onBackClicked = onBackClicked;

            _backButton.onClick.RemoveAllListeners();
            _backButton.onClick.AddListener(() => _onBackClicked?.Invoke());

            _mapButton.onClick.RemoveAllListeners();
            _mapButton.onClick.AddListener(() => OpenUrl(_spot?.MapUrl));

            _referenceButton.onClick.RemoveAllListeners();
            _referenceButton.onClick.AddListener(() => OpenUrl(_spot?.ReferenceUrl));
        }

        public void SetData(Spot spot)
        {
            _spot = spot;
            _nameText.text = spot.Name;
            _infoText.text =
                $"{spot.Prefecture}\n" +
                $"{spot.Category}\n\n" +
                $"{spot.Description}\n\n" +
                $"{spot.ImageAddress}\n\n";
        }

        private void OpenUrl(string url)
        {
            if (string.IsNullOrWhiteSpace(url))
            {
                return;
            }

            UnityApplication.OpenURL(url);
        }
    }
}