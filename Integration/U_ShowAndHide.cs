using Oyster.Core.Interfaces.Things;
using UnityEngine;

namespace Assets.Lib.OysterInterop
{
    internal class U_ShowAndHide : MonoBehaviour, IShowAndHide
    {
        // Editor Variables
        [SerializeField]
        private GameObject _thing;

        // Public Methods
        public void Hide()
        {
            // Hide self
            _thing.SetActive(false);
        }
        public void Show()
        {
            // Show self
            _thing.SetActive(true);
        }
    }
}
