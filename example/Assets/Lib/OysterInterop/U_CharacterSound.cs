using Assets.Lib.OysterInterop.Inherit;
using Oyster.Core.AbstractTypes.Character.Sound;
using UnityEngine;

namespace Assets.Lib.OysterInterop
{
    public class U_CharacterSound : MonoBehaviour
    {
        // Editor Variables
        [SerializeField]
        private U_SoundPlayer _soundPlayer;
        [SerializeField]
        private U_Sound[] _sounds;

        // Private Variables
        private CharacterSound _characterSound;

        // Unity Methods
        private void Awake()
        {
            // Make sound
            if (_sounds == null) _characterSound = new CharacterSound(_soundPlayer.SoundPlayer);
            else
            {
                // Generate raw sound array
                A_Sound[] sounds = new A_Sound[_sounds.Length];
                for (int i = 0; i < sounds.Length; i++) sounds[i] = _sounds[i].Sound;
                _characterSound = new CharacterSound(_soundPlayer.SoundPlayer, sounds);
            }
        }

        // Accessors
        public CharacterSound CharacterSound { get { return _characterSound; } }
    }
}
