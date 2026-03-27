using Oyster.Core.AbstractTypes.Character.Sound;
using UnityEngine;

namespace Assets.Lib.OysterInterop.Inherit
{
    public class SoundPlayer : A_SoundPlayer
    {
        // Private Variables
        private AudioSource _audioSource;
        private A_Sound _sound;

        // Constructor
        public SoundPlayer(ref AudioSource source)
        {
            // Pass Value
            _audioSource = source;
        }
        public SoundPlayer(ref AudioSource source, A_Sound sound) : this(ref source)
        {
            // Check null
            if (sound == null) return;

            // Pass sound
            Sound = sound;
        }

        // Public Methods
        public override void Play()
        {
            _audioSource.Play();
        }
        public override void Pause()
        {
            _audioSource.Pause();
        }
        public override void Stop()
        {
            _audioSource.time = 0;
            _audioSource.Stop();
        }

        // Accessors
        public override A_Sound Sound
        {
            get { return _sound; }
            set { _sound = value; _audioSource.clip = (AudioClip)_sound.Sound; }
        }
        public override bool IsPlaying
        {
            get { return _audioSource.isPlaying; }
        }
        public override bool IsLooping
        {
            get { return _audioSource.loop; }
            set { _audioSource.loop = value; }
        }
        public override float Time
        {
            get { return _audioSource.time; }
            set { _audioSource.time = value; }
        }
        public override float Length { get { if (_audioSource.clip != null) return _audioSource.clip.length; return 0.0f; } }
    }
}
