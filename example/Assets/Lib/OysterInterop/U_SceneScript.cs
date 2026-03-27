using Assets.Lib.OysterInterop.Inherit;
using Oyster.Core;
using Oyster.Core.AbstractTypes.Scene;
using UnityEngine;

namespace Assets.Lib.OysterInterop
{
    public class U_SceneScript : MonoBehaviour
    {
        // Editor Variables
        [SerializeField]
        private GameObject[] _hideInConversation;
        [SerializeField]
        private U_LookTarget[] _lookTargets;

        // Private Variables
        private ShowAndHide[] _hiders;
        private A_Looker[] _lookers;
        private SceneScript _sceneScript;

        // On Start
        private void Start()
        {
            // Make if null
            if (_sceneScript == null) MakeScript();
        }
        // Every frame
        private void Update()
        {
            // Give Oyster a heartbeat
            OysterMain.Update(Time.deltaTime);
        }

        // Private Methods
        private void MakeScript()
        {
            // Make show and hides
            _hiders = new ShowAndHide[_hideInConversation.Length];
            for (int i = 0; i < _hideInConversation.Length; i++) _hiders[i] = new ShowAndHide(_hideInConversation[i]);

            // Make lookers
            _lookers = new A_Looker[_lookTargets.Length];
            for (int i = 0; i < _lookTargets.Length; i++) _lookers[i] = new A_Looker(_lookTargets[i].Name, _lookTargets[i].Target);

            // Make scene script
            _sceneScript = new SceneScript(_hiders, _lookers);

            // Register self
            OysterMain.SceneScript = _sceneScript;

            // Log a cheeky message
            OysterLogger.DebugMessage("Scene script registered!", Oyster.DebugOut.Severity.Log);
        }

        // Public Methods
        /// <summary>
        /// Attempts to start a chat between the given player talker and character talker.
        /// </summary>
        public void StartChat(PlayerTalker playerTalker, CharacterTalker characterTalker)
        {
            if (_sceneScript == null) MakeScript();
            _sceneScript.StartChat(playerTalker, characterTalker);
        }
    }
}