using Assets.Lib.OysterInterop.Inherit;
using Oyster.Core.AbstractTypes.Character;
using UnityEngine;

namespace Assets.Lib.OysterInterop
{
    internal class U_CharacterMaterial : MonoBehaviour, IsASpriteManager
    {
        // Editor Variables
        [Header("Character Mesh")]
        [SerializeField]
        private MeshRenderer _characterMesh;
        [Header("Material List")]
        [SerializeField]
        private U_Material[] _materials;

        // Private Variables
        private CharacterMaterial _characterMaterial;

        // On start
        private void Start()
        {
            if (_characterMaterial == null) MakeMaterial();
        }

        // Private Methods
        private void MakeMaterial()
        {
            // Read in materials
            Material_Internal[] m = new Material_Internal[_materials.Length];
            for (int i = 0; i < m.Length; i++) m[i] = _materials[i].Material;

            _characterMaterial = new CharacterMaterial(m, _characterMesh);
        }

        // Accessors
        public A_CharacterSprite Manager
        {
            get
            {
                if (_characterMaterial == null) MakeMaterial();
                return _characterMaterial;
            }
        }
    }
}
