using System;
using RomanSpots.Domain;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace RomanSpots.Presentation
{
    public sealed class SpotItemView : MonoBehaviour
    {
        [SerializeField] private TMP_Text _nameText;
        [SerializeField] private TMP_Text _infoText;
        [SerializeField] private Button _button;

        private Spot _spot;
        private Action<Spot> _onClicked;

        public void SetData(Spot spot, Action<Spot> onClicked)
        {
            _spot = spot;
            _onClicked = onClicked;

            _nameText.text = spot.Name;
            _infoText.text = $"{spot.Prefecture} / {spot.Category}";

            _button.onClick.RemoveAllListeners();
            _button.onClick.AddListener(() => _onClicked?.Invoke(_spot));
        }
    }
}
