using System;
using RomanSpots.Domain;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace RomanSpots.Presentation
{
    public sealed class DetailView : MonoBehaviour
    {
        [SerializeField] private TMP_Text _nameText;
        [SerializeField] private TMP_Text _infoText;
        [SerializeField] private Button _backButton;

        private Action _onBackClicked;

        public void Initialize(Action onBackClicked)
        {
            _onBackClicked = onBackClicked;

            _backButton.onClick.RemoveAllListeners();
            _backButton.onClick.AddListener(() => _onBackClicked?.Invoke());
        }

        public void SetData(Spot spot)
        {
            _nameText.text = spot.Name;
            _infoText.text = $"{spot.Prefecture} / {spot.Category}";
        }
    }
}