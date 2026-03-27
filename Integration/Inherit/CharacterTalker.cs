using Oyster.Core.AbstractTypes.Character;
using Oyster.Core.AbstractTypes.Character.Sound;
using Oyster.Core.AbstractTypes.Scene;

namespace Assets.Lib.OysterInterop.Inherit
{
    public class CharacterTalker : A_CharacterTalker
    {
        // Constructor
        public CharacterTalker(
            A_CharacterData data,
            A_CharacterSprite spriteManager,
            A_CharacterSound characterSound,
            A_Looker looker
            ) : base(
                data,
                spriteManager,
                characterSound,
                looker)
        { }
    }
}
