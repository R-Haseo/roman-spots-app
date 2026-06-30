using RomanSpots.Domain;
using TMPro;
using UnityEngine;

namespace RomanSpots.Presentation
{
    public sealed class DetailView : MonoBehaviour
    {
        [SerializeField] private TMP_Text _nameText;
        [SerializeField] private TMP_Text _infoText;

        public void SetData(Spot spot)
        {
            _nameText.text = spot.Name;
            _infoText.text = $"{spot.Prefecture} / {spot.Category}";
        }
    }
}