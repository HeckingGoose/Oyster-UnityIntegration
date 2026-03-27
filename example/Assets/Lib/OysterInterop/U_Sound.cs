using Assets.Lib.OysterInterop.Inherit;
using UnityEngine;

namespace Assets.Lib.OysterInterop
{
    public class U_Sound : MonoBehaviour
    {
        // Editor Variables
        [SerializeField]
        private string _name;
        [SerializeField]
        private AudioClip _clip;

        // Private Variables
        private SoundInternal _sound;

        // Unity Methods
        private void Start()
        {
            // Make sound
            if (_sound == null) _sound = new SoundInternal(_name, _clip);
        }

        // Accessors
        public SoundInternal Sound
        {
            get
            {
                if (_sound == null) _sound = new SoundInternal(_name, _clip);
                return _sound;
            }
        }
    }
}
