using Oyster.Core.Interfaces.Things;
using UnityEngine;

namespace Assets.Lib.OysterInterop.Inherit
{
    public class ShowAndHide : IShowAndHide
    {
        // Private Variables
        private GameObject _gameObject;

        // Constructor
        public ShowAndHide(GameObject gameObject)
        {
            // Pass Value
            _gameObject = gameObject;
        }

        // Public Methods
        public void Hide()
        {
            _gameObject.SetActive(false);
        }

        public void Show()
        {
            _gameObject.SetActive(true);
        }
    }
}