using Oyster.Core.AbstractTypes.Character.Sound;
using UnityEngine;

namespace Assets.Lib.OysterInterop.Inherit
{
    public class SoundInternal : A_Sound
    {
        // Constructor
        public SoundInternal(string name, AudioClip sound) : base(name, sound) { }
    }
}
