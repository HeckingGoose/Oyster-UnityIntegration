using Oyster.Core.Interfaces.Things;
using Oyster.Core.Types;
using TMPro;
using UnityEngine;

namespace Assets.Lib.OysterInterop
{
    internal class U_TextField : MonoBehaviour, ITextField
    {
        // Editor Variables
        [SerializeField]
        private TextMeshProUGUI _textMesh;

        // Public Methods
        public void Clear()
        {
            // Empty box
            _textMesh.text = string.Empty;
        }
        public void Hide()
        {
            // Hide self
            _textMesh.alpha = 0;
        }
        public void Show()
        {
            // Show self
            _textMesh.alpha = 1;
        }

        // Accessors
        public string Text
        {
            get { return _textMesh.text; }
            set { _textMesh.text = value; }
        }
        public Colour TextColour
        {
            get { return _textMesh.color.ToOysterColour(); }
            set { _textMesh.color = value.ToUnityColour(); }
        }
    }
}
