using Oyster.Core.AbstractTypes;
using Oyster.Core.AbstractTypes.Character;
using UnityEngine;

namespace Assets.Lib.OysterInterop.Inherit
{
    internal class CharacterMaterial : A_CharacterSprite
    {
        // Private Variables
        private MeshRenderer _display;

        // Constructor
        public CharacterMaterial(A_Sprite[] sprites, MeshRenderer display) : base(sprites) { _display = display; }

        // Protected Methods
        protected override void OnSpriteSet(A_Sprite sprite)
        {
            // Set sprite
            _display.material = sprite.Sprite as Material;
        }
    }
}
