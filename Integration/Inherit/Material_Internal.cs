using Oyster.Core.AbstractTypes.Character;
using UnityEngine;

namespace Assets.Lib.OysterInterop.Inherit
{
    internal class Material_Internal : A_Sprite
    {
        // Private Variables
        private string _name;
        private Material _material;

        // Constructor
        public Material_Internal(string name, Material sprite)
        {
            // Pass Values
            _name = name;
            _material = sprite;
        }

        // Public 
        public override string Name { get { return _name; } }
        public override object Sprite { get { return _material; } }
    }
}
