using Assets.Lib.OysterInterop.Inherit;
using Oyster.Core.AbstractTypes.Character;
using Oyster.Core.AbstractTypes.Character.Sound;
using Oyster.Core.AbstractTypes.Scene;
using UnityEngine;

namespace Assets.Lib.OysterInterop
{
    public class U_CharacterTalker : MonoBehaviour
    {
        // Editor Variables
        [SerializeField]
        protected U_CharacterData _characterData;
        [SerializeField]
        protected U_CharacterSound _characterSound;
        [SerializeField]
        protected U_LookTarget _lookTarget;

        // Private Variables
        protected IsASpriteManager _spriteManager;
        protected CharacterTalker _talker;

        // On Start
        protected virtual void Start()
        {
            // Get component
            A_CharacterSprite spriteManager = null;
            if (!TryGetComponent(out _spriteManager))
            {
                Debug.LogWarning($"Character '{gameObject.name}' does not have a 'IsASpriteManager', defaulting to null.");
            }
            else
            {
                spriteManager = _spriteManager.Manager;
            }

            // Attempt to get looker
            A_Looker looker = null;
            if (_lookTarget != null) looker = _lookTarget.Looker;

            // Make talker
            _talker = new CharacterTalker(
                Data,
                spriteManager,
                Sound,
                looker
                );
        }

        // Accessors
        protected A_CharacterData Data
        {
            get
            {
                if (_characterData == null) return null;
                return _characterData.Data;
            }
        }
        protected A_CharacterSound Sound
        {
            get
            {
                if (_characterSound == null) return null;
                return _characterSound.CharacterSound;
            }
        }
        public CharacterTalker Talker { get { return _talker; } }
    }
}
