using Assets.Lib.OysterInterop.Inherit;
using Oyster.Core;
using Oyster.Core.AbstractTypes.Player;
using UnityEngine;

namespace Assets.Lib.OysterInterop
{
    public class U_PlayerTalker : MonoBehaviour
    {
        // Editor Variables
        [Header("Camera Config")]
        [SerializeField]
        private U_Camera _camera;
        [Header("Speech Display Config")]
        [SerializeField]
        private U_TextField _nameText;
        [SerializeField]
        private U_TextField _mainText;
        [SerializeField]
        private U_ShowAndHide _nameTextBacking;
        [SerializeField]
        private U_ShowAndHide _mainTextBacking;
        [SerializeField]
        private U_ShowAndHide _continuePrompt;

        // Private Variables
        private PlayerTalker _playerTalker;
        private SpeechDisplay _speechDisplay;

        // On Start
        void Start()
        {
            // Make speech display
            _speechDisplay = new SpeechDisplay(
                _nameText,
                _mainText,
                _nameTextBacking,
                _mainTextBacking,
                _continuePrompt
                );

            // Get camera
            A_Camera camera = null;
            if (_camera != null) camera = _camera.OysterCamera;

            // Make player talker
            _playerTalker = new PlayerTalker(camera, _speechDisplay);

            // Register
            OysterMain.PlayerTalker = _playerTalker;
        }

        // Accessors
        /// <summary>
        /// Gets a reference to the internal player talker object.
        /// </summary>
        public PlayerTalker Talker
        {
            get { return _playerTalker; }
        }
    }
}