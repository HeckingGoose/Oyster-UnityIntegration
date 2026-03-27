using UnityEngine;

namespace Assets.Lib.OysterInterop.Inherit
{
    public class U_SoundPlayer : MonoBehaviour
    {
        // Editor Variables
        [SerializeField]
        private AudioSource _source;
        [SerializeField]
        private U_Sound _clip;

        // Private Variables
        private SoundPlayer _soundPlayer;

        // Unity Methods
        private void Awake()
        {
            // Check sound player already exists
            if (_soundPlayer != null) return;

            // Make sound player
            MakeSoundPlayer();
        }

        // Private Methods
        private void MakeSoundPlayer()
        {
            if (_clip != null) _soundPlayer = new SoundPlayer(ref _source, _clip.Sound);
            else _soundPlayer = new SoundPlayer(ref _source);
        }

        // Accessors
        public SoundPlayer SoundPlayer
        {
            get
            {
                if (_soundPlayer == null) MakeSoundPlayer();
                return _soundPlayer;
            }
        }
    }
}
