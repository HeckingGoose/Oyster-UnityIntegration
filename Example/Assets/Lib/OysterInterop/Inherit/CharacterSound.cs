using Oyster.Core.AbstractTypes;
using Oyster.Core.AbstractTypes.Character.Sound;
using System;

namespace Assets.Lib.OysterInterop.Inherit
{
    public class CharacterSound : A_CharacterSound
    {
        // Constructors
        public CharacterSound(A_SoundPlayer soundPlayer) : base(soundPlayer) { }
        public CharacterSound(A_SoundPlayer soundPlayer, A_Sound[] sounds) : base(soundPlayer, sounds) { }

        // Protected Methods
        protected override A_BackgroundAssetLoader<A_Sound> LoadSound(string name)
        {
            throw new NotImplementedException();
        }
    }
}
